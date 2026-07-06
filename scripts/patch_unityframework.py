#!/usr/bin/env python3
import argparse
import json
import struct
from pathlib import Path

import lief


DYLIB_LOAD = "@executable_path/Frameworks/libXueSongProbe.dylib"
PTR_MARKER = b"XSPPTRS1"


HOOKS = [
    {
        "name": "udp_send_payload",
        "rva": 0x0400B4F4,
        "handler": "xsp_udp_send_payload",
        "slot": 0,
        "args": "x0=self,x1=payload",
        "source": "PhxhSDK.FrameSync.Net.ReliableUdpClientChannel.Send(System.Byte[] payload)",
    },
    {
        "name": "udp_process_packet",
        "rva": 0x0400BF28,
        "handler": "xsp_udp_process_packet",
        "slot": 1,
        "args": "x0=self,x1=packet",
        "source": "PhxhSDK.FrameSync.Net.ReliableUdpClientChannel.ProcessPacket(System.Byte[] packet)",
    },
    {
        "name": "config_bytebuf_wrap",
        "rva": 0x03ACDA84,
        "handler": "xsp_config_bytebuf_wrap",
        "slot": 2,
        "args": "x0=bytes",
        "source": "Luban.ByteBuf.Wrap(System.Byte[] bytes)",
    },
    {
        "name": "config_from_string",
        "rva": 0x03AD2768,
        "handler": "xsp_config_from_string",
        "slot": 3,
        "args": "x0=value",
        "source": "Luban.ByteBuf.FromString(System.String value)",
    },
]


POST_ONLY_TARGETS = [
    {
        "name": "dll_decrypted_stream_post_point",
        "candidate_function_rva": 0x0401BFF8,
        "handler": "xsp_dll_blob",
        "source": "PhxhSDK.AOT.YooDecryptionFS.LoadAssetBundle(YooAsset.DecryptFileInfo fileInfo, System.IO.Stream& managedStream)",
        "note": "需要在 IDA 中精确到 managedStream 已指向解密后数据流、AssetBundle.LoadFromStream 前后的指令 RVA；入口点拿不到明文 bundle。",
    },
]


def u32(v):
    return struct.pack("<I", v & 0xFFFFFFFF)


def patch_branch(from_va, to_va, link=True):
    delta = to_va - from_va
    if delta % 4:
        raise ValueError("branch target is not 4-byte aligned")
    imm26 = delta // 4
    if not -(1 << 25) <= imm26 < (1 << 25):
        raise ValueError(f"branch out of range: {delta:#x}")
    op = 0x94000000 if link else 0x14000000
    return u32(op | (imm26 & 0x03FFFFFF))


def stp_pre(rt, rt2, rn=31, imm=-16):
    imm7 = imm // 8
    return u32(0xA9800000 | ((imm7 & 0x7F) << 15) | (rt2 << 10) | (rn << 5) | rt)


def ldp_post(rt, rt2, rn=31, imm=16):
    imm7 = imm // 8
    return u32(0xA8C00000 | ((imm7 & 0x7F) << 15) | (rt2 << 10) | (rn << 5) | rt)


def adrp(rd, pc_va, target_va):
    pc_page = pc_va & ~0xFFF
    target_page = target_va & ~0xFFF
    imm = (target_page - pc_page) >> 12
    if not -(1 << 20) <= imm < (1 << 20):
        raise ValueError("adrp target out of range")
    immlo = imm & 0x3
    immhi = (imm >> 2) & 0x7FFFF
    return u32(0x90000000 | (immlo << 29) | (immhi << 5) | rd)


def ldr_unsigned(rt, rn, offset):
    if offset % 8:
        raise ValueError("ldr x offset must be 8-byte aligned")
    imm12 = offset // 8
    if not 0 <= imm12 < 4096:
        raise ValueError("ldr x offset out of range")
    return u32(0xF9400000 | (imm12 << 10) | (rn << 5) | rt)


def cbz(rt, pc_va, target_va):
    delta = target_va - pc_va
    if delta % 4:
        raise ValueError("cbz target is not 4-byte aligned")
    imm19 = delta // 4
    if not -(1 << 18) <= imm19 < (1 << 18):
        raise ValueError("cbz target out of range")
    return u32(0xB4000000 | ((imm19 & 0x7FFFF) << 5) | rt)


def blr(rn):
    return u32(0xD63F0000 | (rn << 5))


def nop():
    return u32(0xD503201F)


def make_trampoline(tramp_va, target_return_va, slot_va):
    code = bytearray()

    # Preserve argument registers plus link register. The original function sees
    # the same x0-x7/x30 values after the probe call returns.
    for a, b in [(0, 1), (2, 3), (4, 5), (6, 7), (30, 30)]:
        code += stp_pre(a, b)

    adrp_pc = tramp_va + len(code)
    page_off = slot_va & 0xFFF
    code += adrp(16, adrp_pc, slot_va)
    code += ldr_unsigned(16, 16, page_off)
    cbz_pc = tramp_va + len(code)
    # Patched after restore_start is known.
    code += b"\x00\x00\x00\x00"
    code += blr(16)

    restore_start = tramp_va + len(code)
    code[cbz_pc - tramp_va: cbz_pc - tramp_va + 4] = cbz(16, cbz_pc, restore_start)

    for a, b in [(30, 30), (6, 7), (4, 5), (2, 3), (0, 1)]:
        code += ldp_post(a, b)

    code += patch_branch(tramp_va + len(code), target_return_va, link=False)
    while len(code) % 16:
        code += nop()
    return bytes(code)


def find_zero_cave(binary, section_name, size, align=8):
    sec = binary.get_section(section_name)
    if sec is None:
        raise RuntimeError(f"missing section {section_name}")
    content = bytes(sec.content)
    for off in range(0, len(content) - size):
        va = sec.virtual_address + off
        if va % align:
            continue
        if content[off: off + size] == b"\x00" * size:
            return va
    raise RuntimeError(f"no {size}-byte zero cave in {section_name}")


def main():
    parser = argparse.ArgumentParser(description="Static UnityFramework probe patcher for XueSong.")
    parser.add_argument("input", type=Path, help="Original UnityFramework Mach-O")
    parser.add_argument("output", type=Path, help="Patched UnityFramework path")
    parser.add_argument("--report", type=Path, default=Path("xuesong_patch_report.json"))
    args = parser.parse_args()

    binary = lief.parse(str(args.input))
    if binary is None:
        raise SystemExit("failed to parse input Mach-O")

    if binary.find_library(DYLIB_LOAD) is None:
        binary.add_library(DYLIB_LOAD)

    text_section = binary.get_section("__text")
    data_section = binary.get_section("__data")
    if text_section is None or data_section is None:
        raise SystemExit("missing __text or __data section")

    ptr_content = bytearray(PTR_MARKER)
    ptr_content += b"\x00" * (8 * len(HOOKS))
    ptr_size = (len(ptr_content) + 15) & ~15
    tramp_size = 0x100 * len(HOOKS)

    old_text_size = text_section.size
    if not binary.extend_section(text_section, tramp_size):
        raise SystemExit("failed to extend __text")
    ptr_va_planned = find_zero_cave(binary, "__data", ptr_size, align=8)

    # Rebuild once so LIEF assigns final section addresses.
    tmp = args.output.with_suffix(args.output.suffix + ".stage1")
    binary.write(str(tmp))
    binary = lief.parse(str(tmp))

    text_section = binary.get_section("__text")
    ptr_va = ptr_va_planned
    text_va = text_section.virtual_address + old_text_size

    report = {
        "dylib": DYLIB_LOAD,
        "pointer_table_marker": PTR_MARKER.decode("ascii", errors="replace"),
        "pointer_table_rva": ptr_va - binary.imagebase,
        "trampoline_area_rva": text_va - binary.imagebase,
        "hooks": [],
        "post_only_targets": POST_ONLY_TARGETS,
    }

    for hook in HOOKS:
        target_va = binary.imagebase + hook["rva"]
        return_va = target_va + 4
        tramp_va = text_va + hook["slot"] * 0x100
        slot_va = ptr_va + len(PTR_MARKER) + hook["slot"] * 8
        tramp = make_trampoline(tramp_va, return_va, slot_va)

        if len(tramp) > 0x100:
            raise SystemExit(f"trampoline too large for {hook['name']}")
        binary.patch_address(tramp_va, list(tramp))
        binary.patch_address(target_va, list(patch_branch(target_va, tramp_va, link=True)))

        item = dict(hook)
        item.update({
            "target_va": target_va,
            "trampoline_rva": tramp_va - binary.imagebase,
            "slot_rva": slot_va - binary.imagebase,
            "patched_instruction": patch_branch(target_va, tramp_va, link=True).hex(),
        })
        report["hooks"].append(item)

    binary.patch_address(ptr_va, list(ptr_content + b"\x00" * (ptr_size - len(ptr_content))))
    binary.write(str(args.output))
    if tmp.exists():
        tmp.unlink()
    args.report.write_text(json.dumps(report, indent=2, ensure_ascii=False), encoding="utf-8")
    print(f"patched: {args.output}")
    print(f"report:  {args.report}")


if __name__ == "__main__":
    main()

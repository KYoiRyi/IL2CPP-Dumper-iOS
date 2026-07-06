# XueSong UnityFramework Static Probe

This branch removes the original runtime IL2CPP metadata dumper and keeps the
project as a small iOS probe library plus a LIEF-based static patcher.

The patched `UnityFramework` does not need runtime code-page modification. The
patcher appends ARM64 trampoline code to `__text`, places a writable pointer
table in an existing `__data` zero cave, adds:

```text
@executable_path/Frameworks/libXueSongProbe.dylib
```

and replaces selected function-entry instructions with `BL trampoline`.

At load time `libXueSongProbe.dylib` scans the `UnityFramework` writable
segments for the `XSPPTRS1` table and fills handler function pointers. The
trampolines call those handlers, restore registers, and branch back to the
original function after the overwritten instruction.

## Current Static Entry Probes

- `0x0400B4F4`
  `PhxhSDK.FrameSync.Net.ReliableUdpClientChannel.Send(System.Byte[] payload)`
- `0x0400BF28`
  `PhxhSDK.FrameSync.Net.ReliableUdpClientChannel.ProcessPacket(System.Byte[] packet)`
- `0x03ACDA84`
  `Luban.ByteBuf.Wrap(System.Byte[] bytes)`
- `0x03AD2768`
  `Luban.ByteBuf.FromString(System.String value)`

Output is written under the app sandbox:

```text
$HOME/Documents/XueSongProbe/
  udp/
  config/
  dll/
```

## DLL Decryption Probe

`PhxhSDK.AOT.YooDecryptionFS.LoadAssetBundle` starts at RVA `0x0401BFF8`, but
the decrypted bundle bytes are not available at function entry. Use IDA to pick
an internal post-decryption instruction address where the managed stream or
buffer is live, then add that RVA to `scripts/patch_unityframework.py` with an
argument adapter for `xsp_dll_blob(const void *, uint64_t)`.

The report file includes this target as a `post_only_targets` reminder.

## Build Probe Library

With Theos configured:

```bash
make clean package FINALPACKAGE=1
```

The dylib must be placed in the app bundle at:

```text
Payload/ProductName.app/Frameworks/libXueSongProbe.dylib
```

The app must then be re-signed together with the patched framework and dylib.

## Patch UnityFramework

```bash
python3 scripts/patch_unityframework.py \
  Payload/ProductName.app/Frameworks/UnityFramework.framework/UnityFramework \
  UnityFramework.patched \
  --report xuesong_patch_report.json
```

Replace the original framework binary with `UnityFramework.patched`, copy the
probe dylib into `Frameworks/`, and re-sign.


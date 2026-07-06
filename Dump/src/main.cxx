#include <atomic>
#include <cstdint>
#include <cstdio>
#include <cstdlib>
#include <cstring>
#include <ctime>
#include <cerrno>
#include <mach-o/dyld.h>
#include <mach-o/loader.h>
#include <mach/vm_prot.h>
#include <mutex>
#include <string>
#include <sys/stat.h>
#include <unistd.h>

extern "C" __attribute__((visibility("default"))) void xsp_udp_send_payload(void * self, void * payload);
extern "C" __attribute__((visibility("default"))) void xsp_udp_process_packet(void * self, void * packet);
extern "C" __attribute__((visibility("default"))) void xsp_config_bytebuf_wrap(void * bytes);
extern "C" __attribute__((visibility("default"))) void xsp_config_from_string(void * value);
extern "C" __attribute__((visibility("default"))) void xsp_dll_blob(const void * data, uint64_t size);

namespace {

struct Il2CppArrayHeader {
    void * klass;
    void * monitor;
    void * bounds;
    uintptr_t max_length;
    uint8_t vector[0];
};

struct Il2CppStringHeader {
    void * klass;
    void * monitor;
    int32_t length;
    uint16_t chars[0];
};

std::mutex g_lock;
std::atomic<uint64_t> g_counter { 0 };
std::string g_root;

static bool Mkdir(const std::string & path) {
    if (path.empty())
        return false;
    if (::mkdir(path.c_str(), 0700) == 0 || errno == EEXIST)
        return true;
    return false;
}

static std::string RootDir() {
    if (!g_root.empty())
        return g_root;

    const char * home = std::getenv("HOME");
    std::string base = (home && *home) ? home : "/tmp";
    g_root = base + "/Documents/XueSongProbe";
    Mkdir(base + "/Documents");
    Mkdir(g_root);
    Mkdir(g_root + "/udp");
    Mkdir(g_root + "/config");
    Mkdir(g_root + "/dll");
    return g_root;
}

static uint64_t NowMs() {
    timespec ts {};
    clock_gettime(CLOCK_REALTIME, &ts);
    return static_cast<uint64_t>(ts.tv_sec) * 1000ULL + static_cast<uint64_t>(ts.tv_nsec / 1000000ULL);
}

static void WriteBlob(const char * dir, const char * tag, const void * data, size_t size) {
    if (!data || size == 0 || size > 64U * 1024U * 1024U)
        return;

    std::lock_guard<std::mutex> guard(g_lock);
    char path[1024];
    std::snprintf(path, sizeof(path), "%s/%s/%llu_%s_%llu.bin",
        RootDir().c_str(),
        dir,
        static_cast<unsigned long long>(NowMs()),
        tag,
        static_cast<unsigned long long>(g_counter.fetch_add(1)));

    FILE * fp = std::fopen(path, "wb");
    if (!fp)
        return;
    std::fwrite(data, 1, size, fp);
    std::fclose(fp);
}

static void WriteText(const char * dir, const char * tag, const char * text, size_t size) {
    if (!text || size == 0 || size > 8U * 1024U * 1024U)
        return;

    std::lock_guard<std::mutex> guard(g_lock);
    char path[1024];
    std::snprintf(path, sizeof(path), "%s/%s/%llu_%s_%llu.txt",
        RootDir().c_str(),
        dir,
        static_cast<unsigned long long>(NowMs()),
        tag,
        static_cast<unsigned long long>(g_counter.fetch_add(1)));

    FILE * fp = std::fopen(path, "wb");
    if (!fp)
        return;
    std::fwrite(text, 1, size, fp);
    std::fclose(fp);
}

static void DumpByteArray(const char * dir, const char * tag, void * arrayObj) {
    auto * array = reinterpret_cast<Il2CppArrayHeader *>(arrayObj);
    if (!array)
        return;
    WriteBlob(dir, tag, array->vector, static_cast<size_t>(array->max_length));
}

static std::string Utf16ToUtf8(const uint16_t * chars, int32_t len) {
    std::string out;
    if (!chars || len <= 0)
        return out;
    out.reserve(static_cast<size_t>(len));
    for (int32_t i = 0; i < len; ++i) {
        uint16_t c = chars[i];
        if (c < 0x80) {
            out.push_back(static_cast<char>(c));
        } else if (c < 0x800) {
            out.push_back(static_cast<char>(0xC0 | (c >> 6)));
            out.push_back(static_cast<char>(0x80 | (c & 0x3F)));
        } else {
            out.push_back(static_cast<char>(0xE0 | (c >> 12)));
            out.push_back(static_cast<char>(0x80 | ((c >> 6) & 0x3F)));
            out.push_back(static_cast<char>(0x80 | (c & 0x3F)));
        }
    }
    return out;
}

static void DumpString(const char * dir, const char * tag, void * stringObj) {
    auto * s = reinterpret_cast<Il2CppStringHeader *>(stringObj);
    if (!s || s->length <= 0 || s->length > 1024 * 1024)
        return;
    std::string utf8 = Utf16ToUtf8(s->chars, s->length);
    WriteText(dir, tag, utf8.data(), utf8.size());
}

static bool ContainsName(const char * imageName, const char * needle) {
    return imageName && std::strstr(imageName, needle) != nullptr;
}

static void FillPointerTable() {
    void * handlers[] = {
        reinterpret_cast<void *>(&xsp_udp_send_payload),
        reinterpret_cast<void *>(&xsp_udp_process_packet),
        reinterpret_cast<void *>(&xsp_config_bytebuf_wrap),
        reinterpret_cast<void *>(&xsp_config_from_string),
    };

    const uint32_t imageCount = _dyld_image_count();
    for (uint32_t i = 0; i < imageCount; ++i) {
        const char * imageName = _dyld_get_image_name(i);
        if (!ContainsName(imageName, "UnityFramework"))
            continue;

        const mach_header_64 * header = reinterpret_cast<const mach_header_64 *>(_dyld_get_image_header(i));
        intptr_t slide = _dyld_get_image_vmaddr_slide(i);
        if (!header || header->magic != MH_MAGIC_64)
            continue;

        const uint8_t * cursor = reinterpret_cast<const uint8_t *>(header) + sizeof(mach_header_64);
        for (uint32_t cmdIndex = 0; cmdIndex < header->ncmds; ++cmdIndex) {
            const load_command * cmd = reinterpret_cast<const load_command *>(cursor);
            if (cmd->cmd == LC_SEGMENT_64) {
                const segment_command_64 * seg = reinterpret_cast<const segment_command_64 *>(cmd);
                const bool writable = (seg->initprot & VM_PROT_WRITE) != 0;
                if (writable && seg->vmsize >= 64) {
                    uint8_t * begin = reinterpret_cast<uint8_t *>(seg->vmaddr + slide);
                    uint8_t * end = begin + seg->vmsize - 40;
                    for (uint8_t * p = begin; p < end; p += 8) {
                        if (std::memcmp(p, "XSPPTRS1", 8) == 0) {
                            void ** slots = reinterpret_cast<void **>(p + 8);
                            for (size_t n = 0; n < sizeof(handlers) / sizeof(handlers[0]); ++n)
                                slots[n] = handlers[n];
                            return;
                        }
                    }
                }
            }
            cursor += cmd->cmdsize;
        }
    }
}

} // namespace

extern "C" __attribute__((visibility("default"))) void xsp_udp_send_payload(void * self, void * payload) {
    (void)self;
    DumpByteArray("udp", "send_payload", payload);
}

extern "C" __attribute__((visibility("default"))) void xsp_udp_process_packet(void * self, void * packet) {
    (void)self;
    DumpByteArray("udp", "process_packet", packet);
}

extern "C" __attribute__((visibility("default"))) void xsp_config_bytebuf_wrap(void * bytes) {
    DumpByteArray("config", "bytebuf_wrap", bytes);
}

extern "C" __attribute__((visibility("default"))) void xsp_config_from_string(void * value) {
    DumpString("config", "from_string", value);
}

extern "C" __attribute__((visibility("default"))) void xsp_dll_blob(const void * data, uint64_t size) {
    WriteBlob("dll", "decrypted_bundle", data, static_cast<size_t>(size));
}

__attribute__((constructor)) static void XueSongProbeCtor() {
    RootDir();
    FillPointerTable();
}

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
#include <signal.h>
#include <stdarg.h>
#include <string>
#include <sys/stat.h>
#include <fcntl.h>
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

std::recursive_mutex g_lock;
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

static void LogLine(const char * fmt, ...) {
    std::lock_guard<std::mutex> guard(g_lock);
    char path[1024];
    std::snprintf(path, sizeof(path), "%s/probe.log", RootDir().c_str());

    FILE * fp = std::fopen(path, "ab");
    if (!fp)
        return;

    std::fprintf(fp, "[%llu] ", static_cast<unsigned long long>(NowMs()));
    va_list ap;
    va_start(ap, fmt);
    std::vfprintf(fp, fmt, ap);
    va_end(ap);
    std::fprintf(fp, "\n");
    std::fclose(fp);
}

static void SignalLog(int sig, siginfo_t * info, void * context) {
    (void)context;
    char path[1024];
    const char * root = g_root.empty() ? "/tmp" : g_root.c_str();
    int n = std::snprintf(path, sizeof(path), "%s/crash_signal.log", root);
    if (n <= 0)
        _exit(128 + sig);

    int fd = ::open(path, O_WRONLY | O_CREAT | O_APPEND, 0600);
    if (fd >= 0) {
        char line[256];
        int len = std::snprintf(line, sizeof(line),
            "signal=%d fault_addr=%p counter=%llu\n",
            sig,
            info ? info->si_addr : nullptr,
            static_cast<unsigned long long>(g_counter.load()));
        if (len > 0)
            ::write(fd, line, static_cast<size_t>(len));
        ::close(fd);
    }

    signal(sig, SIG_DFL);
    raise(sig);
}

static void InstallSignalLogs() {
    struct sigaction sa {};
    sa.sa_sigaction = SignalLog;
    sigemptyset(&sa.sa_mask);
    sa.sa_flags = SA_SIGINFO | SA_RESETHAND;
    sigaction(SIGABRT, &sa, nullptr);
    sigaction(SIGBUS, &sa, nullptr);
    sigaction(SIGILL, &sa, nullptr);
    sigaction(SIGSEGV, &sa, nullptr);
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
    if (!fp) {
        LogLine("WriteBlob failed dir=%s tag=%s size=%llu errno=%d", dir, tag, static_cast<unsigned long long>(size), errno);
        return;
    }
    std::fwrite(data, 1, size, fp);
    std::fclose(fp);
    LogLine("WriteBlob ok dir=%s tag=%s size=%llu", dir, tag, static_cast<unsigned long long>(size));
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
    if (!fp) {
        LogLine("WriteText failed dir=%s tag=%s size=%llu errno=%d", dir, tag, static_cast<unsigned long long>(size), errno);
        return;
    }
    std::fwrite(text, 1, size, fp);
    std::fclose(fp);
    LogLine("WriteText ok dir=%s tag=%s size=%llu", dir, tag, static_cast<unsigned long long>(size));
}

static void DumpByteArray(const char * dir, const char * tag, void * arrayObj) {
    LogLine("DumpByteArray enter dir=%s tag=%s array=%p", dir, tag, arrayObj);
    auto * array = reinterpret_cast<Il2CppArrayHeader *>(arrayObj);
    if (!array)
        return;
    LogLine("DumpByteArray header dir=%s tag=%s len=%llu data=%p", dir, tag, static_cast<unsigned long long>(array->max_length), array->vector);
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
    LogLine("DumpString enter dir=%s tag=%s string=%p", dir, tag, stringObj);
    auto * s = reinterpret_cast<Il2CppStringHeader *>(stringObj);
    if (!s || s->length <= 0 || s->length > 1024 * 1024)
        return;
    LogLine("DumpString header dir=%s tag=%s len=%d chars=%p", dir, tag, s->length, s->chars);
    std::string utf8 = Utf16ToUtf8(s->chars, s->length);
    WriteText(dir, tag, utf8.data(), utf8.size());
}

static bool ContainsName(const char * imageName, const char * needle) {
    return imageName && std::strstr(imageName, needle) != nullptr;
}

static void FillPointerTable() {
    LogLine("FillPointerTable begin");
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
        LogLine("FillPointerTable image=%s", imageName);

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
                            LogLine("FillPointerTable ok table=%p slots=%p", p, slots);
                            return;
                        }
                    }
                }
            }
            cursor += cmd->cmdsize;
        }
    }
    LogLine("FillPointerTable marker not found");
}

} // namespace

extern "C" __attribute__((visibility("default"))) void xsp_udp_send_payload(void * self, void * payload) {
    LogLine("handler xsp_udp_send_payload self=%p payload=%p", self, payload);
    DumpByteArray("udp", "send_payload", payload);
}

extern "C" __attribute__((visibility("default"))) void xsp_udp_process_packet(void * self, void * packet) {
    LogLine("handler xsp_udp_process_packet self=%p packet=%p", self, packet);
    DumpByteArray("udp", "process_packet", packet);
}

extern "C" __attribute__((visibility("default"))) void xsp_config_bytebuf_wrap(void * bytes) {
    LogLine("handler xsp_config_bytebuf_wrap bytes=%p", bytes);
    DumpByteArray("config", "bytebuf_wrap", bytes);
}

extern "C" __attribute__((visibility("default"))) void xsp_config_from_string(void * value) {
    LogLine("handler xsp_config_from_string value=%p", value);
    DumpString("config", "from_string", value);
}

extern "C" __attribute__((visibility("default"))) void xsp_dll_blob(const void * data, uint64_t size) {
    LogLine("handler xsp_dll_blob data=%p size=%llu", data, static_cast<unsigned long long>(size));
    WriteBlob("dll", "decrypted_bundle", data, static_cast<size_t>(size));
}

__attribute__((constructor)) static void XueSongProbeCtor() {
    RootDir();
    InstallSignalLogs();
    LogLine("XueSongProbe ctor begin");
    FillPointerTable();
    LogLine("XueSongProbe ctor end");
}

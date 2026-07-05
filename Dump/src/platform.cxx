#include "../include/platform.hxx"

#include <cerrno>
#include <climits>
#include <codecvt>
#include <locale>
#include <mach/mach.h>
#include <sys/stat.h>
#include <sys/sysctl.h>
#include <unistd.h>

std::string DefaultOutputDir( ) {
    const char * home = std::getenv( "HOME" );
    if ( !home || !*home ) {
        home = std::getenv( "CFFIXED_USER_HOME" );
    }
    if ( !home || !*home )
        return "/var/mobile/Documents/IL2CPP-Dumper";
    return JoinPath( home, "Documents/IL2CPP-Dumper" );
}

std::string JoinPath( const std::string & base, const std::string & leaf ) {
    if ( base.empty( ) )
        return leaf;
    if ( base.back( ) == '/' )
        return base + leaf;
    return base + "/" + leaf;
}

std::string Utf16ToUtf8( const void * chars, int len ) {
    if ( !chars || len <= 0 )
        return "";

    const auto * begin = static_cast< const char16_t * >( chars );
    std::u16string src( begin, begin + len );
    std::wstring_convert<std::codecvt_utf8_utf16<char16_t>, char16_t> conv;
    return conv.to_bytes( src );
}

unsigned int HardwareCpuCount( ) {
    int count = 0;
    size_t len = sizeof( count );
    if ( sysctlbyname( "hw.ncpu", &count, &len, nullptr, 0 ) == 0 && count > 0 )
        return static_cast< unsigned int >( count );
    long fallback = sysconf( _SC_NPROCESSORS_ONLN );
    return fallback > 0 ? static_cast< unsigned int >( fallback ) : 2;
}

unsigned long long HardwareRamGb( ) {
    uint64_t mem = 0;
    size_t len = sizeof( mem );
    if ( sysctlbyname( "hw.memsize", &mem, &len, nullptr, 0 ) != 0 )
        return 4;
    return mem / ( 1024ULL * 1024ULL * 1024ULL );
}

bool MemoryHealthyEnough( ) {
    mach_msg_type_number_t count = HOST_VM_INFO64_COUNT;
    vm_statistics64_data_t vmstat {};
    if ( host_statistics64( mach_host_self( ), HOST_VM_INFO64,
             reinterpret_cast< host_info64_t >( &vmstat ), &count ) != KERN_SUCCESS ) {
        return true;
    }

    vm_size_t pageSize = 0;
    host_page_size( mach_host_self( ), &pageSize );
    const uint64_t available =
        static_cast< uint64_t >( vmstat.free_count + vmstat.inactive_count ) * pageSize;
    return available > ( 256ULL * 1024ULL * 1024ULL );
}

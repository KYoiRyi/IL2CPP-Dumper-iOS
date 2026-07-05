#include "../include/platform.hxx"

#include <cerrno>
#include <climits>
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

    const auto * src = static_cast< const char16_t * >( chars );
    std::string out;
    out.reserve( static_cast< size_t >( len ) * 3 );

    auto appendCodepoint = [ &out ] ( uint32_t cp ) {
        if ( cp <= 0x7F ) {
            out.push_back( static_cast< char >( cp ) );
        }
        else if ( cp <= 0x7FF ) {
            out.push_back( static_cast< char >( 0xC0 | ( cp >> 6 ) ) );
            out.push_back( static_cast< char >( 0x80 | ( cp & 0x3F ) ) );
        }
        else if ( cp <= 0xFFFF ) {
            out.push_back( static_cast< char >( 0xE0 | ( cp >> 12 ) ) );
            out.push_back( static_cast< char >( 0x80 | ( ( cp >> 6 ) & 0x3F ) ) );
            out.push_back( static_cast< char >( 0x80 | ( cp & 0x3F ) ) );
        }
        else {
            out.push_back( static_cast< char >( 0xF0 | ( cp >> 18 ) ) );
            out.push_back( static_cast< char >( 0x80 | ( ( cp >> 12 ) & 0x3F ) ) );
            out.push_back( static_cast< char >( 0x80 | ( ( cp >> 6 ) & 0x3F ) ) );
            out.push_back( static_cast< char >( 0x80 | ( cp & 0x3F ) ) );
        }
    };

    for ( int i = 0; i < len; ++i ) {
        uint32_t cp = src [ i ];
        if ( cp >= 0xD800 && cp <= 0xDBFF && i + 1 < len ) {
            uint32_t low = src [ i + 1 ];
            if ( low >= 0xDC00 && low <= 0xDFFF ) {
                cp = 0x10000 + ( ( cp - 0xD800 ) << 10 ) + ( low - 0xDC00 );
                ++i;
            }
        }
        appendCodepoint( cp );
    }

    return out;
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

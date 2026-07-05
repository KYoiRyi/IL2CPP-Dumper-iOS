#include "../include/dumper.hxx"
#include "../include/il2cpp_api.hxx"
#include "../include/scene_dumper.hxx"
#include "../include/utils.hxx"

#include <cstdlib>
#include <pthread.h>
#include <string>

static void * g_il2cppThread = nullptr;

static bool EnvEnabled( const char * name ) {
    const char * value = std::getenv( name );
    if ( !value )
        return false;
    std::string s = value;
    return s == "1" || s == "true" || s == "TRUE" || s == "yes" || s == "YES";
}

static bool WaitForIl2CppReady( ) {
    constexpr DWORD totalTimeoutMs = 90000;
    constexpr DWORD apiPollMs = 250;
    constexpr DWORD metadataStartDelayMs = 3000;
    constexpr DWORD metadataScanIntervalMs = 1000;
    DWORD start = GetTickCount( );
    DWORD lastMetadataScan = 0;
    bool metadataDumped = false;

    while ( true ) {
        api::init( );
        if ( api::initialized && api::get_domain && api::get_domain( ) ) {
            if ( metadataDumped )
                Log( "[metadata] IL2CPP API became ready after fallback dump; using API dumper" );
            break;
        }

        DWORD now = GetTickCount( );
        if ( !metadataDumped && now - start >= metadataStartDelayMs &&
            ( lastMetadataScan == 0 || now - lastMetadataScan >= metadataScanIntervalMs ) ) {
            lastMetadataScan = now;
            metadataDumped = api::try_dump_metadata_fallback( );
        }

        if ( now - start > totalTimeoutMs ) {
            Log( metadataDumped
                    ? "[error] IL2CPP API was not ready; metadata fallback was dumped"
                    : "[error] IL2CPP runtime was not ready before timeout" );
            return false;
        }
        Sleep( apiPollMs );
    }

    Log( "IL2CPP domain ready, settling for 12s before dumping..." );
    Sleep( 12000 );
    return true;
}

static void AttachIl2CppThread( ) {
    if ( g_il2cppThread || !api::thread_attach || !api::get_domain )
        return;

    void * domain = api::get_domain( );
    if ( !domain )
        return;

    for ( int attempt = 0; attempt < 3 && !g_il2cppThread; ++attempt ) {
        if ( attempt > 0 ) {
            Log( "attach retry " + std::to_string( attempt ) );
            Sleep( 3000 );
        }

        int savedDontGc = -1;
        bool usedBoehmFn = false;
        bool usedIl2cppFn = false;

        if ( api::gc_dont_gc_ptr ) {
            try {
                savedDontGc = *api::gc_dont_gc_ptr;
                *api::gc_dont_gc_ptr = savedDontGc + 1;
            }
            catch ( ... ) {
                savedDontGc = -1;
            }
        }
        if ( savedDontGc < 0 && api::gc_disable_boehm ) {
            try {
                api::gc_disable_boehm( );
                usedBoehmFn = true;
            }
            catch ( ... ) {
                usedBoehmFn = false;
            }
        }
        if ( savedDontGc < 0 && !usedBoehmFn && api::gc_disable ) {
            try {
                api::gc_disable( );
                usedIl2cppFn = true;
            }
            catch ( ... ) {
                usedIl2cppFn = false;
            }
        }

        try {
            g_il2cppThread = api::thread_attach( domain );
        }
        catch ( ... ) {
            g_il2cppThread = nullptr;
        }

        if ( savedDontGc >= 0 && api::gc_dont_gc_ptr )
            *api::gc_dont_gc_ptr = savedDontGc;
        if ( usedBoehmFn && api::gc_enable_boehm )
            api::gc_enable_boehm( );
        if ( usedIl2cppFn && api::gc_enable )
            api::gc_enable( );
    }

    Log( g_il2cppThread ? "thread attached to IL2CPP runtime"
        : "thread attach failed; live scene dumping is unsafe" );
}

static void * EntryPoint( void * ) {
    const char * outputDir = std::getenv( "IL2CPP_DUMPER_OUTPUT" );
    g_outputDir = ( outputDir && *outputDir ) ? outputDir : DefaultOutputDir( );
    EnsureDirectory( g_outputDir );

    Log( "iOS tweak loaded. Waiting for IL2CPP runtime..." );

    if ( WaitForIl2CppReady( ) ) {
        AttachIl2CppThread( );

        {
            Dumper dumper;
            if ( dumper.images.empty( ) ) {
                Log( "no assemblies found" );
            }
            else {
                Log( std::to_string( dumper.images.size( ) ) + " assemblies" );
                dumper.DumpAllToFiles( );
            }
        }

        if ( EnvEnabled( "IL2CPP_DUMPER_SCENE" ) ) {
            SceneDumper::Initialize( );
            if ( SceneDumper::Ready( ) ) {
                if ( EnvEnabled( "IL2CPP_DUMPER_DEEP_SCENE" ) )
                    SceneDumper::SetDeepFieldDump( true );
                SceneDumper::DumpAll( );
            }
        }

        if ( g_il2cppThread && api::thread_detach ) {
            api::thread_detach( g_il2cppThread );
            g_il2cppThread = nullptr;
        }
    }

    Log( "iOS tweak worker finished" );
    return nullptr;
}

__attribute__( ( constructor ) ) static void Il2CppDumperCtor( ) {
    pthread_t thread {};
    if ( pthread_create( &thread, nullptr, EntryPoint, nullptr ) == 0 )
        pthread_detach( thread );
}

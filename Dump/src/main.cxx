#define _CRT_SECURE_NO_WARNINGS

#include "../include/dumper.hxx"
#include "../include/dumper_config.hxx"
#include "../include/il2cpp_api.hxx"
#include "../include/scene_dumper.hxx"
#include "../include/utils.hxx"
#include <cstring>
#include <iostream>
#include <windows.h>

static void * g_il2cppThread = nullptr;
static bool g_gcRegistered = false;

static bool RegisterThreadWithGC( ) {
    if ( g_gcRegistered )
        return true;
    if ( !api::gc_register_my_thread )
        return false;

    ULONG_PTR low = 0, high = 0;
    GetCurrentThreadStackLimits( &low, &high );

    struct GCStackBase {
        void * mem_base;
        void * reg_base;
    } sb;
    sb.mem_base = reinterpret_cast< void * >( high ); // top of stack
    sb.reg_base = nullptr;

    int rc = -1;
    __try {
        rc = api::gc_register_my_thread( &sb );
    }
    __except ( EXCEPTION_EXECUTE_HANDLER ) {
        return false;
    }

    // 0 = GC_SUCCESS, 1 = GC_DUPLICATE
    if ( rc == 0 || rc == 1 ) {
        g_gcRegistered = true;
        Log( "thread registered with GC (rc=" + std::to_string( rc ) + ")" );
        return true;
    }
    Log( "GC_register_my_thread failed, rc=" + std::to_string( rc ) );
    return false;
}

static bool WaitForIl2CppReady( ) {
    const DWORD totalTimeoutMs = 90'000;
    DWORD start = GetTickCount( );

    while ( !GetModuleHandleA( "GameAssembly.dll" ) ) {
        if ( GetTickCount( ) - start > totalTimeoutMs ) {
            Log( "[error] GameAssembly.dll never loaded" );
            return false;
        }
        Sleep( 500 );
    }

    if ( !api::initialized )
        api::init( );
    if ( !api::initialized ) {
        Log( "[error] api init failed" );
        return false;
    }

    while ( !( api::get_domain && api::get_domain( ) ) ) {
        if ( GetTickCount( ) - start > totalTimeoutMs ) {
            Log( "[error] il2cpp_domain_get never returned non-null" );
            return false;
        }
        Sleep( 500 );
    }

    Log( "Domain ready, settling for 12s before touching IL2CPP..." );
    Sleep( 12000 );
    return true;
}

static FILE * Startup( ) {
    AllocConsole( );

    FILE * fDummy = nullptr;
    freopen_s( &fDummy, "CONOUT$", "w", stdout );
    freopen_s( &fDummy, "CONIN$", "r", stdin );

    SetConsoleTitleA( "IL2CPP Dumper - auto" );
    return fDummy;
}

DWORD WINAPI EntryPoint( LPVOID lpParam ) {
    HMODULE hModule = ( HMODULE ) lpParam;
    FILE * output = Startup( );

    Log( "DLL injected. Waiting for IL2CPP runtime..." );

    if ( WaitForIl2CppReady( ) ) {

        if ( !g_il2cppThread && api::thread_attach ) {
            void * domain = api::get_domain ? api::get_domain( ) : nullptr;
            if ( domain ) {
                for ( int attempt = 0; attempt < 3 && !g_il2cppThread; ++attempt ) {
                    if ( attempt > 0 ) {
                        Log( "attach retry " + std::to_string( attempt ) );
                        Sleep( 3000 );
                    }

                    int savedDontGc = -1;
                    bool usedBoehmFn = false;
                    bool usedIl2cppFn = false;

                    if ( api::gc_dont_gc_ptr ) {
                        __try {
                            savedDontGc = *api::gc_dont_gc_ptr;
                            *api::gc_dont_gc_ptr = savedDontGc + 1;
                        }
                        __except ( EXCEPTION_EXECUTE_HANDLER ) {
                            savedDontGc = -1;
                        }
                    }
                    if ( savedDontGc < 0 && api::gc_disable_boehm ) {
                        __try {
                            api::gc_disable_boehm( );
                            usedBoehmFn = true;
                        }
                        __except ( EXCEPTION_EXECUTE_HANDLER ) {
                            usedBoehmFn = false;
                        }
                    }
                    if ( savedDontGc < 0 && !usedBoehmFn && api::gc_disable ) {
                        __try {
                            api::gc_disable( );
                            usedIl2cppFn = true;
                        }
                        __except ( EXCEPTION_EXECUTE_HANDLER ) {
                            usedIl2cppFn = false;
                        }
                    }

                    __try {
                        g_il2cppThread = api::thread_attach( domain );
                    }
                    __except ( EXCEPTION_EXECUTE_HANDLER ) {
                        g_il2cppThread = nullptr;
                    }

                    if ( savedDontGc >= 0 && api::gc_dont_gc_ptr ) {
                        __try {
                            *api::gc_dont_gc_ptr = savedDontGc;
                        }
                        __except ( EXCEPTION_EXECUTE_HANDLER ) {
                        }
                    }
                    if ( usedBoehmFn && api::gc_enable_boehm ) {
                        __try {
                            api::gc_enable_boehm( );
                        }
                        __except ( EXCEPTION_EXECUTE_HANDLER ) {
                        }
                    }
                    if ( usedIl2cppFn && api::gc_enable ) {
                        __try {
                            api::gc_enable( );
                        }
                        __except ( EXCEPTION_EXECUTE_HANDLER ) {
                        }
                    }
                }
            }

            Log( g_il2cppThread ? "thread attached to runtime"
                : "attach failed - scene dump unsafe" );
        }

        if ( !g_il2cppThread ) {
            Log( "running unattached - GC may abort at any moment" );
        }

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

        SceneDumper::Initialize( );

        Log( "" );
        Log( "Hotkeys:" );
        Log( "  F5   full snapshot  (camera + scene + mesh colliders)" );
        Log( "  F7   scene light    (positions + components + materials)" );
        Log( "  F11  scene deep     (with MonoBehaviour field values)" );
        Log( "  F8   camera state" );
        Log( "  F2   mesh colliders (world solidity for AI)" );
        Log( "  F3   targeted class scan (reads IL2CPP_ScanList.txt)" );
        Log( "  F6   exit & unload" );
        Log( "" );

        bool exitRequested = false;
        bool prev [ 16 ] = { false };
        auto edge = [ & ] ( int slot, int vk ) -> bool {
            bool down = ( GetAsyncKeyState( vk ) & 0x8000 ) != 0;
            bool fired = down && !prev [ slot ];
            prev [ slot ] = down;
            return fired;
            };

        while ( !exitRequested ) {
            if ( edge( 0, VK_F5 ) && SceneDumper::Ready( ) ) {
                SceneDumper::SetDeepFieldDump( false );
                SceneDumper::DumpAll( );
            }
            if ( edge( 1, VK_F7 ) && SceneDumper::Ready( ) ) {
                SceneDumper::SetDeepFieldDump( false );
                SceneDumper::Dump( );
            }
            if ( edge( 2, VK_F11 ) && SceneDumper::Ready( ) ) {
                SceneDumper::SetDeepFieldDump( true );
                SceneDumper::Dump( );
                SceneDumper::SetDeepFieldDump( false );
            }
            if ( edge( 3, VK_F8 ) && SceneDumper::Ready( ) )
                SceneDumper::DumpCamera( );
            if ( edge( 4, VK_F2 ) && SceneDumper::Ready( ) )
                SceneDumper::DumpMeshColliders( );
            if ( edge( 5, VK_F3 ) && SceneDumper::Ready( ) )
                SceneDumper::DumpClassesByList( );
            if ( edge( 6, VK_F6 ) )
                exitRequested = true;
            Sleep( 50 );
        }

        if ( g_il2cppThread && api::thread_detach ) {
            api::thread_detach( g_il2cppThread );
            g_il2cppThread = nullptr;
        }
    }

    Log( "unloading..." );

    if ( output )
        fclose( output );
    FreeConsole( );

    FreeLibraryAndExitThread( hModule, 0 );
    return 0;
}

BOOL APIENTRY DllMain( HMODULE hModule, DWORD reason, LPVOID lpReserved ) {
    switch ( reason ) {
    case DLL_PROCESS_ATTACH:
        DisableThreadLibraryCalls( hModule );

        if ( lpReserved ) {
            __try {
                auto * cfg = reinterpret_cast< DumperConfig * >( lpReserved );
                if ( memcmp( cfg->magic, DUMPER_CONFIG_MAGIC, 7 ) == 0 ) {
                    char buf [ sizeof( cfg->outputDir ) + 1 ] = { 0 };
                    memcpy( buf, cfg->outputDir, sizeof( cfg->outputDir ) );
                    buf [ sizeof( cfg->outputDir ) ] = '\0';
                    g_outputDir = buf;
                }
            }
            __except ( EXCEPTION_EXECUTE_HANDLER ) {
                g_outputDir.clear( );
            }
        }

        CreateThread( nullptr, 0, EntryPoint, hModule, 0, nullptr );
        break;
    }
    return TRUE;
}

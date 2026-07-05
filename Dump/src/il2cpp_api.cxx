#include "../include/il2cpp_api.hxx"
#include "../include/utils.hxx"
#include <algorithm>
#include <cstring>
#include <cstdio>
#include <dlfcn.h>
#include <fstream>
#include <mach-o/dyld.h>
#include <mach-o/loader.h>
#include <mach/mach.h>
#include <mach/vm_region.h>
#include <vector>

namespace api {

    bool initialized = false;
    uintptr_t module_base = 0;
    size_t module_size = 0;
    uintptr_t executable_base = 0;
    size_t executable_size = 0;

    // function pointers
    get_domain_t get_domain = nullptr;
    get_assemblies_t get_assemblies = nullptr;
    assembly_get_image_t assembly_get_image = nullptr;
    image_get_name_t image_get_name = nullptr;

    image_get_class_count_t image_get_class_count = nullptr;
    image_get_class_t image_get_class = nullptr;

    class_get_name_t class_get_name = nullptr;
    class_get_namespace_t class_get_namespace = nullptr;
    class_get_flags_t class_get_flags = nullptr;
    class_get_parent_t class_get_parent = nullptr;
    class_is_valuetype_t class_is_valuetype = nullptr;
    class_is_interface_t class_is_interface = nullptr;
    class_get_interfaces_t class_get_interfaces = nullptr;

    class_num_fields_t class_num_fields = nullptr;
    class_get_fields_t class_get_fields = nullptr;
    field_get_name_t field_get_name = nullptr;
    field_get_type_t field_get_type = nullptr;
    field_get_flags_t field_get_flags = nullptr;
    field_get_offset_t field_get_offset = nullptr;

    class_get_methods_t class_get_methods = nullptr;
    method_get_name_t method_get_name = nullptr;
    method_get_flags_t method_get_flags = nullptr;
    method_get_param_count_t method_get_param_count = nullptr;
    method_get_param_t method_get_param = nullptr;
    method_get_param_name_t method_get_param_name = nullptr;
    method_get_return_type_t method_get_return_type = nullptr;
    method_get_pointer_t method_get_pointer = nullptr;

    type_get_name_t type_get_name = nullptr;
    class_get_type_token_t class_get_type_token = nullptr;

    thread_attach_t thread_attach = nullptr;
    thread_detach_t thread_detach = nullptr;

    custom_attrs_from_class_t custom_attrs_from_class = nullptr;
    custom_attrs_from_method_t custom_attrs_from_method = nullptr;
    custom_attrs_from_field_t custom_attrs_from_field = nullptr;
    custom_attrs_free_t custom_attrs_free = nullptr;

    field_get_token_t field_get_token = nullptr;
    field_static_get_value_t field_static_get_value = nullptr;
    field_get_default_value_t field_get_default_value = nullptr;

    method_get_token_t method_get_token = nullptr;
    method_is_generic_t method_is_generic = nullptr;
    method_is_inflated_t method_is_inflated = nullptr;

    class_from_name_t class_from_name = nullptr;
    class_instance_size_t class_instance_size = nullptr;
    class_value_size_t class_value_size = nullptr;

    class_get_properties_t class_get_properties = nullptr;
    class_get_events_t class_get_events = nullptr;
    property_get_name_t property_get_name = nullptr;
    property_get_get_method_t property_get_get_method = nullptr;
    property_get_set_method_t property_get_set_method = nullptr;
    property_get_flags_t property_get_flags = nullptr;
    event_get_name_t event_get_name = nullptr;
    event_get_add_method_t event_get_add_method = nullptr;
    event_get_remove_method_t event_get_remove_method = nullptr;
    event_get_raise_method_t event_get_raise_method = nullptr;

    class_get_nested_types_t class_get_nested_types = nullptr;

    class_get_method_from_name_t class_get_method_from_name = nullptr;
    runtime_invoke_t runtime_invoke = nullptr;
    type_get_object_t type_get_object = nullptr;
    class_get_type_t class_get_type = nullptr;
    array_length_t array_length = nullptr;
    string_length_t string_length_fn = nullptr;
    string_chars_t string_chars = nullptr;
    object_unbox_t object_unbox = nullptr;
    field_get_value_t field_get_value = nullptr;
    class_get_field_from_name_t class_get_field_from_name = nullptr;

    gc_register_my_thread_t gc_register_my_thread = nullptr;
    gc_unregister_my_thread_t gc_unregister_my_thread = nullptr;
    gc_disable_t gc_disable = nullptr;
    gc_enable_t gc_enable = nullptr;
    gc_is_disabled_t gc_is_disabled = nullptr;
    gc_disable_boehm_t gc_disable_boehm = nullptr;
    gc_enable_boehm_t gc_enable_boehm = nullptr;
    int * gc_dont_gc_ptr = nullptr;

    namespace {
        constexpr uint32_t kMetadataMagic = 0xFAB11BAF;
        constexpr size_t kMinMetadataSize = 0x1000;
        constexpr size_t kMaxMetadataDumpSize = 512ULL * 1024ULL * 1024ULL;
        constexpr size_t kScanChunkSize = 256 * 1024;

        bool QueryReadableRegion( uintptr_t address,
            uintptr_t & startOut,
            uintptr_t & endOut ) {
            vm_address_t region = static_cast< vm_address_t >( address );
            vm_size_t regionSize = 0;
            vm_region_basic_info_data_64_t info {};
            mach_msg_type_number_t count = VM_REGION_BASIC_INFO_COUNT_64;
            mach_port_t objectName = MACH_PORT_NULL;

            kern_return_t kr = vm_region_64(
                mach_task_self( ), &region, &regionSize, VM_REGION_BASIC_INFO_64,
                reinterpret_cast< vm_region_info_t >( &info ), &count, &objectName );
            if ( kr != KERN_SUCCESS )
                return false;

            uintptr_t start = static_cast< uintptr_t >( region );
            uintptr_t end = start + static_cast< uintptr_t >( regionSize );
            if ( address < start || address >= end )
                return false;
            if ( ( info.protection & VM_PROT_READ ) == 0 )
                return false;

            startOut = start;
            endOut = end;
            return true;
        }

        bool IsReadableRange( uintptr_t address, size_t size, size_t * regionLeft = nullptr ) {
            if ( !address || !size )
                return false;

            uintptr_t start = 0, end = 0;
            if ( !QueryReadableRegion( address, start, end ) )
                return false;
            if ( size > end - address )
                return false;
            if ( regionLeft )
                *regionLeft = end - address;
            return true;
        }

        bool SafeRead( uintptr_t address, void * out, size_t size ) {
            if ( !out || !size )
                return false;
            vm_size_t copied = 0;
            kern_return_t kr = vm_read_overwrite( mach_task_self( ),
                static_cast< vm_address_t >( address ),
                static_cast< vm_size_t >( size ),
                reinterpret_cast< vm_address_t >( out ),
                &copied );
            return kr == KERN_SUCCESS && copied == size;
        }

        bool SafeReadPtr( uintptr_t address, uintptr_t & out ) {
            out = 0;
            return SafeRead( address, &out, sizeof( out ) );
        }

        bool ReadU32( uintptr_t address, uint32_t & out ) {
            return SafeRead( address, &out, sizeof( out ) );
        }

        bool IsMetadataPointer( uintptr_t ptr ) {
            uint32_t magic = 0;
            return ReadU32( ptr, magic ) && magic == kMetadataMagic;
        }

        size_t EstimateMetadataSize( uintptr_t metadata, size_t regionLeft ) {
            size_t result = 0;
            uint32_t words [ 128 ] = {};
            if ( !SafeRead( metadata, words, sizeof( words ) ) )
                return std::min( regionLeft, kMaxMetadataDumpSize );

            for ( int i = 2; i + 1 < 128; i += 2 ) {
                uint32_t offset = words [ i ];
                uint32_t size = words [ i + 1 ];
                if ( offset < 8 || size == 0 )
                    continue;
                if ( offset > kMaxMetadataDumpSize || size > kMaxMetadataDumpSize )
                    continue;
                result = std::max( result, static_cast< size_t >( offset ) + size );
            }

            if ( result < kMinMetadataSize )
                result = std::min( regionLeft, kMaxMetadataDumpSize );
            return std::min( result, std::min( regionLeft, kMaxMetadataDumpSize ) );
        }

        bool DumpMetadataBuffer( uintptr_t metadata, const std::string & source ) {
            size_t regionLeft = 0;
            if ( !IsReadableRange( metadata, kMinMetadataSize, &regionLeft ) )
                return false;

            size_t dumpSize = EstimateMetadataSize( metadata, regionLeft );
            if ( dumpSize < kMinMetadataSize )
                return false;

            EnsureDirectory( g_outputDir.empty( ) ? DefaultOutputDir( ) : g_outputDir );
            std::string path = JoinPath(
                g_outputDir.empty( ) ? DefaultOutputDir( ) : g_outputDir,
                "global-metadata-dump.dat" );

            std::ofstream out( path, std::ios::binary | std::ios::out | std::ios::trunc );
            if ( !out.is_open( ) ) {
                Log( "[metadata] failed to open " + path );
                return false;
            }

            char buffer [ 16 * 1024 ];
            size_t written = 0;
            while ( written < dumpSize ) {
                size_t todo = std::min( sizeof( buffer ), dumpSize - written );
                if ( !SafeRead( metadata + written, buffer, todo ) )
                    break;
                out.write( buffer, static_cast< std::streamsize >( todo ) );
                written += todo;
            }
            out.close( );

            if ( written < kMinMetadataSize ) {
                Log( "[metadata] failed while reading metadata buffer" );
                return false;
            }

            char buf [ 256 ];
            sprintf_s( buf, "[metadata] dumped %zu bytes from %s -> %s",
                written, source.c_str( ), path.c_str( ) );
            Log( buf );
            return true;
        }

        bool SegmentLooksData( const segment_command_64 * seg ) {
            if ( !seg )
                return false;
            std::string name = seg->segname;
            return name.rfind( "__DATA", 0 ) == 0 || name.rfind( "__AUTH", 0 ) == 0 ||
                name == "__OBJC" || name == "__CONST";
        }

        bool TryDumpRuntimeMetadataFallback( ) {
            static bool dumped = false;
            static bool loggedStart = false;
            if ( dumped )
                return true;

            if ( !loggedStart ) {
                Log( "[metadata] il2cpp exports are hidden; scanning Mach-O data pointers" );
                loggedStart = true;
            }

            for ( uint32_t i = 0; i < _dyld_image_count( ); ++i ) {
                const auto * header = _dyld_get_image_header( i );
                const intptr_t slide = _dyld_get_image_vmaddr_slide( i );
                const char * imageName = _dyld_get_image_name( i );
                if ( !header || header->magic != MH_MAGIC_64 )
                    continue;

                const uint8_t * cmdPtr = reinterpret_cast< const uint8_t * >( header ) +
                    sizeof( mach_header_64 );
                for ( uint32_t c = 0; c < header->ncmds; ++c ) {
                    const auto * cmd = reinterpret_cast< const load_command * >( cmdPtr );
                    if ( cmd->cmd == LC_SEGMENT_64 ) {
                        const auto * seg = reinterpret_cast< const segment_command_64 * >( cmd );
                        if ( SegmentLooksData( seg ) && seg->vmsize >= sizeof( uintptr_t ) ) {
                            uintptr_t segStart = static_cast< uintptr_t >( seg->vmaddr + slide );
                            uintptr_t segEnd = segStart + static_cast< uintptr_t >( seg->vmsize );
                            if ( segEnd <= segStart )
                                continue;

                            uintptr_t pos = segStart;
                            while ( pos < segEnd ) {
                                uintptr_t regionStart = 0, regionEnd = 0;
                                if ( !QueryReadableRegion( pos, regionStart, regionEnd ) ) {
                                    pos += 0x4000;
                                    continue;
                                }

                                uintptr_t scanStart = std::max( pos, regionStart );
                                uintptr_t scanEnd = std::min( segEnd, regionEnd );
                                if ( scanEnd <= scanStart ) {
                                    pos += 0x4000;
                                    continue;
                                }

                                std::vector<uint8_t> chunk( kScanChunkSize );
                                for ( uintptr_t chunkStart = scanStart;
                                    chunkStart + sizeof( uintptr_t ) <= scanEnd;
                                    chunkStart += kScanChunkSize ) {
                                    size_t chunkSize = std::min(
                                        kScanChunkSize, static_cast< size_t >( scanEnd - chunkStart ) );
                                    if ( !SafeRead( chunkStart, chunk.data( ), chunkSize ) )
                                        continue;
                                    for ( size_t off = 0; off + sizeof( uintptr_t ) <= chunkSize;
                                        off += sizeof( uintptr_t ) ) {
                                        uintptr_t candidate = 0;
                                        std::memcpy( &candidate, chunk.data( ) + off,
                                            sizeof( candidate ) );
                                        if ( IsMetadataPointer( candidate ) ) {
                                            std::string source =
                                                std::string( imageName ? imageName : "unknown" ) +
                                                ":" + seg->segname;
                                            if ( DumpMetadataBuffer( candidate, source ) ) {
                                                dumped = true;
                                                return true;
                                            }
                                        }
                                    }
                                }
                                pos = scanEnd;
                            }
                        }
                    }
                    cmdPtr += cmd->cmdsize;
                }
            }

            Log( "[metadata] runtime metadata pointer not found" );
            return false;
        }

        void * ResolveSymbol( void * handle, const char * name ) {
            return dlsym( handle, name );
        }

        bool AddressInRange( uintptr_t addr, uintptr_t base, size_t size ) {
            return addr && base && addr >= base && ( !size || addr < base + size );
        }

        void CaptureExecutableRange( ) {
            uintptr_t minStart = UINTPTR_MAX;
            uintptr_t maxEnd = 0;
            for ( uint32_t i = 0; i < _dyld_image_count( ); ++i ) {
                const auto * header = _dyld_get_image_header( i );
                const intptr_t slide = _dyld_get_image_vmaddr_slide( i );
                if ( !header || header->magic != MH_MAGIC_64 )
                    continue;

                const uint8_t * cmdPtr = reinterpret_cast< const uint8_t * >( header ) +
                    sizeof( mach_header_64 );
                for ( uint32_t c = 0; c < header->ncmds; ++c ) {
                    const auto * cmd = reinterpret_cast< const load_command * >( cmdPtr );
                    if ( cmd->cmd == LC_SEGMENT_64 ) {
                        const auto * seg = reinterpret_cast< const segment_command_64 * >( cmd );
                        if ( ( seg->initprot & VM_PROT_EXECUTE ) != 0 && seg->vmsize ) {
                            uintptr_t start = static_cast< uintptr_t >( seg->vmaddr + slide );
                            uintptr_t end = start + static_cast< uintptr_t >( seg->vmsize );
                            minStart = std::min( minStart, start );
                            maxEnd = std::max( maxEnd, end );
                        }
                    }
                    cmdPtr += cmd->cmdsize;
                }
            }

            if ( minStart != UINTPTR_MAX && maxEnd > minStart ) {
                executable_base = minStart;
                executable_size = maxEnd - minStart;
            }
        }
    }

    bool try_dump_metadata_fallback( ) {
        return TryDumpRuntimeMetadataFallback( );
    }

    bool resolve_method_rva( void * method, uintptr_t & address, uint64_t & rva ) {
        address = 0;
        rva = 0;
        if ( !method )
            return false;

        auto accept = [ & ] ( uintptr_t candidate ) -> bool {
            if ( !candidate )
                return false;
            uintptr_t base = 0;
            if ( AddressInRange( candidate, module_base, module_size ) )
                base = module_base;
            else if ( AddressInRange( candidate, executable_base, executable_size ) )
                base = executable_base;
            else
                return false;

            address = candidate;
            rva = static_cast< uint64_t >( candidate - base );
            return true;
        };

        if ( method_get_pointer ) {
            uintptr_t candidate =
                reinterpret_cast< uintptr_t >( method_get_pointer( method ) );
            if ( accept( candidate ) )
                return true;
        }

        uintptr_t methodAddr = reinterpret_cast< uintptr_t >( method );
        for ( size_t off = 0; off <= sizeof( uintptr_t ) * 3; off += sizeof( uintptr_t ) ) {
            uintptr_t candidate = 0;
            if ( SafeReadPtr( methodAddr + off, candidate ) && accept( candidate ) )
                return true;
        }

        return false;
    }

    void init( ) {
        if ( initialized ) {
            return;
        }

        void * handle = RTLD_DEFAULT;
        void * domainSym = ResolveSymbol( handle, "il2cpp_domain_get" );
        if ( !domainSym ) {
            Log( "[ERROR] il2cpp_domain_get not found in the current process" );
            return;
        }

        CaptureExecutableRange( );

        uintptr_t domainAddr = reinterpret_cast< uintptr_t >( domainSym );
        for ( uint32_t i = 0; i < _dyld_image_count( ); ++i ) {
            const auto * header = _dyld_get_image_header( i );
            const intptr_t slide = _dyld_get_image_vmaddr_slide( i );
            if ( !header )
                continue;

            bool foundImage = false;
            uintptr_t imageBase = 0;
            uintptr_t imageEnd = 0;
            const uint8_t * cmdPtr = reinterpret_cast< const uint8_t * >( header ) +
                sizeof( mach_header_64 );
            for ( uint32_t c = 0; c < header->ncmds; ++c ) {
                const auto * cmd = reinterpret_cast< const load_command * >( cmdPtr );
                if ( cmd->cmd == LC_SEGMENT_64 ) {
                    const auto * seg = reinterpret_cast< const segment_command_64 * >( cmd );
                    uintptr_t start = static_cast< uintptr_t >( seg->vmaddr + slide );
                    uintptr_t end = start + static_cast< uintptr_t >( seg->vmsize );
                    if ( std::strncmp( seg->segname, "__TEXT", 16 ) == 0 )
                        imageBase = start;
                    if ( start <= domainAddr && domainAddr < end )
                        foundImage = true;
                    if ( imageBase )
                        imageEnd = std::max( imageEnd, end );
                }
                cmdPtr += cmd->cmdsize;
            }
            if ( foundImage && imageBase ) {
                module_base = imageBase;
                module_size = imageEnd > module_base ? imageEnd - module_base : 0;
                break;
            }
        }

        // Core functions - fail early if missing
        get_domain = ( get_domain_t ) domainSym;
        get_assemblies =
            ( get_assemblies_t ) dlsym( handle, "il2cpp_domain_get_assemblies" );
        assembly_get_image = ( assembly_get_image_t ) dlsym( handle, "il2cpp_assembly_get_image" );
        image_get_name =
            ( image_get_name_t ) dlsym( handle, "il2cpp_image_get_name" );

        // class / image enumeration
        image_get_class_count = ( image_get_class_count_t ) dlsym( handle, "il2cpp_image_get_class_count" );
        image_get_class =
            ( image_get_class_t ) dlsym( handle, "il2cpp_image_get_class" );

        // class reflection
        class_get_name =
            ( class_get_name_t ) dlsym( handle, "il2cpp_class_get_name" );
        class_get_namespace = ( class_get_namespace_t ) dlsym( handle, "il2cpp_class_get_namespace" );
        class_get_flags =
            ( class_get_flags_t ) dlsym( handle, "il2cpp_class_get_flags" );
        class_get_parent =
            ( class_get_parent_t ) dlsym( handle, "il2cpp_class_get_parent" );

        class_is_valuetype = ( class_is_valuetype_t ) dlsym( handle, "il2cpp_class_is_valuetype" );
        class_is_interface = ( class_is_interface_t ) dlsym( handle, "il2cpp_class_is_interface" );
        class_get_interfaces = ( class_get_interfaces_t ) dlsym( handle, "il2cpp_class_get_interfaces" );

        // fields
        class_num_fields =
            ( class_num_fields_t ) dlsym( handle, "il2cpp_class_num_fields" );
        class_get_fields =
            ( class_get_fields_t ) dlsym( handle, "il2cpp_class_get_fields" );
        field_get_name =
            ( field_get_name_t ) dlsym( handle, "il2cpp_field_get_name" );
        field_get_type =
            ( field_get_type_t ) dlsym( handle, "il2cpp_field_get_type" );
        field_get_flags =
            ( field_get_flags_t ) dlsym( handle, "il2cpp_field_get_flags" );
        field_get_offset =
            ( field_get_offset_t ) dlsym( handle, "il2cpp_field_get_offset" );

        // methods
        class_get_methods =
            ( class_get_methods_t ) dlsym( handle, "il2cpp_class_get_methods" );
        method_get_name =
            ( method_get_name_t ) dlsym( handle, "il2cpp_method_get_name" );
        method_get_flags =
            ( method_get_flags_t ) dlsym( handle, "il2cpp_method_get_flags" );
        method_get_param_count = ( method_get_param_count_t ) dlsym( handle, "il2cpp_method_get_param_count" );
        method_get_param =
            ( method_get_param_t ) dlsym( handle, "il2cpp_method_get_param" );
        method_get_param_name = ( method_get_param_name_t ) dlsym( handle, "il2cpp_method_get_param_name" );
        method_get_return_type = ( method_get_return_type_t ) dlsym( handle, "il2cpp_method_get_return_type" );
        method_get_pointer = ( method_get_pointer_t ) dlsym( handle, "il2cpp_method_get_pointer" );

        type_get_name =
            ( type_get_name_t ) dlsym( handle, "il2cpp_type_get_name" );
        class_get_type_token = ( class_get_type_token_t ) dlsym( handle, "il2cpp_class_get_type_token" );

        thread_attach = nullptr;
        thread_detach = nullptr;

        custom_attrs_from_class = nullptr;
        custom_attrs_from_method = nullptr;
        custom_attrs_from_field = nullptr;
        custom_attrs_free = nullptr;

        field_get_token =
            ( field_get_token_t ) dlsym( handle, "il2cpp_field_get_token" );
        field_static_get_value = nullptr;
        field_get_default_value = nullptr;

        method_get_token =
            ( method_get_token_t ) dlsym( handle, "il2cpp_method_get_token" );
        method_is_generic =
            ( method_is_generic_t ) dlsym( handle, "il2cpp_method_is_generic" );
        method_is_inflated = ( method_is_inflated_t ) dlsym( handle, "il2cpp_method_is_inflated" );

        class_from_name = nullptr;
        class_instance_size = ( class_instance_size_t ) dlsym( handle, "il2cpp_class_instance_size" );
        class_value_size =
            ( class_value_size_t ) dlsym( handle, "il2cpp_class_value_size" );

        class_get_properties = ( class_get_properties_t ) dlsym( handle, "il2cpp_class_get_properties" );
        class_get_events =
            ( class_get_events_t ) dlsym( handle, "il2cpp_class_get_events" );
        class_get_nested_types = ( class_get_nested_types_t ) dlsym( handle, "il2cpp_class_get_nested_types" );

        property_get_name =
            ( property_get_name_t ) dlsym( handle, "il2cpp_property_get_name" );
        property_get_get_method = ( property_get_get_method_t ) dlsym( handle, "il2cpp_property_get_get_method" );
        property_get_set_method = ( property_get_set_method_t ) dlsym( handle, "il2cpp_property_get_set_method" );
        property_get_flags = ( property_get_flags_t ) dlsym( handle, "il2cpp_property_get_flags" );

        event_get_name =
            ( event_get_name_t ) dlsym( handle, "il2cpp_event_get_name" );
        event_get_add_method = ( event_get_add_method_t ) dlsym( handle, "il2cpp_event_get_add_method" );
        event_get_remove_method = ( event_get_remove_method_t ) dlsym( handle, "il2cpp_event_get_remove_method" );
        event_get_raise_method = ( event_get_raise_method_t ) dlsym( handle, "il2cpp_event_get_raise_method" );

        class_get_method_from_name = nullptr;
        runtime_invoke = nullptr;
        type_get_object = nullptr;
        class_get_type = nullptr;
        array_length = nullptr;
        string_length_fn = nullptr;
        string_chars = nullptr;
        object_unbox = nullptr;
        field_get_value = nullptr;
        class_get_field_from_name = nullptr;

        gc_register_my_thread = nullptr;
        gc_unregister_my_thread = nullptr;
        gc_disable = nullptr;
        gc_enable = nullptr;
        gc_is_disabled = nullptr;
        gc_disable_boehm = nullptr;
        gc_enable_boehm = nullptr;
        gc_dont_gc_ptr = nullptr;

        if ( !get_domain || !get_assemblies || !assembly_get_image ||
            !image_get_name ) {
            Log( "[ERROR] Failed to resolve core IL2CPP functions" );
            return;
        }

        initialized = true;

        char buf [ 96 ];
        sprintf_s( buf, "[OK] IL2CPP API ready  base=0x%llX  size=0x%zX",
            ( unsigned long long )module_base, module_size );
        Log( buf );

        char execBuf [ 128 ];
        sprintf_s( execBuf, "[diag] executable range base=0x%llX size=0x%zX method_ptr=%s",
            ( unsigned long long )executable_base, executable_size,
            method_get_pointer ? "yes" : "NO" );
        Log( execBuf );

        char diag [ 640 ];
        sprintf_s(
            diag,
            "[diag] safe_mode=yes gc_register=%s gc_disable=%s gc_enable=%s "
            "GC_disable=%s GC_enable=%s GC_dont_gc=%s "
            "props=%s events=%s field_default=%s method_token=%s "
            "runtime_invoke=%s class_from_name=%s",
            gc_register_my_thread ? "yes" : "NO", gc_disable ? "yes" : "NO",
            gc_enable ? "yes" : "NO", gc_disable_boehm ? "yes" : "NO",
            gc_enable_boehm ? "yes" : "NO", gc_dont_gc_ptr ? "yes" : "NO",
            class_get_properties ? "yes" : "NO", class_get_events ? "yes" : "NO",
            field_get_default_value ? "yes" : "NO", method_get_token ? "yes" : "NO",
            runtime_invoke ? "yes" : "NO", class_from_name ? "yes" : "NO" );
        Log( diag );
    }

} // namespace api

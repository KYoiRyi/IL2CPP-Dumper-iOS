#include "../include/il2cpp_api.hxx"
#include "../include/utils.hxx"
#include <algorithm>
#include <cstring>
#include <cstdio>
#include <dlfcn.h>
#include <fstream>
#include <mach-o/dyld.h>
#include <mach-o/loader.h>
#include <mach/vm_region.h>
#include <mach/mach_vm.h>

namespace api {

    bool initialized = false;
    uintptr_t module_base = 0;
    size_t module_size = 0;

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

        bool IsReadableRange( uintptr_t address, size_t size, size_t * regionLeft = nullptr ) {
            if ( !address || !size )
                return false;

            mach_vm_address_t region = static_cast< mach_vm_address_t >( address );
            mach_vm_size_t regionSize = 0;
            vm_region_basic_info_data_64_t info {};
            mach_msg_type_number_t count = VM_REGION_BASIC_INFO_COUNT_64;
            mach_port_t objectName = MACH_PORT_NULL;

            kern_return_t kr = mach_vm_region(
                mach_task_self( ), &region, &regionSize, VM_REGION_BASIC_INFO_64,
                reinterpret_cast< vm_region_info_t >( &info ), &count, &objectName );
            if ( kr != KERN_SUCCESS )
                return false;

            uintptr_t start = static_cast< uintptr_t >( region );
            uintptr_t end = start + static_cast< uintptr_t >( regionSize );
            if ( address < start || size > end - address )
                return false;
            if ( ( info.protection & VM_PROT_READ ) == 0 )
                return false;

            if ( regionLeft )
                *regionLeft = end - address;
            return true;
        }

        bool ReadU32( uintptr_t address, uint32_t & out ) {
            if ( !IsReadableRange( address, sizeof( out ) ) )
                return false;
            std::memcpy( &out, reinterpret_cast< const void * >( address ), sizeof( out ) );
            return true;
        }

        bool IsMetadataPointer( uintptr_t ptr ) {
            uint32_t magic = 0;
            return ReadU32( ptr, magic ) && magic == kMetadataMagic;
        }

        size_t EstimateMetadataSize( uintptr_t metadata, size_t regionLeft ) {
            size_t result = 0;
            if ( !IsReadableRange( metadata, 512 ) )
                return std::min( regionLeft, kMaxMetadataDumpSize );

            const auto * words = reinterpret_cast< const uint32_t * >( metadata );
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

            out.write( reinterpret_cast< const char * >( metadata ),
                static_cast< std::streamsize >( dumpSize ) );
            out.close( );

            char buf [ 256 ];
            sprintf_s( buf, "[metadata] dumped %zu bytes from %s -> %s",
                dumpSize, source.c_str( ), path.c_str( ) );
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
            static bool attempted = false;
            if ( attempted )
                return false;
            attempted = true;

            Log( "[metadata] il2cpp exports are hidden; scanning Mach-O data pointers" );

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
                            uintptr_t start = static_cast< uintptr_t >( seg->vmaddr + slide );
                            uintptr_t end = start + static_cast< uintptr_t >( seg->vmsize );
                            if ( IsReadableRange( start, sizeof( uintptr_t ) ) ) {
                                for ( uintptr_t p = start; p + sizeof( uintptr_t ) <= end;
                                    p += sizeof( uintptr_t ) ) {
                                    uintptr_t candidate = 0;
                                    std::memcpy( &candidate, reinterpret_cast< const void * >( p ),
                                        sizeof( candidate ) );
                                    if ( IsMetadataPointer( candidate ) ) {
                                        std::string source =
                                            std::string( imageName ? imageName : "unknown" ) +
                                            ":" + seg->segname;
                                        if ( DumpMetadataBuffer( candidate, source ) )
                                            return true;
                                    }
                                }
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
    }

    void init( ) {
        if ( initialized ) {
            return;
        }

        void * handle = RTLD_DEFAULT;
        void * domainSym = ResolveSymbol( handle, "il2cpp_domain_get" );
        if ( !domainSym ) {
            Log( "[ERROR] il2cpp_domain_get not found in the current process" );
            TryDumpRuntimeMetadataFallback( );
            return;
        }

        for ( uint32_t i = 0; i < _dyld_image_count( ); ++i ) {
            const auto * header = _dyld_get_image_header( i );
            const intptr_t slide = _dyld_get_image_vmaddr_slide( i );
            if ( !header )
                continue;

            uintptr_t imageBase = reinterpret_cast< uintptr_t >( header );
            uintptr_t imageEnd = imageBase;
            const uint8_t * cmdPtr = reinterpret_cast< const uint8_t * >( header ) +
                sizeof( mach_header_64 );
            for ( uint32_t c = 0; c < header->ncmds; ++c ) {
                const auto * cmd = reinterpret_cast< const load_command * >( cmdPtr );
                if ( cmd->cmd == LC_SEGMENT_64 ) {
                    const auto * seg = reinterpret_cast< const segment_command_64 * >( cmd );
                    uintptr_t start = static_cast< uintptr_t >( seg->vmaddr + slide );
                    uintptr_t end = start + static_cast< uintptr_t >( seg->vmsize );
                    if ( start <= reinterpret_cast< uintptr_t >( domainSym ) &&
                        reinterpret_cast< uintptr_t >( domainSym ) < end ) {
                        module_base = imageBase;
                    }
                    if ( module_base )
                        imageEnd = std::max( imageEnd, end );
                }
                cmdPtr += cmd->cmdsize;
            }
            if ( module_base ) {
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

        thread_attach =
            ( thread_attach_t ) dlsym( handle, "il2cpp_thread_attach" );
        thread_detach =
            ( thread_detach_t ) dlsym( handle, "il2cpp_thread_detach" );

        custom_attrs_from_class = ( custom_attrs_from_class_t ) dlsym( handle, "il2cpp_custom_attrs_from_class" );
        custom_attrs_from_method = ( custom_attrs_from_method_t ) dlsym( handle, "il2cpp_custom_attrs_from_method" );
        custom_attrs_from_field = ( custom_attrs_from_field_t ) dlsym( handle, "il2cpp_custom_attrs_from_field" );
        custom_attrs_free =
            ( custom_attrs_free_t ) dlsym( handle, "il2cpp_custom_attrs_free" );

        field_get_token =
            ( field_get_token_t ) dlsym( handle, "il2cpp_field_get_token" );
        field_static_get_value = ( field_static_get_value_t ) dlsym( handle, "il2cpp_field_static_get_value" );
        field_get_default_value = ( field_get_default_value_t ) dlsym( handle, "il2cpp_field_get_default_value" );

        method_get_token =
            ( method_get_token_t ) dlsym( handle, "il2cpp_method_get_token" );
        method_is_generic =
            ( method_is_generic_t ) dlsym( handle, "il2cpp_method_is_generic" );
        method_is_inflated = ( method_is_inflated_t ) dlsym( handle, "il2cpp_method_is_inflated" );

        class_from_name =
            ( class_from_name_t ) dlsym( handle, "il2cpp_class_from_name" );
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

        // Runtime invocation suite (for live scene dumper)
        class_get_method_from_name = ( class_get_method_from_name_t ) dlsym( handle, "il2cpp_class_get_method_from_name" );
        runtime_invoke =
            ( runtime_invoke_t ) dlsym( handle, "il2cpp_runtime_invoke" );
        type_get_object =
            ( type_get_object_t ) dlsym( handle, "il2cpp_type_get_object" );
        class_get_type =
            ( class_get_type_t ) dlsym( handle, "il2cpp_class_get_type" );
        array_length = ( array_length_t ) dlsym( handle, "il2cpp_array_length" );
        string_length_fn =
            ( string_length_t ) dlsym( handle, "il2cpp_string_length" );
        string_chars = ( string_chars_t ) dlsym( handle, "il2cpp_string_chars" );
        object_unbox = ( object_unbox_t ) dlsym( handle, "il2cpp_object_unbox" );
        field_get_value =
            ( field_get_value_t ) dlsym( handle, "il2cpp_field_get_value" );
        class_get_field_from_name = ( class_get_field_from_name_t ) dlsym( handle, "il2cpp_class_get_field_from_name" );

        gc_register_my_thread =
            ( gc_register_my_thread_t ) dlsym( handle, "GC_register_my_thread" );
        gc_unregister_my_thread = ( gc_unregister_my_thread_t ) dlsym( handle, "GC_unregister_my_thread" );
        gc_disable = ( gc_disable_t ) dlsym( handle, "il2cpp_gc_disable" );
        gc_enable = ( gc_enable_t ) dlsym( handle, "il2cpp_gc_enable" );
        gc_is_disabled =
            ( gc_is_disabled_t ) dlsym( handle, "il2cpp_gc_is_disabled" );
        gc_disable_boehm = ( gc_disable_boehm_t ) dlsym( handle, "GC_disable" );
        gc_enable_boehm = ( gc_enable_boehm_t ) dlsym( handle, "GC_enable" );
        gc_dont_gc_ptr = ( int * ) dlsym( handle, "GC_dont_gc" );

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

        char diag [ 640 ];
        sprintf_s(
            diag,
            "[diag] gc_register=%s gc_disable=%s gc_enable=%s "
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

#include "../include/metadata_dumper.hxx"
#include "../include/platform.hxx"
#include "../include/utils.hxx"

#include <algorithm>
#include <cctype>
#include <cstring>
#include <fstream>
#include <iterator>
#include <sstream>
#include <unordered_set>
#include <vector>

namespace {

#pragma pack(push, 1)
    struct MetadataHeader {
        uint32_t sanity;
        int32_t version;
        uint32_t stringLiteralOffset;
        uint32_t stringLiteralCount;
        uint32_t stringLiteralDataOffset;
        uint32_t stringLiteralDataCount;
        uint32_t stringOffset;
        uint32_t stringCount;
        uint32_t eventsOffset;
        uint32_t eventsCount;
        uint32_t propertiesOffset;
        uint32_t propertiesCount;
        uint32_t methodsOffset;
        uint32_t methodsCount;
        uint32_t parameterDefaultValuesOffset;
        uint32_t parameterDefaultValuesCount;
        uint32_t fieldDefaultValuesOffset;
        uint32_t fieldDefaultValuesCount;
        uint32_t fieldAndParameterDefaultValueDataOffset;
        uint32_t fieldAndParameterDefaultValueDataCount;
        uint32_t fieldMarshaledSizesOffset;
        uint32_t fieldMarshaledSizesCount;
        uint32_t parametersOffset;
        uint32_t parametersCount;
        uint32_t fieldsOffset;
        uint32_t fieldsCount;
        uint32_t genericParametersOffset;
        uint32_t genericParametersCount;
        uint32_t genericParameterConstraintsOffset;
        uint32_t genericParameterConstraintsCount;
        uint32_t genericContainersOffset;
        uint32_t genericContainersCount;
        uint32_t nestedTypesOffset;
        uint32_t nestedTypesCount;
        uint32_t interfacesOffset;
        uint32_t interfacesCount;
        uint32_t vtableMethodsOffset;
        uint32_t vtableMethodsCount;
        uint32_t interfaceOffsetsOffset;
        uint32_t interfaceOffsetsCount;
        uint32_t typeDefinitionsOffset;
        uint32_t typeDefinitionsCount;
        uint32_t rgctxEntriesOffset;
        uint32_t rgctxEntriesCount;
        uint32_t imagesOffset;
        uint32_t imagesCount;
        uint32_t assembliesOffset;
        uint32_t assembliesCount;
    };

    struct ImageDefinition {
        int32_t nameIndex;
        int32_t assemblyIndex;
        int32_t typeStart;
        uint32_t typeCount;
        int32_t exportedTypeStart;
        uint32_t exportedTypeCount;
        int32_t entryPointIndex;
        uint32_t token;
        int32_t customAttributeStart;
        uint32_t customAttributeCount;
    };

    struct TypeDefinition {
        int32_t nameIndex;
        int32_t namespaceIndex;
        int32_t byvalTypeIndex;
        int32_t byrefTypeIndex;
        int32_t declaringTypeIndex;
        int32_t parentIndex;
        int32_t elementTypeIndex;
        int32_t rgctxStartIndex;
        int32_t rgctxCount;
        int32_t genericContainerIndex;
        uint32_t flags;
        int32_t fieldStart;
        int32_t methodStart;
        int32_t eventStart;
        int32_t propertyStart;
        int32_t nestedTypesStart;
        int32_t interfacesStart;
        int32_t vtableStart;
        int32_t interfaceOffsetsStart;
        uint16_t methodCount;
        uint16_t propertyCount;
        uint16_t fieldCount;
        uint16_t eventCount;
        uint16_t nestedTypeCount;
        uint16_t vtableCount;
        uint16_t interfacesCount;
        uint16_t interfaceOffsetsCount;
        uint32_t bitfield;
        uint32_t token;
    };

    struct FieldDefinition {
        int32_t nameIndex;
        int32_t typeIndex;
        int32_t customAttributeIndex;
        uint32_t token;
    };

    struct MethodDefinition {
        int32_t nameIndex;
        int32_t declaringType;
        int32_t returnType;
        int32_t parameterStart;
        int32_t genericContainerIndex;
        uint32_t token;
        uint16_t flags;
        uint16_t iflags;
        uint16_t slot;
        uint16_t parameterCount;
    };

    struct ParameterDefinition {
        int32_t nameIndex;
        uint32_t token;
        int32_t customAttributeIndex;
        int32_t typeIndex;
    };
#pragma pack(pop)

    constexpr uint32_t kMetadataMagic = 0xFAB11BAF;
    constexpr uint32_t kTypeAttrInterface = 0x00000020;
    constexpr uint32_t kTypeAttrAbstract = 0x00000080;
    constexpr uint32_t kTypeAttrSealed = 0x00000100;
    template <typename T>
    bool ReadTable( const std::vector<uint8_t> & data, uint32_t offset, uint32_t bytes,
        std::vector<T> & out ) {
        out.clear( );
        if ( !bytes )
            return true;
        if ( offset > data.size( ) || bytes > data.size( ) - offset )
            return false;
        size_t count = bytes / sizeof( T );
        if ( count == 0 )
            return true;
        out.resize( count );
        std::memcpy( out.data( ), data.data( ) + offset, count * sizeof( T ) );
        return true;
    }

    std::string ReadString( const std::vector<uint8_t> & data, const MetadataHeader & h,
        int32_t index ) {
        if ( index < 0 )
            return "";
        uint32_t start = h.stringOffset + static_cast<uint32_t>( index );
        if ( start >= data.size( ) || start < h.stringOffset )
            return "";

        uint32_t stringsEnd = std::min<uint32_t>(
            static_cast<uint32_t>( data.size( ) ), h.stringOffset + h.stringCount );
        if ( start >= stringsEnd )
            return "";

        std::string s;
        for ( uint32_t i = start; i < stringsEnd && data [ i ]; ++i ) {
            unsigned char c = data [ i ];
            if ( c >= 0x20 )
                s.push_back( static_cast<char>( c ) );
        }
        return s;
    }

    std::string SafeIdentifier( const std::string & raw, const std::string & fallback ) {
        std::string s = raw.empty( ) ? fallback : raw;
        for ( char & c : s ) {
            unsigned char uc = static_cast<unsigned char>( c );
            if ( !( std::isalnum( uc ) || c == '_' ) )
                c = '_';
        }
        if ( s.empty( ) )
            s = fallback;
        if ( std::isdigit( static_cast<unsigned char>( s [ 0 ] ) ) )
            s.insert( s.begin( ), '_' );

        static const std::unordered_set<std::string> keywords = {
            "class", "struct", "interface", "namespace", "public", "private",
            "protected", "internal", "event", "operator", "params", "ref", "out",
            "in", "base", "this", "void", "string", "int", "float", "double",
            "bool", "object", "new", "return", "static", "readonly", "sealed",
            "abstract", "virtual", "override", "default", "switch", "case" };
        if ( keywords.count( s ) )
            s += "_";
        return s;
    }

    std::string SafeNamespace( const std::string & raw ) {
        std::string out;
        std::string part;
        for ( char c : raw ) {
            if ( c == '.' ) {
                if ( !part.empty( ) ) {
                    if ( !out.empty( ) )
                        out += ".";
                    out += SafeIdentifier( part, "Namespace" );
                    part.clear( );
                }
            }
            else {
                part += c;
            }
        }
        if ( !part.empty( ) ) {
            if ( !out.empty( ) )
                out += ".";
            out += SafeIdentifier( part, "Namespace" );
        }
        return out;
    }

    std::string TypeKeyword( const TypeDefinition & t ) {
        if ( t.flags & kTypeAttrInterface )
            return "interface";
        return "class";
    }

    std::string TypeModifiers( const TypeDefinition & t ) {
        if ( t.flags & kTypeAttrInterface )
            return "";
        bool isAbstract = ( t.flags & kTypeAttrAbstract ) != 0;
        bool isSealed = ( t.flags & kTypeAttrSealed ) != 0;
        if ( isAbstract && isSealed )
            return "static ";
        if ( isAbstract )
            return "abstract ";
        if ( isSealed )
            return "sealed ";
        return "";
    }

    void WriteType( std::ofstream & out, const std::vector<uint8_t> & data,
        const MetadataHeader & h, const TypeDefinition & t,
        const std::vector<FieldDefinition> & fields,
        const std::vector<MethodDefinition> & methods,
        const std::vector<ParameterDefinition> & params ) {
        std::string name = SafeIdentifier( ReadString( data, h, t.nameIndex ), "Type" );
        out << "    // TypeToken: 0x" << std::hex << std::uppercase << t.token
            << std::dec << "\n";
        out << "    public " << TypeModifiers( t ) << TypeKeyword( t ) << " "
            << name << "\n    {\n";

        if ( t.fieldCount ) {
            out << "        // Fields\n";
            for ( uint16_t i = 0; i < t.fieldCount; ++i ) {
                int32_t idx = t.fieldStart + i;
                if ( idx < 0 || static_cast<size_t>( idx ) >= fields.size( ) )
                    continue;
                const FieldDefinition & f = fields [ idx ];
                std::string fname = SafeIdentifier(
                    ReadString( data, h, f.nameIndex ), "field_" + std::to_string( i ) );
                out << "        public ";
                out << ( ( f.typeIndex >= 0 ) ? "object" : "object" ) << " " << fname
                    << ";";
                out << " // token: 0x" << std::hex << std::uppercase << f.token
                    << std::dec << "\n";
            }
            out << "\n";
        }

        if ( t.methodCount ) {
            out << "        // Methods\n";
            for ( uint16_t i = 0; i < t.methodCount; ++i ) {
                int32_t idx = t.methodStart + i;
                if ( idx < 0 || static_cast<size_t>( idx ) >= methods.size( ) )
                    continue;
                const MethodDefinition & m = methods [ idx ];
                std::string mname = SafeIdentifier(
                    ReadString( data, h, m.nameIndex ), "method_" + std::to_string( i ) );
                out << "        public object " << mname << "(";
                for ( uint16_t p = 0; p < m.parameterCount; ++p ) {
                    int32_t pidx = m.parameterStart + p;
                    if ( p > 0 )
                        out << ", ";
                    std::string pname = "arg" + std::to_string( p );
                    if ( pidx >= 0 && static_cast<size_t>( pidx ) < params.size( ) ) {
                        std::string raw = ReadString( data, h, params [ pidx ].nameIndex );
                        pname = SafeIdentifier( raw, pname );
                    }
                    out << "object " << pname;
                }
                out << ") { }";
                out << " // token: 0x" << std::hex << std::uppercase << m.token
                    << std::dec << "\n";
            }
        }

        out << "    }\n\n";
    }

} // namespace

bool DumpMetadataCsFromFile( const std::string & metadataPath,
    const std::string & outputBaseDir ) {
    std::ifstream in( metadataPath, std::ios::binary );
    if ( !in.is_open( ) ) {
        Log( "[metadata-cs] failed to open " + metadataPath );
        return false;
    }

    std::vector<uint8_t> data(
        ( std::istreambuf_iterator<char>( in ) ), std::istreambuf_iterator<char>( ) );
    if ( data.size( ) < sizeof( MetadataHeader ) ) {
        Log( "[metadata-cs] metadata file is too small" );
        return false;
    }

    MetadataHeader h {};
    std::memcpy( &h, data.data( ), sizeof( h ) );
    if ( h.sanity != kMetadataMagic ) {
        Log( "[metadata-cs] metadata magic mismatch" );
        return false;
    }

    std::vector<ImageDefinition> images;
    std::vector<TypeDefinition> types;
    std::vector<FieldDefinition> fields;
    std::vector<MethodDefinition> methods;
    std::vector<ParameterDefinition> params;
    if ( !ReadTable( data, h.imagesOffset, h.imagesCount, images ) ||
        !ReadTable( data, h.typeDefinitionsOffset, h.typeDefinitionsCount, types ) ||
        !ReadTable( data, h.fieldsOffset, h.fieldsCount, fields ) ||
        !ReadTable( data, h.methodsOffset, h.methodsCount, methods ) ||
        !ReadTable( data, h.parametersOffset, h.parametersCount, params ) ) {
        Log( "[metadata-cs] metadata table bounds failed" );
        return false;
    }

    std::string dir = JoinPath( outputBaseDir, "IL2CPP_Metadata_Fallback" );
    EnsureDirectory( dir );
    std::string path = JoinPath( dir, "dump.cs" );
    std::ofstream out( path, std::ios::out | std::ios::trunc );
    if ( !out.is_open( ) ) {
        Log( "[metadata-cs] failed to create " + path );
        return false;
    }

    out << "// ========================================================\n";
    out << "// Metadata-only IL2CPP dump\n";
    out << "// Source: " << metadataPath << "\n";
    out << "// Version: " << h.version << "\n";
    out << "// Note: API was unavailable; RVA, field offsets and exact types may be missing.\n";
    out << "// ========================================================\n\n";
    out << "using System;\n\n";

    size_t writtenTypes = 0;
    for ( const auto & img : images ) {
        std::string imageName = ReadString( data, h, img.nameIndex );
        out << "// Image: " << imageName << "\n";
        for ( uint32_t i = 0; i < img.typeCount; ++i ) {
            int32_t typeIndex = img.typeStart + static_cast<int32_t>( i );
            if ( typeIndex < 0 || static_cast<size_t>( typeIndex ) >= types.size( ) )
                continue;
            const TypeDefinition & t = types [ typeIndex ];
            std::string ns = SafeNamespace( ReadString( data, h, t.namespaceIndex ) );
            if ( !ns.empty( ) )
                out << "namespace " << ns << "\n{\n\n";
            WriteType( out, data, h, t, fields, methods, params );
            if ( !ns.empty( ) )
                out << "}\n\n";
            ++writtenTypes;
        }
    }

    out.close( );
    Log( "[metadata-cs] wrote fallback C# dump: " + path );
    Log( "[metadata-cs] types: " + std::to_string( writtenTypes ) );
    return writtenTypes > 0;
}

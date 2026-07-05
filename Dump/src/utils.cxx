#include "../include/utils.hxx"
#include <fstream>
#include <iostream>
#include <sys/stat.h>

std::string g_outputDir;

std::size_t g_rvaTotal = 0;
std::size_t g_rvaResolved = 0;

static std::string BaseDir( ) {
    return g_outputDir.empty( ) ? DefaultOutputDir( ) : g_outputDir;
}

std::string GetDumpDirNormal( ) { return JoinPath( BaseDir( ), "IL2CPP_Dump_Normal" ); }
std::string GetDumpDirAi( ) { return JoinPath( BaseDir( ), "IL2CPP_Dump_AI" ); }

static std::ofstream & GetLogFile( ) {
    static std::ofstream logFile;
    static bool opened = false;

    if ( !opened ) {
        EnsureDirectory( BaseDir( ) );
        std::string path = JoinPath( BaseDir( ), "IL2CPPDump_Log.txt" );
        logFile.open( path, std::ios::out | std::ios::trunc );
        opened = true;
    }
    return logFile;
}

void Log( const std::string & msg ) {
    std::cout << msg << "\n";

    auto & lf = GetLogFile( );
    if ( lf.is_open( ) ) {
        lf << msg << "\n";
        lf.flush( );
    }
}

void EnsureDirectory( const std::string & path ) { mkdir( path.c_str( ), 0755 ); }

std::string GetAccessModifier( uint32_t flags ) {
    uint32_t access = flags & 0x0007;

    switch ( access ) {
    case 0x0006:
        return "public";
    case 0x0001:
        return "private";
    case 0x0004:
        return "protected";
    case 0x0005:
        return "protected internal";
    default:
        return "private";
    }
}

#pragma once

#include <chrono>
#include <cerrno>
#include <cstdio>
#include <cstdlib>
#include <ctime>
#include <string>
#include <thread>

#ifndef __fastcall
#define __fastcall
#endif

#ifndef __cdecl
#define __cdecl
#endif

#ifndef sprintf_s
#define sprintf_s(buffer, ...) std::snprintf( buffer, sizeof( buffer ), __VA_ARGS__ )
#endif

using DWORD = unsigned long;

struct SYSTEMTIME {
    unsigned short wYear;
    unsigned short wMonth;
    unsigned short wDayOfWeek;
    unsigned short wDay;
    unsigned short wHour;
    unsigned short wMinute;
    unsigned short wSecond;
    unsigned short wMilliseconds;
};

inline void Sleep( DWORD ms ) {
    std::this_thread::sleep_for( std::chrono::milliseconds( ms ) );
}

inline DWORD GetTickCount( ) {
    using namespace std::chrono;
    return static_cast< DWORD >(
        duration_cast< milliseconds >( steady_clock::now( ).time_since_epoch( ) ).count( ) );
}

inline void GetLocalTime( SYSTEMTIME * out ) {
    if ( !out )
        return;

    std::time_t now = std::time( nullptr );
    std::tm tm {};
    localtime_r( &now, &tm );

    out->wYear = static_cast< unsigned short >( tm.tm_year + 1900 );
    out->wMonth = static_cast< unsigned short >( tm.tm_mon + 1 );
    out->wDayOfWeek = static_cast< unsigned short >( tm.tm_wday );
    out->wDay = static_cast< unsigned short >( tm.tm_mday );
    out->wHour = static_cast< unsigned short >( tm.tm_hour );
    out->wMinute = static_cast< unsigned short >( tm.tm_min );
    out->wSecond = static_cast< unsigned short >( tm.tm_sec );
    out->wMilliseconds = 0;
}

inline int fopen_s( FILE ** file, const char * path, const char * mode ) {
    if ( !file )
        return EINVAL;
    *file = std::fopen( path, mode );
    return *file ? 0 : errno;
}

std::string DefaultOutputDir( );
std::string JoinPath( const std::string & base, const std::string & leaf );
std::string Utf16ToUtf8( const void * chars, int len );
unsigned int HardwareCpuCount( );
unsigned long long HardwareRamGb( );
bool MemoryHealthyEnough( );

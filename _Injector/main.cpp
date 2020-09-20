#include <windows.h>
#include <TlHelp32.h>
#include <cstdio>
#include <time.h>
#include <string>

std::string CacheLibrary( VOID ) {

    srand( time( NULL ) );

    auto randname = []( const int len = 10 ) -> std::string {

        static const char alphanum[] =
            "0123456789ab"
            "cdefghijklmn"
            "opqrstuvwxyz";

        auto s = (PCHAR)malloc( len * sizeof( PCHAR ) );
        s[len] = 0x00;

        for ( int i = 0; i < len; ++i ) {
            s[i] = alphanum[rand() % (sizeof( alphanum ) - 1)];
        }
        return std::string( "C:\\Windows\\EasySharp\\Debug\\Cache\\" ) + std::string( s ) + std::string( ".dll" );
    };

    auto lib = randname();
    rename( "C:\\Windows\\EasySharp\\Debug\\EasySharp.dll", lib.c_str() );
    return lib;
}

DWORD GetProcessId( LPCWSTR ProcessName ) {

    auto p32 = PROCESSENTRY32{ sizeof( PROCESSENTRY32 ) };
    auto t32 = CreateToolhelp32Snapshot( TH32CS_SNAPPROCESS, NULL );

    if ( Process32First( t32, &p32 ) == TRUE )
    {
        while ( Process32Next( t32, &p32 ) == TRUE )
        {
            if ( !wcscmp( p32.szExeFile, ProcessName ) ) {

                return p32.th32ProcessID;
            }
        }
    }

    return NULL;
}

BOOL InjectLib( DWORD ProcessId ) {

    auto _LibName = CacheLibrary();
    auto LibName = _LibName.c_str();

    if ( auto hProcess = OpenProcess( PROCESS_ALL_ACCESS, FALSE, ProcessId ) ) {

        if ( auto pAddr = VirtualAllocEx( hProcess, NULL, strlen( LibName ) + 1, MEM_COMMIT, PAGE_EXECUTE_READWRITE ) ) {

            if ( WriteProcessMemory( hProcess, pAddr, LibName, strlen( LibName ) + 1, NULL ) ) {

                auto pLoadLibraryAddr = GetProcAddress( LoadLibrary( L"kernel32" ), "LoadLibraryA" );

                if ( auto hThread = CreateRemoteThread( hProcess, NULL, NULL, (LPTHREAD_START_ROUTINE)pLoadLibraryAddr, pAddr, NULL, NULL ) ) {

                    DWORD hInjectedLib;

                    if ( !WaitForSingleObject( hThread, INFINITE ) && GetExitCodeThread( hThread, &hInjectedLib ) ) {

                        auto hLib = LoadLibraryA( LibName );
                        auto hEntry = GetProcAddress( hLib, "Entry" );
                        auto offset = hInjectedLib + reinterpret_cast<DWORD>(hEntry) - reinterpret_cast<DWORD>(hLib);

                        hThread = CreateRemoteThread( hProcess, NULL, NULL, (LPTHREAD_START_ROUTINE)offset, NULL, NULL, NULL );

                        return TRUE;
                    }
                }
            }
        }
    }
    return FALSE;
}

int main( void ) {

    InjectLib( GetProcessId( L"csgo.exe" ) );
    return 0;
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Injector
{
    [DllImport( "kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true )]
    static extern IntPtr GetProcAddress( IntPtr hModule, string procName );

    [DllImport( "kernel32", SetLastError = true, CharSet = CharSet.Ansi )]
    static extern IntPtr LoadLibrary( [MarshalAs( UnmanagedType.LPStr )]string lpFileName );

    [DllImport( "kernel32.dll", SetLastError = true, ExactSpelling = true )]
    static extern IntPtr VirtualAllocEx( IntPtr hProcess, IntPtr lpAddress,
    int dwSize, AllocationType flAllocationType, MemoryProtection flProtect );

    [DllImport( "kernel32.dll", SetLastError = true )]
    static extern int WriteProcessMemory(
        IntPtr hProcess,
        IntPtr lpBaseAddress,
        byte[] lpBuffer,
        int nSize,
        out IntPtr lpNumberOfBytesWritten );

    [DllImport( "kernel32.dll", SetLastError = true )]
    static extern bool ReadProcessMemory(
        IntPtr hProcess,
        IntPtr lpBaseAddress,
        [Out] byte[] lpBuffer,
        int dwSize,
        out IntPtr lpNumberOfBytesRead );


    [DllImport( "kernel32.dll", SetLastError = true )]
    static extern uint WaitForSingleObject( IntPtr hHandle, int dwMilliseconds );

    [DllImport( "kernel32.dll" )]
    static extern int GetExitCodeThread( IntPtr hThread, out uint lpExitCode );

    [DllImport( "kernel32.dll" )]
    static extern IntPtr CreateRemoteThread( IntPtr hProcess,
        int lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress,
        IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId );

    [Flags]
    public enum AllocationType
    {
        Commit     = 0x1000,
        Reserve    = 0x2000,
        Decommit   = 0x4000,
        Release    = 0x8000,
        Reset      = 0x80000,
        Physical   = 0x400000,
        TopDown    = 0x100000,
        WriteWatch = 0x200000,
        LargePages = 0x20000000
    }

    [Flags]
    public enum MemoryProtection
    {
        Execute                  = 0x10,
        ExecuteRead              = 0x20,
        ExecuteReadWrite         = 0x40,
        ExecuteWriteCopy         = 0x80,
        NoAccess                 = 0x01,
        ReadOnly                 = 0x02,
        ReadWrite                = 0x04,
        WriteCopy                = 0x08,
        GuardModifierflag        = 0x100,
        NoCacheModifierflag      = 0x200,
        WriteCombineModifierflag = 0x400
    }

    public static void CleanCache()
    {
        foreach (var file in Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Cache\\").Where(x => x.EndsWith(".dll")))
        {
            try
            {
                File.Delete(file);
            }
            catch { }
        }
    }

    public static bool Inject( string ProcessName, string LibName, string EntryPoint )
    {
        var CurrDir = Directory.GetCurrentDirectory();
        var RandLib = CurrDir + "\\Cache\\" + DateTime.Now.Ticks + ".dll";

        if ( !Directory.Exists("Cache") )
            Directory.CreateDirectory("Cache");

        var PathLib = Path.GetFullPath( LibName );

        if ( !PathLib.Contains( "C:\\Windows\\" ) )
        {
            Console.WriteLine( "Injector and EasySharp.dll have to be in subfolder of C:\\Windows\\" );
            Console.ReadLine();
            Environment.Exit( 0 );
        }

        File.Copy( PathLib, RandLib );

        var process = Process.GetProcessesByName(ProcessName).FirstOrDefault();
        var byLibName = Encoding.UTF8.GetBytes( RandLib );

        var hMemory = VirtualAllocEx( process.Handle, IntPtr.Zero, byLibName.Length, AllocationType.Commit, MemoryProtection.ReadWrite );

        if ( hMemory == IntPtr.Zero )
            return false;

        if ( WriteProcessMemory( process.Handle, hMemory, byLibName, byLibName.Length, out _ ) == 0 )
            return false;

        var pLoadLibraryAddr = GetProcAddress( LoadLibrary( "kernel32" ), "LoadLibraryA" );

        if ( pLoadLibraryAddr == IntPtr.Zero )
            return false;

        var hThread = CreateRemoteThread( process.Handle, 0, 0, pLoadLibraryAddr, hMemory, 0, out _ );

        if ( hThread == IntPtr.Zero )
            return false;

        if ( WaitForSingleObject( hThread, -1 ) == 0 && GetExitCodeThread( hThread, out var dwAddr ) != 0 )
        {
            var hLib = LoadLibrary( LibName );
            var hEnt = GetProcAddress( hLib, EntryPoint );
            var iOff = dwAddr + (int)hEnt - (int)hLib;

            CreateRemoteThread( process.Handle, 0, 0, (IntPtr)iOff, IntPtr.Zero, 0, out _ );

            if ( hThread == IntPtr.Zero )
                return false;

            return true;
        }

        return false;
    }

    static void Main( string[] args )
    {
        if ( !Inject( "csgo", "EasySharp.dll", "Entry" ) )
            Console.WriteLine( "[!] Injection Failed!" );
        Console.WriteLine( "[+] Injection Succeeded!" );

        CleanCache();
    }
}

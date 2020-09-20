using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Injector
{
    public class Injector
    {
        public static string GenerateName()
        {
            var consonants = new string[] 
            { 
                "b", "c", "d", "f", "g", "h", 
                "j", "k", "l", "m", "n", "p", 
                "q", "r", "s", "t", "v", "w", 
                "x", "z", "a", "e", "i", "o", 
                "u", "ae", "y" 
            };

            var r = new Random();
            var s = string.Empty;

            for ( int i = 0; i < 10; ++i ) 
                s += consonants[r.Next( consonants.Length )];

            return s;
        }

        [DllImport( "kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true )]
        static extern IntPtr GetProcAddress( IntPtr hModule, string procName );

        [DllImport( "kernel32", SetLastError = true, CharSet = CharSet.Ansi )]
        static extern IntPtr LoadLibrary( [MarshalAs( UnmanagedType.LPStr )]string lpFileName );

        public static void Main()
        {
            var name = GenerateName() + ".dll";
            System.IO.File.Move( "EasySharp.dll", name );
            System.IO.File.Delete( "EasySharp.pdb" );
            var dll = $"C:\\Windows\\EasySharp-master\\Debug\\{name}";

            var lib = LoadLibrary(dll);
            var ptr = GetProcAddress(lib, "Entry");

            var diff = IntPtr.Subtract(ptr, (int)lib);

            Console.WriteLine( diff );

            Process proc = Process.GetProcessesByName("csgo").FirstOrDefault();
            while ( proc == null )
            {
                proc = Process.GetProcessesByName( "csgo" ).FirstOrDefault();
                Thread.Sleep( 1000 );
            }

            var injectedLibPtr = proc.LoadLibrary(dll);

            Console.WriteLine( diff );

            proc.CallAsync( IntPtr.Add( injectedLibPtr, (int)diff ), IntPtr.Zero );
        }
    }
}

namespace Injector
{
    public static class ProcessExtensions
    {
        private static IntPtr kernel32;
        private static IntPtr loadlibrary;

        static ProcessExtensions()
        {
            kernel32 = LoadLibrary( "kernel32" );
            loadlibrary = GetProcAddress( kernel32, "LoadLibraryA" );
        }

        public static IntPtr Alloc( this Process proc, int size )
        {
            return VirtualAllocEx( proc.Handle, IntPtr.Zero, (IntPtr)size,
                AllocationType.Commit | AllocationType.Reserve,
                MemoryProtection.ExecuteReadWrite );
        }

        public static bool Free( this Process proc, IntPtr ptr )
        {
            return VirtualFreeEx( proc.Handle, ptr, 0,
                FreeType.Decommit | FreeType.Release );
        }

        public static bool Write( this Process proc, IntPtr ptr, byte[] data )
        {
            IntPtr nBytes;
            return WriteProcessMemory( proc.Handle, ptr, data,
                data.Length, out nBytes );
        }

        public static byte[] Read( this Process proc, IntPtr ptr, int size )
        {
            var data = new byte[size];
            IntPtr nBytes;
            ReadProcessMemory( proc.Handle, ptr, data, size, out nBytes );
            return data;
        }

        public static IntPtr CallAsync( this Process proc, IntPtr ptr, IntPtr arg )
        {
            IntPtr hThreadId;
            var hThread = CreateRemoteThread(proc.Handle, IntPtr.Zero, 0,
                ptr, arg, 0, out hThreadId);
            return hThread;
        }

        public static int Call( this Process proc, IntPtr ptr, IntPtr arg )
        {
            IntPtr hThreadId;
            var hThread = CreateRemoteThread(proc.Handle, IntPtr.Zero, 0, ptr, arg, 0, out hThreadId);
            WaitForSingleObject( hThread, unchecked((uint)-1) );
            uint exitCode;
            GetExitCodeThread( hThread, out exitCode );
            Console.WriteLine( "exit code: " + exitCode );
            return (int)exitCode;
        }

        public static IntPtr LoadLibrary( this Process proc, string lib )
        {
            var libData = Encoding.UTF8.GetBytes(lib);
            var ptr = proc.Alloc(libData.Length);
            proc.Write( ptr, libData );
            var addr = proc.Call(loadlibrary, ptr);
            return (IntPtr)addr;
        }

        [DllImport( "kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true )]
        static extern IntPtr GetProcAddress( IntPtr hModule, string procName );

        [DllImport( "kernel32", SetLastError = true, CharSet = CharSet.Ansi )]
        static extern IntPtr LoadLibrary( [MarshalAs( UnmanagedType.LPStr )]string lpFileName );

        [DllImport( "kernel32.dll", SetLastError = true, ExactSpelling = true )]
        static extern IntPtr VirtualAllocEx( IntPtr hProcess, IntPtr lpAddress,
        IntPtr dwSize, AllocationType flAllocationType, MemoryProtection flProtect );

        [DllImport( "kernel32.dll", SetLastError = true, ExactSpelling = true )]
        static extern bool VirtualFreeEx( IntPtr hProcess, IntPtr lpAddress,
        int dwSize, FreeType dwFreeType );

        [DllImport( "kernel32.dll", SetLastError = true )]
        static extern bool WriteProcessMemory(
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
        static extern uint WaitForSingleObject( IntPtr hHandle, uint dwMilliseconds );

        [DllImport( "kernel32.dll" )]
        static extern bool GetExitCodeThread( IntPtr hThread, out uint lpExitCode );

        [DllImport( "kernel32.dll" )]
        static extern IntPtr CreateRemoteThread( IntPtr hProcess,
            IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress,
            IntPtr lpParameter, uint dwCreationFlags, out IntPtr lpThreadId );
    }

    [Flags]
    public enum FreeType
    {
        Decommit = 0x4000,
        Release = 0x8000,
    }

    [Flags]
    public enum AllocationType
    {
        Commit = 0x1000,
        Reserve = 0x2000,
        Decommit = 0x4000,
        Release = 0x8000,
        Reset = 0x80000,
        Physical = 0x400000,
        TopDown = 0x100000,
        WriteWatch = 0x200000,
        LargePages = 0x20000000
    }

    [Flags]
    public enum MemoryProtection
    {
        Execute = 0x10,
        ExecuteRead = 0x20,
        ExecuteReadWrite = 0x40,
        ExecuteWriteCopy = 0x80,
        NoAccess = 0x01,
        ReadOnly = 0x02,
        ReadWrite = 0x04,
        WriteCopy = 0x08,
        GuardModifierflag = 0x100,
        NoCacheModifierflag = 0x200,
        WriteCombineModifierflag = 0x400
    }
}
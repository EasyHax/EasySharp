using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpSkin_dll.Memory;

namespace SharpSkin_dll
{
    unsafe class HookEngine<T>
    {
        const int ExecuteReadWrite = 0x40;

        IntPtr og_addr;
        IntPtr tr_addr;
        byte[] og_bytes;
        byte[] de_bytes;

        public T o_fn;

        public HookEngine( baseInterface bi, int index, int len, T detour ) : this( ( *(IntPtr**)bi.addr )[index], detour, len ) { }

        public HookEngine( IntPtr func, T detour, int len )
        {
            //len = get_trampoline_size( func );
            tr_addr = Marshal.AllocHGlobal( len + 5 );
            og_bytes = new byte[len];
            og_addr = func;

            WinApi.VirtualProtect( tr_addr, len + 5, ExecuteReadWrite, out _ );
            WinApi.VirtualProtect( og_addr, len, ExecuteReadWrite, out _ );

            de_bytes = CreateJMP( Marshal.GetFunctionPointerForDelegate( detour ), og_addr );
            var tr_bytes = CreateJMP( og_addr + len, tr_addr + len );


            og_bytes = Memcpy( og_addr, len );
            Memcpy( og_bytes, tr_addr );
            Memcpy( tr_bytes, tr_addr + len );

            o_fn = Marshal.GetDelegateForFunctionPointer<T>( tr_addr );

            Hook();
        }

        public unsafe void Hook() => Memcpy( de_bytes, og_addr );
        public void Unhook() => Memcpy( og_bytes, og_addr );

        public void Dispose()
        {
            Unhook();
            Marshal.FreeHGlobal( tr_addr );
        }

        private byte[] CreateJMP( IntPtr to, IntPtr from )
        {
            var address = BitConverter.GetBytes( (int)to - (int)from - 5 );
            var opcodes = new byte[5] { 233, 0, 0, 0, 0 };
            Array.Copy( address, 0, opcodes, 1, 4 );
            return opcodes;
        }

        //private int get_trampoline_size( IntPtr addr, int count = 20 )
        //{
        //    SharpDisasm.ArchitectureMode mode = SharpDisasm.ArchitectureMode.x86_32;
        //    SharpDisasm.Disassembler.Translator.IncludeBinary = true;

        //    var bytes = Memcpy( addr, count );

        //    var opc = new List<byte[]>();
        //    var dis = new SharpDisasm.Disassembler( bytes, mode, 0, true );
        //    var ins = dis.Disassemble();

        //    opc.AddRange( ins.Select( i => i.Bytes ) );

        //    var size = 0;

        //    for ( var i = 0; size <= 5; ++i )
        //        size += opc[i].Length;

        //    Console.WriteLine( "HOOKED WITH SIZE: {0}", size );

        //    return size;
        //}
    }
}

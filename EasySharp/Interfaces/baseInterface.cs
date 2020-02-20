using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static SharpSkin_dll.Memory;
using static SharpSkin_dll.GenericInterop;

namespace SharpSkin_dll
{
    class baseInterface
    {
        public IntPtr addr;
        public IntPtr mHandle;
        public int mSize;

        public baseInterface((IntPtr, IntPtr, int) infos)
        {
            addr = infos.Item1;
            mHandle = infos.Item2;
            mSize = infos.Item3;
        }

        public unsafe static IntPtr rf<T>(ref T o)
        {
            TypedReference tr = __makeref(o);
            IntPtr ptr = *(IntPtr*)(&tr);
            return ptr;
        }

        public Delegate WrapVFunc(int index, Type return_Type, params Type[] args_Type) =>
            addr.VirtualAddress(index).deleg(CreateDelegate(return_Type, args_Type));

        public T CallVFunc<T>(Delegate vfunc, params object[] args)
            => (T)vfunc.DynamicInvoke(args);
    }
}

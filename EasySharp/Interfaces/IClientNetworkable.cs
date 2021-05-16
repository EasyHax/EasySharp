using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpSkin_dll.GenericInterop;

namespace SharpSkin_dll
{
    public class IClientNetworkable : IClientRenderable
    {
        public IntPtr pNetworkable { get => addr + 8; }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        delegate void d_SetDestroyedOnRecreateEntities(IntPtr addr);
        public void SetDestroyedOnRecreateEntities() => Marshal.GetDelegateForFunctionPointer<d_SetDestroyedOnRecreateEntities>(pNetworkable.VirtualAddress(13))(pNetworkable);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        delegate void d_PreDataUpdate(IntPtr addr, int updateType);
        public void PreDataUpdate(int updateType) => Marshal.GetDelegateForFunctionPointer<d_PreDataUpdate>(pNetworkable.VirtualAddress(6))(pNetworkable, updateType);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        delegate void d_Release(IntPtr addr);
        public void Release() => Marshal.GetDelegateForFunctionPointer<d_Release>(pNetworkable.VirtualAddress(1))(pNetworkable);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        delegate int d_EntIndex(IntPtr addr);
        public int EntIndex() => Marshal.GetDelegateForFunctionPointer<d_EntIndex>(pNetworkable.VirtualAddress(10))(pNetworkable);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpSkin_dll.GenericInterop;

namespace SharpSkin_dll
{
    public class IClientRenderable : IClientUnknown
    {
        public IntPtr pRenderable { get => addr + 4; }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        delegate IntPtr d_GetModel(IntPtr addr);
        public IntPtr GetModel() => Marshal.GetDelegateForFunctionPointer<d_GetModel>(pRenderable.VirtualAddress(8))(pRenderable);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        delegate byte d_SetupBones(IntPtr addr, IntPtr pBoneToWorldOut, int nMaxBones, int boneMask, float currentTime);
        public bool SetupBone(IntPtr pBoneToWorldOut, int nMaxBones, int boneMask, float currentTime) 
            => Marshal.GetDelegateForFunctionPointer<d_SetupBones>(pRenderable.VirtualAddress(13))(pRenderable, pBoneToWorldOut, nMaxBones, boneMask, currentTime) != 0;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpSkin_dll.GenericInterop;

namespace SharpSkin_dll
{
    class Entity : baseInterface
    {
        private Delegate getClientEntity;
        private Delegate getClientEntityFromHandle;

        public Entity((IntPtr, IntPtr, int) infos) : base(infos)
        {
            getClientEntity = WrapVFunc(3, t_IntPtr, t_Int32);
            getClientEntityFromHandle = WrapVFunc(4, t_IntPtr, t_IntPtr);
        }

        public IntPtr GetClientEntity(int num) => (IntPtr)getClientEntity.DynamicInvoke(addr, num);
        public IntPtr GetClientEntityFromHandle(IntPtr handle) => (IntPtr)getClientEntityFromHandle.DynamicInvoke(addr, handle);
    }
}

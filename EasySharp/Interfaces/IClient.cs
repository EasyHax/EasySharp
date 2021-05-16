using System;
using static SharpSkin_dll.GenericInterop;

namespace SharpSkin_dll
{
    class Client : baseInterface
    {
        Delegate getAllClasses;

        public Client((IntPtr, IntPtr, int) infos) : base(infos)
        {
            getAllClasses = WrapVFunc(8, t_IntPtr);
        }

        unsafe public ClientClass* GetAllClasses() => (ClientClass*)(IntPtr)getAllClasses.DynamicInvoke(addr);
    }
}

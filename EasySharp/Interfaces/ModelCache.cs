using System;
using static SharpSkin_dll.GenericInterop;

namespace SharpSkin_dll
{
    class ModelCache : baseInterface
    {
        Delegate findModel;

        public ModelCache((IntPtr, IntPtr, int) infos) : base(infos)
        {
            findModel = WrapVFunc(10, t_Ushort, t_String);
        }

        unsafe public ushort FindModel(string model) => (ushort)findModel.DynamicInvoke(addr, model);
    }
}

using System;
using static SharpSkin_dll.GenericInterop;

namespace SharpSkin_dll
{
    unsafe class DebugOverlay : baseInterface
    {
        private Delegate addLineOverlay;
        private Delegate screenPosition;

        public DebugOverlay((IntPtr, IntPtr, int) infos) : base(infos)
        {
            addLineOverlay = WrapVFunc(5, t_Void, t_IntPtr, t_IntPtr, t_Int32, t_Int32, t_Int32, t_Bool, t_Float);
            screenPosition = WrapVFunc(13, t_Int32, t_IntPtr, t_IntPtr);
        }

        public void AddLineOverlay(Vector origin, Vector dest, NativeColor color, bool noDepthTest, float duration) =>
            addLineOverlay.DynamicInvoke(addr, (IntPtr)(&origin), (IntPtr)(&dest), color.R, color.G, color.B, noDepthTest, duration);

        public bool ScreenPosition(Vector point, out Vector screen)
        {
            var v1 = new Vector();
            var bScreenPosition = (int)screenPosition.DynamicInvoke(addr, (IntPtr)(&point), (IntPtr)(&v1));
            screen = v1;
            return bScreenPosition != 1;
        }
    }
}

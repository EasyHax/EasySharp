using System;
using static SharpSkin_dll.GenericInterop;

namespace SharpSkin_dll
{
    unsafe class Surface : baseInterface
    {
        private Delegate drawLine;
        private Delegate drawSetColor;

        public Surface((IntPtr, IntPtr, int) infos) : base(infos)
        {
            drawLine = WrapVFunc(19, null, t_Int32, t_Int32, t_Int32, t_Int32);
            drawSetColor = WrapVFunc(15, null, typeof(NativeColor));
        }

        public void DrawLine(int x0, int y0, int x1, int y1) => drawLine.DynamicInvoke(addr, x0, y0, x1, y1);
        public void DrawSetColor(NativeColor color) => drawSetColor.DynamicInvoke(addr, color);

        public void DrawLine_FromScreen(Vector v1, Vector v2) => DrawLine((int)v1.X, (int)v1.Y, (int)v2.X, (int)v2.Y);
        public void DrawLine_FromWorld(Vector v1, Vector v2)
        {
            var bV1 = SharpSkin.g_DbgOverlay.ScreenPosition(v1, out var s_v1);
            var bV2 = SharpSkin.g_DbgOverlay.ScreenPosition(v2, out var s_v2);
            if (bV1 && bV2) DrawLine_FromScreen(s_v1, s_v2);
        }
    }
}

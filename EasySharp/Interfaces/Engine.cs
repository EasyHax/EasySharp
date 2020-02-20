using System;

using static SharpSkin_dll.Memory;
using static SharpSkin_dll.GenericInterop;

namespace SharpSkin_dll
{
    class Engine : baseInterface
    {
        Delegate isInGame;
        Delegate getLocalPlayer;
        Delegate getMaxClients;
        Delegate getViewAngles;
        Delegate setViewAngles;

        public Engine((IntPtr, IntPtr, int) infos) : base(infos)
        {
            isInGame       = WrapVFunc(26, t_Byte);
            getLocalPlayer = WrapVFunc(12, t_Int32);
            getMaxClients  = WrapVFunc(20, t_Int32);
            setViewAngles  = WrapVFunc(19, t_Int32, t_IntPtr);
            getViewAngles  = WrapVFunc(18, t_Int32, t_IntPtr);
        }

        public int GetLocalPlayer() => (int)getLocalPlayer.DynamicInvoke(addr);
        public bool IsInGame()      => Convert.ToBoolean(isInGame.DynamicInvoke(addr));
        public int GetMaxClients()  => (int)getMaxClients.DynamicInvoke(addr);

        unsafe public Vector GetViewAngles()
        {
            var vAngle = new Vector();
            getViewAngles.DynamicInvoke(addr, (IntPtr)(&vAngle));
            return vAngle;
        }

        unsafe public void SetViewAngles(Vector vAngle, bool clampAngles = true)
        {
            if (clampAngles) vAngle.Clamp();
            setViewAngles.DynamicInvoke(addr, (IntPtr)(&vAngle));
        }

        unsafe public void SetViewAngles2(Vector vAngle)
        {
            CallVFunc<object>(setViewAngles, addr, (IntPtr)(&vAngle));
        }
    }
}

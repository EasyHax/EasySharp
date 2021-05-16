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
        Delegate getPlayerInfo;
        Delegate clientCmd_Unrestricted;

        public Engine((IntPtr, IntPtr, int) infos) : base(infos)
        {
            isInGame       = WrapVFunc(26, t_Byte);
            getLocalPlayer = WrapVFunc(12, t_Int32);
            getMaxClients  = WrapVFunc(20, t_Int32);
            setViewAngles  = WrapVFunc(19, t_Int32, t_IntPtr);
            getViewAngles  = WrapVFunc(18, t_Int32, t_IntPtr);
            getPlayerInfo  = WrapVFunc(8, t_Byte, t_Int32, t_IntPtr);
            clientCmd_Unrestricted = WrapVFunc(114, t_Void, t_String, t_Bool);
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

        unsafe public bool GetPlayerInfo(int index, player_info_t* player_info) => Convert.ToBoolean((byte)getPlayerInfo.DynamicInvoke(addr, index, (IntPtr)player_info));

        public void ClientCmd_Unrestricted(string command, bool delayed = false) => clientCmd_Unrestricted.DynamicInvoke(addr, command, delayed);
    }

    public unsafe struct player_info_t
    {
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        //string pad;
        public fixed byte pad[0x08];
        public int xuid_low;
        public int xuid_high;
        public fixed byte name[128];
        public int userid;
        public int m_nUserID;
        public fixed char guid[33];
        public uint friendsid;
        public fixed byte friendsname[128];
        public byte fakeplayer;
        public byte ishltv;
        public fixed uint customfiles[4];
        public byte filesdownloaded;
    }
}

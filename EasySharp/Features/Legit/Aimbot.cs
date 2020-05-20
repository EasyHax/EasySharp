using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static SharpSkin_dll.SharpSkin;

namespace SharpSkin_dll.Features.Legit
{
    class Aimbot
    {
        public static void Do()
        {
            if ( !WinApi.isKeyDown( VirtualKeys.V ) )
                return;

            if(Utils.GetClosest( Utils.GetEnemies(), Hitboxes.HITBOX_HEAD, out var enemy, out var angle ) )
            {
                var new_angle = angle - g_LocalPlayer.m_aimPunchAngle * 2f;
                g_Engine.SetViewAngles( angle - g_LocalPlayer.m_aimPunchAngle * 2f );
            }
        }
    }
}

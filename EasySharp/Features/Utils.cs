using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;

using static SharpSkin_dll.SharpSkin;
using static SharpSkin_dll.Utils;
using static SharpSkin_dll.Structs;

namespace SharpSkin_dll
{
    class Utils
    {
        public static IEnumerable<BasePlayer> GetPlayers()
        {
            var players = new List<BasePlayer>();

            for ( var i = 0; i < g_Engine.GetMaxClients(); i++ )
            {
                var player = (BasePlayer)g_Entity.GetClientEntity(i);
                if ( !player && player != g_LocalPlayer && player.isAlive )
                    players.Add( player );
            }

            return players;
        }

        public static IEnumerable<BasePlayer> GetEnemies() => GetPlayers().Where( x => x.isEnemy ).ToArray();

        public static bool GetClosest( IEnumerable<BasePlayer> to_list, Hitboxes hitbox_to, out BasePlayer enemy, out Vector atAngle )
        {
            atAngle = default;
            enemy = IntPtr.Zero;

            var best_angle = new Vector();
            var min_crosshair_distance = 999d;

            foreach ( var to in to_list )
            {
                var toPos = hitbox_to == Hitboxes.HITBOX_HEAD ? to.m_vecEyePos : to.GetHitboxPos(hitbox_to);
                var crosshair_distance = ~(atAngle = g_LocalPlayer.m_vecEyePos ^ toPos);
                if ( crosshair_distance < min_crosshair_distance )
                {
                    enemy = to;
                    best_angle = atAngle;
                    min_crosshair_distance = crosshair_distance;
                }
            }

            atAngle = best_angle;
            return !enemy;
        }
    }
}

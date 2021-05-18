using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using static SharpSkin_dll.SharpSkin;
using static SharpSkin_dll.Structs;
using static SharpSkin_dll.Sequence;

namespace SharpSkin_dll
{
    class FixSequence
    {
        unsafe public static void Do( CRecvProxyData* pData, BaseViewModel pViewModel)
        {
            if ( !g_LocalPlayer || !g_LocalPlayer.isAlive || !pViewModel )
                return;

            var entity = (BasePlayer)g_Entity.GetClientEntityFromHandle((IntPtr)pViewModel.m_hOwner);

            if ( !entity )
                return;

            if ( entity.EntIndex() != g_Engine.GetLocalPlayer() )
                return;

            var model = g_MdlInfo.GetModel(pViewModel.m_nModelIndex);
            var mname = Marshal.PtrToStringAnsi((IntPtr)model->szName);
            var m_nSequence = (Sequence)Enum.Parse(typeof(Sequence), pData->m_Value.m_Int.ToString());

            if ( mname == null || mname == string.Empty )
                return;

            if ( mname.Contains( "models/weapons/v_knife_butterfly.mdl" ) )
            {
                switch ( m_nSequence )
                {
                    case SEQUENCE_DEFAULT_DRAW:
                        m_nSequence = RandomSequence( SEQUENCE_BUTTERFLY_DRAW, SEQUENCE_BUTTERFLY_DRAW2 );
                        break;
                    case SEQUENCE_DEFAULT_LOOKAT01:
                        m_nSequence = RandomSequence( SEQUENCE_BUTTERFLY_LOOKAT01, SEQUENCE_BUTTERFLY_LOOKAT03 );
                        break;
                    default:
                        m_nSequence++;
                        break;
                }
            }
            else if ( mname.Contains( "models/weapons/v_knife_falchion_advanced.mdl" ) )
            {
                switch ( m_nSequence )
                {
                    case SEQUENCE_DEFAULT_IDLE2:
                        m_nSequence = SEQUENCE_FALCHION_IDLE1;
                        break;
                    case SEQUENCE_DEFAULT_HEAVY_MISS1:
                        m_nSequence = RandomSequence( SEQUENCE_FALCHION_HEAVY_MISS1, SEQUENCE_FALCHION_HEAVY_MISS1_NOFLIP );
                        break;
                    case SEQUENCE_DEFAULT_LOOKAT01:
                        m_nSequence = RandomSequence( SEQUENCE_FALCHION_LOOKAT01, SEQUENCE_FALCHION_LOOKAT02 );
                        break;
                    case SEQUENCE_DEFAULT_DRAW:
                    case SEQUENCE_DEFAULT_IDLE1:
                        break;
                    default:
                        m_nSequence -= 1;
                        break;
                }
            }
            else if ( mname.Contains( "models/weapons/v_knife_css.mdl" ) )
            {
                switch ( m_nSequence )
                {
                    case SEQUENCE_DEFAULT_LOOKAT01:
                        m_nSequence = SEQUENCE_CSS_LOOKAT02;//RandomSequence(SEQUENCE_CSS_LOOKAT01, SEQUENCE_CSS_LOOKAT02);
                        break;
                    default:
                        break;
                }
            }
            else if ( mname.Contains( "models/weapons/v_knife_push.mdl" ) )
            {
                switch ( m_nSequence )
                {
                    case SEQUENCE_DEFAULT_IDLE2:
                        m_nSequence = SEQUENCE_DAGGERS_IDLE1;
                        break;
                    case SEQUENCE_DEFAULT_LIGHT_MISS1:
                        break;
                    case SEQUENCE_DEFAULT_LIGHT_MISS2:
                        m_nSequence = RandomSequence( SEQUENCE_DAGGERS_LIGHT_MISS1, SEQUENCE_DAGGERS_LIGHT_MISS5 );
                        break;
                    case SEQUENCE_DEFAULT_HEAVY_MISS1:
                        m_nSequence = RandomSequence( SEQUENCE_DAGGERS_HEAVY_MISS2, SEQUENCE_DAGGERS_HEAVY_MISS1 );
                        break;
                    case SEQUENCE_DEFAULT_HEAVY_HIT1:
                    case SEQUENCE_DEFAULT_HEAVY_BACKSTAB:
                    case SEQUENCE_DEFAULT_LOOKAT01:
                        m_nSequence += 3;
                        break;
                    case SEQUENCE_DEFAULT_DRAW:
                    case SEQUENCE_DEFAULT_IDLE1:
                        break;
                    default:
                        m_nSequence += 2;
                        break;
                }
            }
            else if ( mname.Contains( "models/weapons/v_knife_survival_bowie.mdl" ) )
            {
                switch ( m_nSequence )
                {
                    case SEQUENCE_DEFAULT_DRAW:
                    case SEQUENCE_DEFAULT_IDLE1:
                        break;
                    case SEQUENCE_DEFAULT_IDLE2:
                        m_nSequence = SEQUENCE_BOWIE_IDLE1;
                        break;
                    default:
                        m_nSequence -= 1;
                        break;
                }
            }
            else if ( mname.Contains( "models/weapons/v_knife_ursus.mdl" ) ||
                    mname.Contains( "models/weapons/v_knife_cord.mdl" ) ||
                    mname.Contains( "models/weapons/v_knife_canis.mdl" ) ||
                    mname.Contains( "models/weapons/v_knife_outdoor.mdl" ) ||
                    mname.Contains( "models/weapons/v_knife_skeleton.mdl" ) )
            {
                switch ( m_nSequence )
                {
                    case SEQUENCE_DEFAULT_DRAW:
                        m_nSequence = RandomSequence( SEQUENCE_BUTTERFLY_DRAW, SEQUENCE_BUTTERFLY_DRAW2 );
                        break;
                    case SEQUENCE_DEFAULT_LOOKAT01:
                        m_nSequence = RandomSequence( SEQUENCE_BUTTERFLY_LOOKAT01, SEQUENCE_CSS_LOOKAT01 );
                        break;
                    default:
                        m_nSequence += 1;
                        break;
                }
            }
            else if ( mname.Contains( "models/weapons/v_knife_stiletto.mdl" ) )
            {
                switch ( m_nSequence )
                {
                    case SEQUENCE_DEFAULT_LOOKAT01:
                        m_nSequence = RandomSequence( SEQUENCE_DEFAULT_LOOKAT01, SEQUENCE_BUTTERFLY_LOOKAT01 );
                        break;
                    default:
                        break;
                }
            }
            else if ( mname.Contains( "models/weapons/v_knife_widowmaker.mdl" ) )
            {
                switch ( m_nSequence )
                {
                    case SEQUENCE_DEFAULT_LOOKAT01:
                        m_nSequence = RandomSequence( SEQUENCE_CSS_LOOKAT01, SEQUENCE_BUTTERFLY_LOOKAT03 );
                        break;
                    default:
                        break;
                }
            }

            pData->m_Value.m_Int = (int)m_nSequence;
        }

        private static Sequence RandomSequence( Sequence s1, Sequence s2 ) => (Sequence)Enum.Parse( typeof( Sequence ), random.Next( (int)s1, (int)s2 + 1 ).ToString() );
    }

    [Flags]
    enum Sequence : int
    {
        SEQUENCE_DEFAULT_DRAW = 0,
        SEQUENCE_DEFAULT_IDLE1 = 1,
        SEQUENCE_DEFAULT_IDLE2 = 2,
        SEQUENCE_DEFAULT_LIGHT_MISS1 = 3,
        SEQUENCE_DEFAULT_LIGHT_MISS2 = 4,
        SEQUENCE_DEFAULT_HEAVY_MISS1 = 9,
        SEQUENCE_DEFAULT_HEAVY_HIT1 = 10,
        SEQUENCE_DEFAULT_HEAVY_BACKSTAB = 11,
        SEQUENCE_DEFAULT_LOOKAT01 = 12,

        SEQUENCE_BUTTERFLY_DRAW = 0,
        SEQUENCE_BUTTERFLY_DRAW2 = 1,
        SEQUENCE_BUTTERFLY_LOOKAT01 = 13,
        SEQUENCE_BUTTERFLY_LOOKAT03 = 15,

        SEQUENCE_FALCHION_IDLE1 = 1,
        SEQUENCE_FALCHION_HEAVY_MISS1 = 8,
        SEQUENCE_FALCHION_HEAVY_MISS1_NOFLIP = 9,
        SEQUENCE_FALCHION_LOOKAT01 = 12,
        SEQUENCE_FALCHION_LOOKAT02 = 13,

        SEQUENCE_CSS_LOOKAT01 = 14,
        SEQUENCE_CSS_LOOKAT02 = 15,

        SEQUENCE_DAGGERS_IDLE1 = 1,
        SEQUENCE_DAGGERS_LIGHT_MISS1 = 2,
        SEQUENCE_DAGGERS_LIGHT_MISS5 = 6,
        SEQUENCE_DAGGERS_HEAVY_MISS2 = 11,
        SEQUENCE_DAGGERS_HEAVY_MISS1 = 12,

        SEQUENCE_BOWIE_IDLE1 = 1,
    }
}

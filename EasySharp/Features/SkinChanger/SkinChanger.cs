using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using static SharpSkin_dll.SharpSkin;
using static SharpSkin_dll.Offset;
using static SharpSkin_dll.Structs;

namespace SharpSkin_dll
{
    public struct WeaponKit
    {
        public int      skin_id;
        public int      item_index;
        public string   weapon;
        public float    fallback;
        public int      stattrack;
        public string   customname;
    }

    unsafe class SkinChanger
    {
        public static List<WeaponKit> weaponKits = new List<WeaponKit>();
        public static WeaponKit knifeKit = new WeaponKit() { weapon = string.Empty };

        public static void Do()
        {
            if ( !g_Engine.IsInGame() || !g_LocalPlayer || !g_LocalPlayer.isAlive )
            {
                model_indexes = null;
                return;
            }

            var weapons = g_LocalPlayer.m_hMyWeapons;
            var viewMdl = (BaseViewModel)g_Entity.GetClientEntityFromHandle((IntPtr)g_LocalPlayer.m_hViewModel_0);
            if ( !viewMdl ) return;

            var cWeapon = g_Entity.GetClientEntityFromHandle((IntPtr)(viewMdl.m_hWeapon));
            if ( cWeapon == IntPtr.Zero ) return;

            for ( var i = 0; weapons[i] != (IntPtr)(-1); i++ )
            {
                var hWeapon = (BaseAttributableItem)g_Entity.GetClientEntityFromHandle(weapons[i]);

                if ( !hWeapon ) break;

                if ( form.knife1.knife_enabled.Checked )
                {
                    if ( hWeapon.m_iItemDefinitionIndex == 59 || hWeapon.m_iItemDefinitionIndex == 42 || (hWeapon.m_iItemDefinitionIndex > 400 && hWeapon.m_iItemDefinitionIndex < 600) )
                    {
                        var knife = knifeKit.weapon;
                        if ( knife == string.Empty )
                            continue;

                        var model_index = GetModelIndex( knife );

                        if ( cWeapon == hWeapon && viewMdl.m_nModelIndex != model_index )
                            viewMdl.m_nModelIndex = model_index;

                        if ( hWeapon.m_nModelIndex != model_index )
                            hWeapon.m_nModelIndex = model_index;

                        if ( hWeapon.m_iItemDefinitionIndex != knifeKit.item_index )
                            hWeapon.m_iItemDefinitionIndex = knifeKit.item_index;

                        var wSkin = hWeapon.m_nFallbackPaintKit;

                        if ( wSkin == knifeKit.skin_id || knifeKit.skin_id == 0 )
                            continue;

                        hWeapon.m_nFallbackPaintKit = knifeKit.skin_id;

                        if ( knifeKit.fallback != 0 ) hWeapon.m_flFallbackWear = knifeKit.fallback;
                        else hWeapon.m_flFallbackWear = 0.0001f;

                        if ( knifeKit.stattrack != 0 )
                        {
                            hWeapon.m_iAccountID = hWeapon.m_OriginalOwnerXuidLow;
                            hWeapon.m_nFallbackStatTrak = knifeKit.stattrack;
                        }

                        if ( knifeKit.customname != string.Empty )
                            Marshal.Copy( Encoding.UTF8.GetBytes( knifeKit.customname ), 0, (IntPtr)(hWeapon + DT_BaseAttributableItem.m_szCustomName), knifeKit.customname.Length );

                        hWeapon.m_iItemIDHigh = -1;
                        continue;
                    }
                }
                if ( form.weapons1.weapon_enabled.Checked )
                {
                    if ( form.weapons1.randomSkins.Checked )
                    {
                        var wSkin = DumpSkins.sharpSkin_SkinId[random.Next(0, DumpSkins.sharpSkin_SkinId.Length)];

                        if ( wSkin == 0 )
                            continue;

                        hWeapon.m_nFallbackPaintKit = wSkin;
                        hWeapon.m_flFallbackWear = 0.0001f;
                        hWeapon.m_iAccountID = hWeapon.m_OriginalOwnerXuidLow;
                        hWeapon.m_nFallbackStatTrak = 9999;
                        hWeapon.m_iItemIDHigh = -1;
                    }
                    else
                    {
                        var index = weaponKits.FindIndex(x => x.item_index == hWeapon.m_iItemDefinitionIndex);
                        if ( index == -1 ) continue;

                        var weaponKit = weaponKits[index];

                        var wSkin = hWeapon.m_nFallbackPaintKit;
                        if ( weaponKit.skin_id == 0 || wSkin == weaponKit.skin_id )
                            continue;

                        hWeapon.m_nFallbackPaintKit = weaponKit.skin_id;

                        if ( weaponKit.fallback != 0 ) hWeapon.m_flFallbackWear = weaponKit.fallback;
                        else hWeapon.m_flFallbackWear = 0.0001f;

                        if ( weaponKit.stattrack != 0 )
                        {
                            hWeapon.m_iAccountID = hWeapon.m_OriginalOwnerXuidLow;
                            hWeapon.m_nFallbackStatTrak = weaponKit.stattrack;
                        }

                        hWeapon.m_nFallbackSeed = 3148; //#############################################

                        if ( weaponKit.customname != string.Empty )
                            Marshal.Copy( Encoding.UTF8.GetBytes( weaponKit.customname ), 0, (IntPtr)(hWeapon + DT_BaseAttributableItem.m_szCustomName), weaponKit.customname.Length );

                        hWeapon.m_iItemIDHigh = -1;
                    }

                    continue;
                }
            }
        }

        public static Dictionary<string, int> model_indexes;

        public static void InitModelIndexes()
        {
            model_indexes = new Dictionary<string, int>()
            {
                ["BAYONET"       ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_bayonet.mdl"           ),
                ["FLIP"          ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_flip.mdl"              ),
                ["GUT"           ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_gut.mdl"               ),
                ["KARAMBIT"      ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_karam.mdl"             ),
                ["M9_BAYONET"    ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_m9_bay.mdl"            ),
                ["TACTICAL"      ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_tactical.mdl"          ),
                ["FALCHION"      ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_falchion_advanced.mdl" ),
                ["SURVIVAL_BOWIE"] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_survival_bowie.mdl"    ),
                ["BUTTERFLY"     ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_butterfly.mdl"         ),
                ["PUSH"          ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_push.mdl"              ),
                ["URSUS"         ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_ursus.mdl"             ),
                ["NAVAJA"        ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_gypsy_jackknife.mdl"   ),
                ["STILETTO"      ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_stiletto.mdl"          ),
                ["WIDOWMAKER"    ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_widowmaker.mdl"        ),
                ["CLASSIC"       ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_css.mdl"               ),
                ["SKELETON"      ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_skeleton.mdl"          ),
                ["SURVIVAL"      ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_canis.mdl"             ),
                ["NOMAD"         ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_outdoor.mdl"           ),
                ["PARACORD"      ] = g_MdlInfo.GetModelIndex( "models/weapons/v_knife_cord.mdl"              )
            };
        }

        public static int GetModelIndex( string ModelName )
        {
            if ( model_indexes == null )
                InitModelIndexes();
            return model_indexes[ModelName];
        }
    }
}

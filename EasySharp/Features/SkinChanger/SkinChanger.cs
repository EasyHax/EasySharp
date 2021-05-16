using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using static SharpSkin_dll.SharpSkin;
using static SharpSkin_dll.Offset;
using static SharpSkin_dll.Structs;
using static SharpSkin_dll.ItemDefinitionIndex;

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
        public int      seed;
    }

    unsafe static class SkinChanger
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        delegate IntPtr d_CreateWearableFn(int entry, int serial);

        public static void InitModel()
        {
            model_indexes = new Dictionary<string, int>();

            model_indexes.Add("KNIFE_T"           , g_MdlInfo.GetModelIndex("models/weapons/v_knife_default_t.mdl"                                              ));
            model_indexes.Add("KNIFE_CT"          , g_MdlInfo.GetModelIndex("models/weapons/v_knife_default_ct.mdl"                                             ));
            model_indexes.Add("BAYONET"           , g_MdlInfo.GetModelIndex("models/weapons/v_knife_bayonet.mdl"                                                ));
            model_indexes.Add("FLIP"              , g_MdlInfo.GetModelIndex("models/weapons/v_knife_flip.mdl"                                                   ));
            model_indexes.Add("GUT"               , g_MdlInfo.GetModelIndex("models/weapons/v_knife_gut.mdl"                                                    ));
            model_indexes.Add("KARAMBIT"          , g_MdlInfo.GetModelIndex("models/weapons/v_knife_karam.mdl"                                                  ));
            model_indexes.Add("M9_BAYONET"        , g_MdlInfo.GetModelIndex("models/weapons/v_knife_m9_bay.mdl"                                                 ));
            model_indexes.Add("TACTICAL"          , g_MdlInfo.GetModelIndex("models/weapons/v_knife_tactical.mdl"                                               ));
            model_indexes.Add("FALCHION"          , g_MdlInfo.GetModelIndex("models/weapons/v_knife_falchion_advanced.mdl"                                      ));
            model_indexes.Add("SURVIVAL_BOWIE"    , g_MdlInfo.GetModelIndex("models/weapons/v_knife_survival_bowie.mdl"                                         ));
            model_indexes.Add("BUTTERFLY"         , g_MdlInfo.GetModelIndex("models/weapons/v_knife_butterfly.mdl"                                              ));
            model_indexes.Add("PUSH"              , g_MdlInfo.GetModelIndex("models/weapons/v_knife_push.mdl"                                                   ));
            model_indexes.Add("URSUS"             , g_MdlInfo.GetModelIndex("models/weapons/v_knife_ursus.mdl"                                                  ));
            model_indexes.Add("NAVAJA"            , g_MdlInfo.GetModelIndex("models/weapons/v_knife_gypsy_jackknife.mdl"                                        ));
            model_indexes.Add("STILETTO"          , g_MdlInfo.GetModelIndex("models/weapons/v_knife_stiletto.mdl"                                               ));
            model_indexes.Add("WIDOWMAKER"        , g_MdlInfo.GetModelIndex("models/weapons/v_knife_widowmaker.mdl"                                             ));
            model_indexes.Add("CLASSIC"           , g_MdlInfo.GetModelIndex("models/weapons/v_knife_css.mdl"                                                    ));
            model_indexes.Add("SKELETON"          , g_MdlInfo.GetModelIndex("models/weapons/v_knife_skeleton.mdl"                                               ));
            model_indexes.Add("SURVIVAL"          , g_MdlInfo.GetModelIndex("models/weapons/v_knife_canis.mdl"                                                  ));
            model_indexes.Add("NOMAD"             , g_MdlInfo.GetModelIndex("models/weapons/v_knife_outdoor.mdl"                                                ));
            model_indexes.Add("PARACORD"          , g_MdlInfo.GetModelIndex("models/weapons/v_knife_cord.mdl"                                                   ));
            model_indexes.Add("BLOODHOUND"        , g_MdlInfo.GetModelIndex("models/weapons/v_models/arms/glove_bloodhound/v_glove_bloodhound.mdl"              ));
            model_indexes.Add("T_SIDE"            , g_MdlInfo.GetModelIndex("models/weapons/v_models/arms/glove_fingerless/v_glove_fingerless.mdl"              ));
            model_indexes.Add("CT_SIDE"           , g_MdlInfo.GetModelIndex("models/weapons/v_models/arms/glove_hardknuckle/v_glove_hardknuckle.mdl"            ));
            model_indexes.Add("SPORTY"            , g_MdlInfo.GetModelIndex("models/weapons/v_models/arms/glove_sporty/v_glove_sporty.mdl"                      ));
            model_indexes.Add("SLICK"             , g_MdlInfo.GetModelIndex("models/weapons/v_models/arms/glove_slick/v_glove_slick.mdl"                        ));
            model_indexes.Add("LEATHER_WRAP"      , g_MdlInfo.GetModelIndex("models/weapons/v_models/arms/glove_handwrap_leathery/v_glove_handwrap_leathery.mdl"));
            model_indexes.Add("MOTORCYCLE"        , g_MdlInfo.GetModelIndex("models/weapons/v_models/arms/glove_motorcycle/v_glove_motorcycle.mdl"              ));
            model_indexes.Add("SPECIALIST"        , g_MdlInfo.GetModelIndex("models/weapons/v_models/arms/glove_specialist/v_glove_specialist.mdl"              ));
            model_indexes.Add("HYDRA"             , g_MdlInfo.GetModelIndex("models/weapons/v_models/arms/glove_bloodhound/v_glove_bloodhound_hydra.mdl"        ));
            model_indexes.Add("BROKEN_FANG"       , g_MdlInfo.GetModelIndex("models/weapons/v_models/arms/anarchist/v_glove_anarchist.mdl"                      ));
        }

        public static Dictionary<string, int> model_indexes;

        public static List<WeaponKit> weaponKits = new List<WeaponKit>();
        public static WeaponKit knifeKit = new WeaponKit() { weapon = string.Empty, customname = string.Empty };
        public static WeaponKit gloveKit = new WeaponKit() { weapon = string.Empty, customname = string.Empty };


        public static void Do()
        {
            try
            {
                if (!g_Engine.IsInGame())
                {
                    model_indexes = null;
                    return;
                }

                if (!g_LocalPlayer)
                    return;

                if (model_indexes == null) InitModel();

                if (form.knife1.gloves_enabled.Checked)
                {
                    var wearables = g_LocalPlayer.m_hMyWearables;
                    var glove = (BaseAttributableItem)g_Entity.GetClientEntityFromHandle(wearables[0]);
                    var hGlove = IntPtr.Zero;

                    if (!glove)
                    {
                        var pGlove = (BaseAttributableItem)g_Entity.GetClientEntityFromHandle(hGlove);

                        if (pGlove)
                        {
                            wearables[0] = hGlove;
                            glove = pGlove;
                        }
                    }

                    if (!g_LocalPlayer.isAlive && glove)
                    {
                        glove.SetDestroyedOnRecreateEntities();
                        glove.Release();
                        return;
                    }

                    if (!glove)
                    {
                        var entry = g_Entity.GetHighestEntityIndex() + 1;
                        var serial = random.Next(0x1000);
                        var create = Utils.GetClass("CEconWearable")->m_pCreateFn;

                        var CreateWearableFn = Marshal.GetDelegateForFunctionPointer<d_CreateWearableFn>(create);
                        var ret = CreateWearableFn(entry, serial);
                        glove = g_Entity.GetClientEntity(entry);
                        wearables[0] = (IntPtr)(entry | serial << 16);
                        hGlove = wearables[0];
                    }

                    *(int*)(glove.addr + DT_BaseEntity.m_bIsAutoaimTarget + 4) = -1;

                    glove.ApplyPainKit(gloveKit, true);
                    glove.PreDataUpdate(0);
                }

                if (!g_LocalPlayer.isAlive)
                    return;

                var weapons = g_LocalPlayer.m_hMyWeapons;
                var viewMdl = (BaseViewModel)g_Entity.GetClientEntityFromHandle((IntPtr)g_LocalPlayer.m_hViewModel_0);
                if (!viewMdl) return;

                var cWeapon = g_Entity.GetClientEntityFromHandle((IntPtr)viewMdl.m_hWeapon);
                if (cWeapon == IntPtr.Zero) return;

                for (var i = 0; weapons[i] != (IntPtr)(-1); i++)
                {
                    var hWeapon = (BaseAttributableItem)g_Entity.GetClientEntityFromHandle(weapons[i]);

                    if (!hWeapon) break;

                    if (form.knife1.knife_enabled.Checked)
                    {
                        if ( IsKnife(hWeapon.m_iItemDefinitionIndex) )
                        {
                            var knife = knifeKit.weapon;
                            if (string.IsNullOrEmpty(knife))
                                continue;

                            var model_index = model_indexes[knife];

                            if (cWeapon == hWeapon && viewMdl.m_nModelIndex != model_index)
                                viewMdl.m_nModelIndex = model_index;
                            
                            hWeapon.ApplyPainKit(knifeKit, true);

                            continue;
                        }
                    }
                    if (form.weapons1.weapon_enabled.Checked)
                    {
                        if (form.weapons1.randomSkins.Checked)
                        {
                            var kit = new WeaponKit();
                            kit.skin_id = DumpSkins.sharpSkin_SkinId[random.Next(0, DumpSkins.sharpSkin_SkinId.Length)];
                            kit.fallback = 0.00001f;
                            kit.stattrack = 1337;

                            hWeapon.ApplyPainKit(kit);
                        }
                        else
                        {
                            var index = weaponKits.FindIndex(x => x.item_index == hWeapon.m_iItemDefinitionIndex);
                            if (index == -1) continue;

                            var kit = weaponKits[index];

                            hWeapon.ApplyPainKit(kit);
                        }
                    }
                }
            } 
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static bool IsKnife(int i) => (i >= (int)BAYONET && i < (int)BLOODHOUND) || i == (int)KNIFE_T || i == (int)KNIFE_CT;

        public static void ApplyPainKit(this BaseAttributableItem handle, WeaponKit kit, bool fix_model = false)
        {
            handle.m_iItemIDHigh = -1;

            if ( string.IsNullOrEmpty(kit.weapon) ) 
                return;


            if (fix_model && handle.m_iItemDefinitionIndex != kit.item_index)
            {
                handle.m_iItemDefinitionIndex = kit.item_index;
                handle.m_nModelIndex = model_indexes[kit.weapon];
            }

            var skin = handle.m_nFallbackPaintKit;

            if (kit.skin_id == 0 || skin == kit.skin_id)
                return;

            handle.m_nFallbackPaintKit = kit.skin_id;

            if (kit.fallback != 0) handle.m_flFallbackWear = kit.fallback;
            else handle.m_flFallbackWear = 0.0001f;

            if (kit.seed != 0) handle.m_nFallbackSeed = kit.seed;

            if (kit.stattrack != 0)
            {
                handle.m_iAccountID = handle.m_OriginalOwnerXuidLow;
                handle.m_nFallbackStatTrak = kit.stattrack;
            }

            if (kit.customname != string.Empty)
                Marshal.Copy(Encoding.UTF8.GetBytes(kit.customname), 0, handle.m_szCustomName, kit.customname.Length);   
        }

        public static void ForceFullUpdate()
        {
            *(int*)(g_ClientState + 0x174) = -1;
        }
    }
}

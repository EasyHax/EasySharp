using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpSkin_dll
{
    static class Parser
    {

        /*
         * PaintKit_gs_ak47_empress_Tag
         * PaintKit_gs_g3sg1_cetme_redux_Tag
         * PaintKit_gs_r8_llamacannon_Tag
         * PaintKit_aq_xm1014_ziggy_anarchy_Tag
         * 
         * #PaintKit_cu_pinstripe_ak47_Tag
         * #PaintKit_am_dragon_glock_Tag"
         */

        public static (string, string) Parse(string item_name, bool is_glove = false)
        {
            if ( is_glove )
            {
                item_name = item_name.ToUpper();
                if (item_name.Contains("BLOODHOUND_HYDRA")) return ("", "HYDRA"             );
                if (item_name.Contains("SPORTY"         ))  return ("", "SPORTY"            );
                if (item_name.Contains("SLICK"          ))  return ("", "SLICK"             );
                if (item_name.Contains("HANDWRAP"       ))  return ("", "LEATHER_WRAP"      );
                if (item_name.Contains("MOTORCYCLE"     ))  return ("", "MOTORCYCLE"        );
                if (item_name.Contains("SPECIALIST"     ))  return ("", "SPECIALIST"        );
                if (item_name.Contains("BLOODHOUND"     ))  return ("", "BLOODHOUND"        );
                if (item_name.Contains("OPERATION10"    ))  return ("", "BROKEN_FANG"       );

                return ("ERROR", "ERROR");
            }

            if (item_name.Contains("m4a1-s"))
                item_name = item_name.Replace("m4a1-s", "m4a1_silencer");
            if (item_name.Contains("usp-s"))
                item_name = item_name.Replace("usp-s", "usp_silencer");

            var weapons = Enum.GetNames(typeof(ItemDefinitionIndex));
            RemoveString("PaintKit_", ref item_name);
            RemoveString("_Tag",      ref item_name);
            item_name = item_name.Remove(0, 3);

            for (int i = weapons.Length - 1; i >= 0; i--)
                if (item_name.Contains(weapons[i].ToLower()))
                {
                    ReplaceAllChars('_', ' ', ref item_name);
                    RemoveString(weapons[i].ToLower(), ref item_name);
                    return (item_name, weapons[i]);
                }

            return ("ERROR", "ERROR");
        }

        public static string TranslateSkinName(string raw_skin_name)
        {
            if (raw_skin_name.Contains(" Cette arme"))
                return raw_skin_name.Remove(raw_skin_name.IndexOf(" Cette arme"));
            else
            {
                for(int c = 1; c < raw_skin_name.Length -1; c++)
                    if (char.IsUpper(raw_skin_name[c]))
                        raw_skin_name = raw_skin_name.Remove(c - 1);
                return raw_skin_name;
            }
        }

        public static void ReplaceAllChars(char old_c, char new_c, ref string str)
        {
            var result = string.Empty;
            foreach (var c1 in str)
                if (c1 != old_c)
                    result += c1;
                else
                    result += new_c;
            str = result;
        }

        public static void RemoveString(string s, ref string str)
        {
            while (str.Contains(s))
                str = str.Replace(s, string.Empty);
        }

        public static float FallBackFromInt(int i)
        {
            if (i == 10) return 0.0001f;
            else if (i == 9) return 0.1384f;
            else if (i == 8) return 0.2235f;
            else if (i == 7) return 0.3245f;
            else if (i == 6) return 0.4202f;
            else if (i == 5) return 0.5079f;
            else if (i == 4) return 0.6036f;
            else if (i == 3) return 0.7074f;
            else if (i == 2) return 0.8031f;
            else if (i == 1) return 0.9333f;
            else if (i == 0) return 0.9999f;

            else return 0f;
        }

        public static void AddNewKit(this ListBox.ObjectCollection objectCollection, WeaponKit weaponKit, string tag = "")
        {
            weaponKit.weapon = weaponKit.weapon // for alignement
                .Replace("_SILENCER", "S")
                .Replace("FIVESEVEN", "FSEVEN")
                .Replace("REVOLVER", "R8")
                .Replace("SAWEDOFF", "SDOFF");

            var str = string.Format("{5}{0}\t{1}\t{2}\t{3}\t{4}",
                weaponKit.skin_id,
                weaponKit.weapon,
                weaponKit.fallback,
                weaponKit.stattrack,
                weaponKit.customname,
                tag
                );

            objectCollection.Add(str);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

using static SharpSkin_dll.IMaterial;
using static SharpSkin_dll.IMaterial.MaterialVarFlags_t;
using static SharpSkin_dll.SharpSkin;

namespace SharpSkin_dll
{
    public partial class chams : UserControl
    {
        public static readonly Dictionary<string, string> matlist = new Dictionary<string, string>()
        {
            { "default"      , ""                                                                   },
            { "platinium"    , "models/player/ct_fbi/ct_fbi_glass"                                  },
            { "glass"        , "models/inventory_items/cologne_prediction/cologne_prediction_glass" },
            { "crystal"      , "models/inventory_items/trophy_majors/crystal_clear"                 },
            { "gold"         , "models/inventory_items/trophy_majors/gold"                          },
            { "dark_chrome"  , "models/gibs/glass/glas"                                             },
            { "plastic_glass", "models/inventory_items/trophy_majors/gloss"                         },
            { "glow"         , "vgui/achievements/glow"                                             }
        };

        public chams()
        {
            InitializeComponent();

            matlist_gloves.Items.AddRange(matlist.Keys.ToArray());
            matlist_sleeves.Items.AddRange(matlist.Keys.ToArray());
            matlist_weapon.Items.AddRange(matlist.Keys.ToArray());

            matlist_gloves.SelectedItem = "default";
            matlist_sleeves.SelectedItem = "default";
            matlist_weapon.SelectedItem = "default";
        }

        private void mcolor_weapon_Click(object sender, EventArgs e)
        {
            mcolor_weapon.BackColor = colorDialog1_weapon.ShowDialog() == DialogResult.OK ? colorDialog1_weapon.Color : mcolor_weapon.BackColor;
            Chams.weapon.Item3 = mcolor_weapon.BackColor;
        }

        private void mcolor_gloves_Click(object sender, EventArgs e)
        {
            mcolor_gloves.BackColor = colorDialog2_gloves.ShowDialog() == DialogResult.OK ? colorDialog2_gloves.Color : mcolor_gloves.BackColor;
            Chams.gloves.Item3 = mcolor_gloves.BackColor;
        }

        private void mcolor_sleeves_Click(object sender, EventArgs e)
        {
            mcolor_sleeves.BackColor = colorDialog3_sleeves.ShowDialog() == DialogResult.OK ? colorDialog3_sleeves.Color : mcolor_sleeves.BackColor;
            Chams.sleeves.Item3 = mcolor_sleeves.BackColor;
        }

        private void matlist_weapon_SelectedIndexChanged(object sender, EventArgs e) 
            => Chams.weapon.Item1 = matlist[(string)matlist_weapon.SelectedItem];

        private void matlist_gloves_SelectedIndexChanged(object sender, EventArgs e)
            => Chams.gloves.Item1 = matlist[(string)matlist_gloves.SelectedItem];

        private void matlist_sleeves_SelectedIndexChanged(object sender, EventArgs e) 
            => Chams.sleeves.Item1 = matlist[(string)matlist_sleeves.SelectedItem];

        private void alpha_gloves_Scroll(object sender, EventArgs e)
        {
            alpha_gloves_value.Text = Math.Round(alpha_gloves.Value / 255f, 4).ToString();
            Chams.gloves.Item2 = float.Parse(alpha_gloves_value.Text, CultureInfo.InvariantCulture);
        }

        private void alpha_weapon_Scroll(object sender, EventArgs e)
        {
            alpha_weapon_value.Text = Math.Round(alpha_weapon.Value / 255f, 4).ToString();
            Chams.weapon.Item2 = float.Parse(alpha_weapon_value.Text, CultureInfo.InvariantCulture);
        }

        private void alpha_sleeves_Scroll(object sender, EventArgs e)
        {
            alpha_sleeves_value.Text = Math.Round(alpha_sleeves.Value / 255f, 4).ToString();
            Chams.sleeves.Item2 = float.Parse(alpha_sleeves_value.Text, CultureInfo.InvariantCulture);
        }
    }

    public class Chams
    {
        // Faster than getting it from [SelectedItem]
        public static (string, float, Color) gloves  = (string.Empty, 1f, Color.FromArgb(0, 0, 0));
        public static (string, float, Color) sleeves = (string.Empty, 1f, Color.FromArgb(0, 0, 0));
        public static (string, float, Color) weapon  = (string.Empty, 1f, Color.FromArgb(0, 0, 0));

        public static void Do(string modelName)
        {
            if (modelName.Contains("weapons/v_"))
            {
                if (modelName.Contains("glove")) drawGloves();
                else if (modelName.Contains("sleeve") || modelName.Contains("arms")) drawSleeves();
                else drawWeapons();
            }
        }

        public static void drawGloves()
        {          
            if (gloves.Item1 == string.Empty) return;
            if (form.chams1.gloves_mcolor_enabled.Checked)
                g_MatSys.OverriderMaterial(gloves.Item1, (int)MATERIAL_VAR_WIREFRAME, form.chams1.gloves_wireframe_enabled.Checked, gloves.Item2, gloves.Item3);
            else g_MatSys.OverriderMaterial(gloves.Item1, (int)MATERIAL_VAR_WIREFRAME, form.chams1.gloves_wireframe_enabled.Checked, gloves.Item2);
        }

        public static void drawWeapons()
        {
            //models\weapons\knife_css.vmt
            //var mat = g_MatSys.FindMaterial("models/weapons/v_models/knife_m9_bay/knife_m9_bay.vmt", g_MatSys.TEXTURE_GROUP_OTHER);
            //var mat = g_MatSys.FindMaterial("models/weapons/v_models/pist_deagle/pist_deagle.vmt");
            //Console.WriteLine("mat:" + mat.addr);
            //g_MdlRender.ForcedMaterialOverride(CustomSkins.mymat);

            if (weapon.Item1 == string.Empty) return;
            if (form.chams1.weapon_mcolor_enabled.Checked)
                g_MatSys.OverriderMaterial(weapon.Item1, (int)MATERIAL_VAR_WIREFRAME, form.chams1.weapon_wireframe_enabled.Checked, weapon.Item2, weapon.Item3);
            else g_MatSys.OverriderMaterial(weapon.Item1, (int)MATERIAL_VAR_WIREFRAME, form.chams1.weapon_wireframe_enabled.Checked, weapon.Item2);
            
        }

        public static void drawSleeves()
        {
            if (sleeves.Item1 == string.Empty) return;
            if (form.chams1.sleeves_mcolor_enabled.Checked)
                g_MatSys.OverriderMaterial(sleeves.Item1, (int)MATERIAL_VAR_WIREFRAME, form.chams1.sleeves_wireframe_enabled.Checked, sleeves.Item2, sleeves.Item3);
            else g_MatSys.OverriderMaterial(sleeves.Item1, (int)MATERIAL_VAR_WIREFRAME, form.chams1.sleeves_wireframe_enabled.Checked, sleeves.Item2);
        }
    }
}

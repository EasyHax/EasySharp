using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using static SharpSkin_dll.SharpSkin;

namespace SharpSkin_dll
{
    public partial class profile : UserControl
    {
        public profile()
        {
            if (!Directory.Exists(config_path))
                Directory.CreateDirectory(config_path);

            InitializeComponent();
        }

        public static string config_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SharpSkin\\";

        private void button4_Click(object sender, EventArgs e)
        {
            if (profile_name.Text == string.Empty)
                return;

            Config.Save(profile_name.Text);
            current_profile.Text = profile_name.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (list_configs.SelectedIndex == -1)
                return;

            var profile_name = (string)list_configs.SelectedItem;
            try
            {
                Config.Load(profile_name);
                current_profile.Text = profile_name;
                Log(string.Format("Profile {0} loaded successfuly", profile_name));
            }
            catch
            {
                Log(string.Format("Profile {0} is corrupted", profile_name));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Config.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (list_configs.SelectedIndex == -1)
                return;

            File.Delete(config_path + (string)list_configs.SelectedItem + ".cfg");
            Config.Refresh();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) => GuiTheme.DarkTheme();
        private void button7_Click(object sender, EventArgs e) => GuiTheme.RandomTheme();
        private void button8_Click(object sender, EventArgs e) => GuiTheme.PurpleTheme();
        private void button1_Click(object sender, EventArgs e) => GuiTheme.CyanTheme();

        private void list_configs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_configs.SelectedIndex == -1) return;
            current_profile.Text = (string)list_configs.SelectedItem;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Config.Save(current_profile.Text);
            Log(string.Format("Saved profile successfuly {0}", current_profile.Text));
        }

        private void Log(string msg)
        {
            logs.AppendText(msg + Environment.NewLine);
        }
    }

    static class Config
    {
        static readonly string config_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SharpSkin\\";
        static Dictionary<string, object> cfg = new Dictionary<string, object>();   
        static List<string> new_lines = new List<string>();

        public static string gui_theme;

        public static void Load(string filename)
        {
            var lines = File.ReadAllLines(config_path + filename + ".cfg");

            cfg.Clear();
            form.weapons1.list_sets.Items.Clear();
            form.knife1.list_sets.Items.Clear();
            SkinChanger.weaponKits.Clear();

            foreach (var line in lines)
            {
                if (line.Substring(0, 5) == "[glo]")
                {
                    var kit = getKit(line);
                    SkinChanger.gloveKit = kit;
                    form.knife1.list_sets.Items.AddNewKit(kit, "gloves:");
                }
                if (line.Substring(0, 5) == "[kni]")
                {
                    var kit = getKit(line);
                    SkinChanger.knifeKit = kit;
                    form.knife1.list_sets.Items.AddNewKit(kit, "knife:");
                }
                else if (line.Substring(0, 5) == "[kit]")
                {
                    var kit = getKit(line);
                    SkinChanger.weaponKits.Add(kit);
                    form.weapons1.list_sets.Items.AddNewKit(kit);
                }
                else
                {
                    var key = line.Remove(line.IndexOf("#"));
                    var obj = line.Substring(line.IndexOf("#") + 1);
                    cfg.Add(key, obj);
                }
            }

            // GUI THEME                                     =============================
            if (try_get_var<string>("gui_theme", out gui_theme)) LoadTheme();

            // AIMBOT                                     =============================
            //form.hax1.aim_enabled.Checked                 = get_var<bool>("aimbot_enabled");
            //form.hax1._aim_key                            = get_key("aimbot_key");
            //form.hax1.aim_key.Text                        = get_var<string>("aimbot_key");
            //form.hax1._aim_smooth                         = get_var<float>("aimbot_smooth");

                // TRIGGERBOT                                 =========================
                //form.hax1.trigger_enabled.Checked             = get_var<bool>("trigger_enabled");
                //form.hax1._trigger_key                        = get_key("trigger_key");
                //form.hax1.trigger_key.Text                    = get_var<string>("trigger_key");
                //form.hax1._trigger_delay                      = get_var<int>("trigger_delay");

                // CHAMS                                      ==============================
            form.chams1.chams_enabled.Checked = get_var<bool>("chams_enabled");

            form.chams1.weapon_mcolor_enabled.Checked = get_var<bool>("chams_w_mcolor_enabled");
            form.chams1.sleeves_mcolor_enabled.Checked = get_var<bool>("chams_s_mcolor_enabled");
            form.chams1.gloves_mcolor_enabled.Checked = get_var<bool>("chams_g_mcolor_enabled");

            form.chams1.weapon_wireframe_enabled.Checked = get_var<bool>("chams_w_wirefram_enabled");
            form.chams1.sleeves_wireframe_enabled.Checked = get_var<bool>("chams_s_wirefram_enabled");
            form.chams1.gloves_wireframe_enabled.Checked = get_var<bool>("chams_g_wirefram_enabled");

            form.chams1.colorDialog1_weapon.Color = Color.FromArgb(get_var<int>("chams_w_mcolor"));
            form.chams1.mcolor_weapon.BackColor = Color.FromArgb(get_var<int>("chams_w_mcolor"));
            form.chams1.colorDialog3_sleeves.Color = Color.FromArgb(get_var<int>("chams_s_mcolor"));
            form.chams1.mcolor_sleeves.BackColor = Color.FromArgb(get_var<int>("chams_s_mcolor"));
            form.chams1.colorDialog2_gloves.Color = Color.FromArgb(get_var<int>("chams_g_mcolor"));
            form.chams1.mcolor_gloves.BackColor = Color.FromArgb(get_var<int>("chams_g_mcolor"));

            form.chams1.matlist_weapon.SelectedItem = get_var<string>("chams_w_material");
            form.chams1.matlist_sleeves.SelectedItem = get_var<string>("chams_s_material");
            form.chams1.matlist_gloves.SelectedItem = get_var<string>("chams_g_material");

            form.chams1.alpha_weapon.Value = get_var<int>("chams_w_alpha");
            form.chams1.alpha_weapon_value.Text = Math.Round(form.chams1.alpha_weapon.Value / 255f, 4).ToString();
            form.chams1.alpha_sleeves.Value = get_var<int>("chams_s_alpha");
            form.chams1.alpha_sleeves_value.Text = Math.Round(form.chams1.alpha_gloves.Value / 255f, 4).ToString();
            form.chams1.alpha_gloves.Value = get_var<int>("chams_g_alpha");
            form.chams1.alpha_gloves_value.Text = Math.Round(form.chams1.alpha_sleeves.Value / 255f, 4).ToString();

            SkinChanger.ForceFullUpdate();
        }

        public static void LoadTheme()
        {
            if      (gui_theme == "purple") GuiTheme.PurpleTheme();
            else if (gui_theme == "dark"  ) GuiTheme.DarkTheme  ();
            else if (gui_theme == "random") GuiTheme.RandomTheme();
            else if (gui_theme == "cyan"  ) GuiTheme.CyanTheme  ();
        }

        public static void Save(string filename)
        {
            new_lines.Clear();

            // GUI THEME =============================
            add("gui_theme", gui_theme);

            // AIMBOT =============================
            //add("aimbot_enabled", form.hax1.aim_enabled.Checked);
            //add("aimbot_key", form.hax1._aim_key);
            //add("aimbot_smooth", form.hax1._aim_smooth);

            // TRIGGERBOT =========================
            //add("trigger_enabled", form.hax1.trigger_enabled.Checked);
            //add("trigger_key", form.hax1._trigger_key);
            //add("trigger_delay", form.hax1._trigger_delay);

            // CHAMS ==============================
            add("chams_enabled", form.chams1.chams_enabled.Checked);

            add("chams_w_mcolor_enabled", form.chams1.weapon_mcolor_enabled.Checked);
            add("chams_s_mcolor_enabled", form.chams1.sleeves_mcolor_enabled.Checked);
            add("chams_g_mcolor_enabled", form.chams1.gloves_mcolor_enabled.Checked);

            add("chams_w_wirefram_enabled", form.chams1.weapon_wireframe_enabled.Checked);
            add("chams_s_wirefram_enabled", form.chams1.sleeves_wireframe_enabled.Checked);
            add("chams_g_wirefram_enabled", form.chams1.gloves_wireframe_enabled.Checked);

            add("chams_w_mcolor", form.chams1.colorDialog1_weapon.Color.ToArgb());
            add("chams_s_mcolor", form.chams1.colorDialog3_sleeves.Color.ToArgb());
            add("chams_g_mcolor", form.chams1.colorDialog2_gloves.Color.ToArgb());

            add("chams_w_material", form.chams1.matlist_weapon.SelectedItem);
            add("chams_s_material", form.chams1.matlist_sleeves.SelectedItem);
            add("chams_g_material", form.chams1.matlist_gloves.SelectedItem);

            add("chams_w_alpha", form.chams1.alpha_weapon.Value);
            add("chams_s_alpha", form.chams1.alpha_sleeves.Value);
            add("chams_g_alpha", form.chams1.alpha_gloves.Value);

            if (form.knife1.list_sets.FindString("GLOVES") != -1)
                addKit(SkinChanger.gloveKit, "[glo]");
            if (form.knife1.list_sets.FindString("KNIFE") != -1)
                addKit(SkinChanger.knifeKit, "[kni]");
            foreach (var weaponKit in SkinChanger.weaponKits)
                addKit(weaponKit);

            File.WriteAllLines(config_path + filename + ".cfg", new_lines);

            Refresh();
        }

        public static void Refresh()
        {
            var files = Directory.GetFiles(config_path, "*.cfg");
            var names = new string[files.Length];
            for (var i = 0; i < files.Length; i++)
                names[i] = Path.GetFileNameWithoutExtension(files[i]);

            form.profile1.list_configs.Items.Clear();
            form.profile1.list_configs.Items.AddRange(names);
        }

        public static VirtualKeys get_key(string var_name) 
        { 
            Enum.TryParse<VirtualKeys>(var_name, out var key); 
            return key; 
        }

        public static T get_var<T>(string var_name) => (T)Convert.ChangeType(cfg[var_name], typeof(T));

        public static bool try_get_var<T>(string var_name, out T var)
        {
            if (cfg.ContainsKey(var_name)) 
            {
                var = get_var<T>(var_name);
                return true;
            }
            var = default(T);
            return false;
        }

        public static void add(string key, object value) => new_lines.Add(string.Format($"{key}#{value}"));

        public static void addKit( WeaponKit weaponKit, string tag = "[kit]" ) => 
            new_lines.Add($"{tag}" + $"{weaponKit.skin_id}#" +
                $"{weaponKit.item_index}#{weaponKit.weapon}" +
                $"#{weaponKit.fallback.ToString(CultureInfo.InvariantCulture)}" +
                $"#{weaponKit.stattrack}#{weaponKit.customname}#{weaponKit.seed}#");
        
        public static WeaponKit getKit(string rawKit)
        {
            var infos = rawKit.Remove(0, 5).Split('#');
            return new WeaponKit()
            {
                skin_id    = int.Parse(infos[0]),
                item_index = int.Parse(infos[1]),
                weapon     = infos[2],
                fallback   = float.Parse(infos[3], CultureInfo.InvariantCulture),
                stattrack  = int.Parse(infos[4]),
                customname = infos[5],
                seed       = int.Parse(infos[6])
            };
        }
    }
}


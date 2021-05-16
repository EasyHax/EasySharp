using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static SharpSkin_dll.SkinChanger;

namespace SharpSkin_dll
{
    public partial class weapons : UserControl
    {
        static Dictionary<string, List<(int, string)>> skins_sorted = new Dictionary<string, List<(int, string)>>();

        static bool is_from_allskins_list = false;
        

        public weapons()
        {
            InitializeComponent();

            stattrack_value.KeyPress += Stattrack_value_KeyPress;
            seed_value.KeyPress += Seed_value_KeyPress;
            allskins_list.MouseDown += AllSkins_List_MouseDown;
            skins_list.MouseDown += Skins_List_MouseDown;

            foreach (var skin in DumpSkins.ListAllSkins)
                allskins_list.Items.Add(skin.Item2);

            fallback_value.Text = "10";

            foreach (var paintkit_info in DumpSkins.ListSkins)
            {
                var weapon_type = paintkit_info.type;

                if (!skins_sorted.ContainsKey(weapon_type))
                {
                    var weapon_skins = new List<(int, string)>();

                    foreach (var skin in DumpSkins.ListSkins)
                        if (skin.type == weapon_type)
                        {
                            weapon_skins.Add((skin.kitid, skin.name));
                        }

                    weapon_skins = weapon_skins.OrderBy(x => x.Item2).ToList();
                    skins_sorted.Add(weapon_type, weapon_skins);
                }
            }

            skins_sorted = skins_sorted.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            weapons_list.Items.AddRange(skins_sorted.Keys.ToArray());
        }

        private void Skins_List_MouseDown(object sender, MouseEventArgs e)
        {
            is_from_allskins_list = false;
        }

        private void AllSkins_List_MouseDown(object sender, MouseEventArgs e)
        {
            is_from_allskins_list = true;
        }

        private void Stattrack_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Seed_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((skins_list.SelectedIndex == -1 && allskins_list.SelectedIndex == -1) || weapons_list.SelectedIndex == -1)
                return;

            var skin = allskins_list.Text == string.Empty ? (string)skins_list.SelectedItem : (string)allskins_list.SelectedItem;

            var weaponKit = new WeaponKit()
            {
                customname = custom_name.Text,
                weapon = (string)weapons_list.SelectedItem,
                fallback = Parser.FallBackFromInt(int.Parse(fallback_value.Text)),
                skin_id = DumpSkins.ListAllSkins.Find(x => x.Item2 == (is_from_allskins_list ? (string)allskins_list.SelectedItem : (string)skins_list.SelectedItem)).Item1
            };

            weaponKit.skin_id = is_from_allskins_list
                ? DumpSkins.ListAllSkins[allskins_list.SelectedIndex].Item1
                : skins_sorted[(string)weapons_list.SelectedItem][skins_list.SelectedIndex].Item1;

            weaponKit.item_index = (int)Enum.Parse(typeof(ItemDefinitionIndex), weaponKit.weapon);
            int.TryParse(   stattrack_value.Text, out weaponKit.stattrack  );
            int.TryParse(   seed_value.Text,      out weaponKit.seed       );

            var isAlreadySet = weaponKits.FindIndex(x => x.weapon == weaponKit.weapon);
            if(isAlreadySet != -1)
            {
                weaponKits.RemoveAt(isAlreadySet);
                list_sets.Items.RemoveAt(isAlreadySet);
            }

            weaponKits.Add(weaponKit);
            list_sets.Items.AddNewKit(weaponKit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (list_sets.SelectedIndex == -1) return;

            var index_to_remove = list_sets.SelectedIndex;
            weaponKits.RemoveAt(index_to_remove);
            list_sets.Items.RemoveAt(index_to_remove);
        }

        private void knifes_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            skins_list.Items.Clear();
            skins_list.Text = "";
            skins_list.Items.AddRange(skins_sorted[(string)weapons_list.SelectedItem].Select(x => x.Item2).ToArray());
        }

        private void fallback_Scroll(object sender, EventArgs e)
        {
            fallback_value.Text = (10 - fallback.Value).ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            skins_list.Text = string.Empty;

            allskins_list.BackColor = Color.Green;
            allskins_list.ForeColor = Color.White;

            skins_list.BackColor = Color.DarkGreen;
            skins_list.ForeColor = Color.Black;
            */
        }

        private void skins_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            allskins_list.Text = string.Empty;

            skins_list.BackColor = Color.Green;
            skins_list.ForeColor = Color.White;

            allskins_list.BackColor = Color.DarkGreen;
            allskins_list.ForeColor = Color.Black;
            */
        }

        private void weapons_Load(object sender, EventArgs e)
        {

        }
    }
}

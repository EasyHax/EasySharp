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
    public partial class knife : UserControl
    {
        public Dictionary<string, int> skins = new Dictionary<string, int>() {

                    { "Default",             0   },
                    { "Lore" ,               561 },
                    { "Marble Fade",         413 },
                    { "Crimson Web",         12  },
                    { "Slaughter",           59  },
                    { "Bone Mask",           27  },
                    { "Fade",                38  },
                    { "Night",               40  },
                    { "Blue Steel",          42  },
                    { "Stained",             43  },
                    { "Case Hardened",       44  },
                    { "Boreal Forest",       77  },
                    { "Ultraviolet",         98  },
                    { "Damascus Steel",      410 },
                    { "Tiger Tooth",         409 },
                    { "Doppler Phase 1",     418 },
                    { "Doppler Phase 2",     419 },
                    { "Doppler Phase 3",     421 },
                    { "Doppler Phase 4",     572 },
                    { "Doppler Ruby",        415 },
                    { "Doppler Sapphire",    416 },
                    { "Doppler Blackpearl",  417 },
                    { "Rust Coat",           414 },
                    { "Bright water",        0   },
                    { "Autotronic",          0   }
        };

        static Dictionary<string, List<(int, string)>> skins_sorted = new Dictionary<string, List<(int, string)>>();

        public knife()
        {
            InitializeComponent();

            fallback_value.Text = "10";

            seed_value.KeyPress += Seed_value_KeyPress;
            stat_track.KeyPress += Stattrack_value_KeyPress;

            skins_list.Items.AddRange(skins.Keys.ToArray());

            foreach (var paintkit_info in DumpSkins.ListGloves)
            {
                var glove_type = paintkit_info.type;

                if (!skins_sorted.ContainsKey(glove_type))
                {
                    var glove_skins = new List<(int, string)>();

                    foreach (var skin in DumpSkins.ListGloves)
                        if (skin.type == glove_type)
                        {
                            glove_skins.Add((skin.kitid, skin.name));
                        }

                    glove_skins = glove_skins.OrderBy(x => x.Item2).ToList();
                    skins_sorted.Add(glove_type, glove_skins);
                }
            }

            skins_sorted = skins_sorted.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            gloves_list.Items.AddRange(skins_sorted.Keys.ToArray());
        }

        private void fallback_Scroll(object sender, EventArgs e)
        {
            fallback_value.Text = (10 - fallback.Value).ToString();
        }

        private void Stattrack_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Seed_value_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public int KnifeNameToSkin(string skinname, string knifename)
        {
            if (knifename == "Autotronic")
                switch (knifename)
                {
                    case "BAYONET": return 573;
                    case "FLIP": return 574;
                    case "GUT": return 575;
                    case "KARAMBIT": return 576;
                    case "M9_BAYONET": return 577;
                }
            if (knifename == "Bright water")
                switch (knifename)
                {
                    case "BAYONET": return 578;
                    case "FLIP": return 578;
                    case "GUT": return 578;
                    case "KARAMBIT": return 578;
                    case "M9_BAYONET": return 579;
                }
            if (knifename == "Freehand")
                switch (knifename)
                {
                    case "BAYONET": return 580;
                    case "FLIP": return 580;
                    case "GUT": return 580;
                    case "KARAMBIT": return 582;
                    case "M9_BAYONET": return 581;
                }

            return skins.FirstOrDefault(x => x.Key == skinname).Value;
        }

        private void gloves_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)gloves_list.SelectedItem == "CT_SIDE" || (string)gloves_list.SelectedItem == "T_SIDE")
            {
                if (list_sets.FindString("gloves") != -1)
                    list_sets.Items.RemoveAt(list_sets.FindString("gloves"));

                gloveKit = new WeaponKit() { weapon = (string)gloves_list.SelectedItem, customname = string.Empty };
                list_sets.Items.AddNewKit(gloveKit, "gloves:");
                return;
            }

            gskins_list.Items.Clear();
            gskins_list.Text = "";
            gskins_list.Items.AddRange(skins_sorted[(string)gloves_list.SelectedItem].Select(x => x.Item2).ToArray());
        }

        private void gskins_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            gloveKit.item_index = (int)Enum.Parse(typeof(ItemDefinitionIndex), (string)gloves_list.SelectedItem );
            gloveKit.skin_id = skins_sorted[(string)gloves_list.SelectedItem][gskins_list.SelectedIndex].Item1;
            gloveKit.weapon = (string)gloves_list.SelectedItem;
            gloveKit.fallback = Parser.FallBackFromInt(int.Parse(gfallback_value.Text));

            if (list_sets.FindString("gloves") != - 1)
                list_sets.Items.RemoveAt(list_sets.FindString("gloves"));

            list_sets.Items.AddNewKit(gloveKit, "gloves:");
        }

        private void skins_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skins_list.SelectedIndex == -1 || knifes_list.SelectedIndex == -1)
                return;

            knifeKit.item_index = (int)Enum.Parse(typeof(ItemDefinitionIndex), (string)knifes_list.SelectedItem);
            knifeKit.skin_id = KnifeNameToSkin((string)skins_list.SelectedItem, knifeKit.weapon);
            knifeKit.weapon = (string)knifes_list.SelectedItem;
            knifeKit.fallback = Parser.FallBackFromInt(int.Parse(fallback_value.Text));
            knifeKit.customname = custom_name.Text;

            int.TryParse(stat_track.Text, out knifeKit.stattrack);
            int.TryParse(seed_value.Text, out knifeKit.seed);

            if (list_sets.FindString("knife") != -1)
                list_sets.Items.RemoveAt(list_sets.FindString("knife"));

            list_sets.Items.AddNewKit(knifeKit, "knife:");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            gfallback_value.Text = (10 - gfallback.Value).ToString();
        }

        private void knifes_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            skins_list.Items.Clear();

            if ((string)knifes_list.SelectedItem == "KNIFE_T" || (string)knifes_list.SelectedItem == "KNIFE_CT")
            {
                if (list_sets.FindString("knife") != -1)
                    list_sets.Items.RemoveAt(list_sets.FindString("knife"));

                knifeKit = new WeaponKit() { 
                    weapon = (string)knifes_list.SelectedItem, 
                    customname = custom_name.Text,
                    item_index = (int)Enum.Parse(typeof(ItemDefinitionIndex), (string)knifes_list.SelectedItem)
                };

                list_sets.Items.AddNewKit(knifeKit, "knife:");
                return;
            }

            skins_list.Items.AddRange(skins.Keys.ToArray());
        }
    }
}

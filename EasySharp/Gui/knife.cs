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

        public knife()
        {
            InitializeComponent();

            fallback_value.Text = "10";
            stattrack_value.Text = "0";

            skins_list.Items.AddRange(skins.Keys.ToArray());
        }
        private void fallback_Scroll(object sender, EventArgs e)
        {
            fallback_value.Text = (10 - fallback.Value).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (skins_list.SelectedIndex == -1 || knifes_list.SelectedIndex == -1)
                return;

            var skin = skins_list.SelectedItem;

            var weaponKit = new WeaponKit()
            {
                customname = custom_name.Text,
                weapon = (string)knifes_list.SelectedItem,
                fallback = Parser.FallBackFromInt(int.Parse(fallback_value.Text))
            };

            weaponKit.skin_id = KnifeNameToSkin((string)skins_list.SelectedItem, weaponKit.weapon);
            weaponKit.item_index = (int)Enum.Parse(typeof(ItemDefinitionIndex), weaponKit.weapon);
            int.TryParse(stattrack_value.Text, out weaponKit.stattrack);
            int.TryParse(seed_value.Text, out weaponKit.seed);

            knifeKit = weaponKit;
            if (list_sets.Items.Count > 0) list_sets.Items.RemoveAt(0);
            list_sets.Items.AddNewKit(weaponKit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (list_sets.SelectedIndex == -1) return;

            knifeKit = new WeaponKit();
            list_sets.Items.RemoveAt(0);
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
    }
}

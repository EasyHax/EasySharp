using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpSkin_dll
{
    public partial class hax2 : UserControl
    {
        public hax2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog_allies.ShowDialog() == DialogResult.OK)
                button1.BackColor = colorDialog_allies.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(colorDialog_enemies.ShowDialog() == DialogResult.OK)
                button2.BackColor = colorDialog_enemies.Color;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ally_fromcolor.Checked)
            {
                ally_health_based.Checked = false;
                button1.Enabled = true;
                button1.BackColor = Color.Green;
            }
            else
            {
                ally_health_based.Checked = true;
                button1.Enabled = false;
                button1.BackColor = Color.DimGray;
            }
        }

        private void ally_health_based_CheckedChanged(object sender, EventArgs e)
        {
            if (ally_health_based.Checked)
            {
                ally_fromcolor.Checked = false;
                button1.Enabled = false;
                button1.BackColor = Color.DimGray;
            }
            else
            {
                ally_fromcolor.Checked = true;
                button1.Enabled = true;
                button1.BackColor = Color.Green;
            }
        }

        private void enemy_health_based_CheckedChanged(object sender, EventArgs e)
        {
            if (enemy_health_based.Checked)
            {
                enemy_fromcolor.Checked = false;
                button2.Enabled = false;
                button2.BackColor = Color.DimGray;
            }
            else
            {
                enemy_fromcolor.Checked = true;
                button2.Enabled = true;
                button2.BackColor = Color.Red;
            }
        }

        private void enemy_fromcolor_CheckedChanged(object sender, EventArgs e)
        {
            if (enemy_fromcolor.Checked)
            {
                enemy_health_based.Checked = false;
                button2.Enabled = true;
                button2.BackColor = Color.Red;
            }
            else
            {
                enemy_health_based.Checked = true;
                button2.Enabled = false;
                button2.BackColor = Color.DimGray;
            }
        }

        private void box_CheckedChanged(object sender, EventArgs e)
        {
            if (box.Checked)
            {
                button3.Enabled = true;
                button3.BackColor = Color.Magenta;
            }
            else
            {
                button3.Enabled = false;
                button3.BackColor = Color.DimGray;
            }
        }
    }
}

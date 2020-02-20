using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpSkin_dll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            weapons1.Show();
            knife1.Hide();
            hax1.Hide();
            profile1.Hide();
            hax2.Hide();
            chams1.Hide();

            knife1.skins_list.SelectedItem = "";
            knife1.knifes_list.SelectedItem = "";

            weapons1.skins_list.SelectedItem = "";
            weapons1.weapons_list.SelectedItem = "";

            move.MouseDown += Form1_MouseDown;
            move.MouseMove += Form1_MouseMove;
            move.MouseUp += Form1_MouseUp;

            label3.MouseDown += Label3_MouseDown;
            label2.MouseDown += Label2_MouseDown;
        }

        private void Label2_MouseDown(object sender, MouseEventArgs e)
        {
            SharpSkin.form.Hide();
            SharpSkin.bUnload = true;
        }

        private void Label3_MouseDown(object sender, MouseEventArgs e)
        {
            SharpSkin.form.Hide();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        public void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            weapons1.Show();
            knife1.Hide();
            //hax1.Hide();
            profile1.Hide();
            //hax2.Hide();
            chams1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            weapons1.Hide();
            knife1.Show();
            //hax1.Hide();
            profile1.Hide();
            //hax2.Hide();
            chams1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            weapons1.Hide();
            knife1.Hide();
            //hax1.Show();
            profile1.Hide();
            //hax2.Hide();
            chams1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            weapons1.Hide();
            knife1.Hide();
            //hax1.Hide();
            profile1.Show();
            //hax2.Hide();
            chams1.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            weapons1.Hide();
            knife1.Hide();
            //hax1.Hide();
            profile1.Hide();
            //hax2.Show();
            chams1.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            weapons1.Hide();
            knife1.Hide();
            //hax1.Hide();
            profile1.Hide();
            //hax2.Show();
            chams1.Show();
        }
    }
}

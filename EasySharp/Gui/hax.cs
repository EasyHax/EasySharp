using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Input;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpSkin_dll
{
    unsafe public partial class hax : UserControl
    {
        public VirtualKeys _aim_key = VirtualKeys.V;
        public float _aim_smooth = 0f;

        public VirtualKeys _trigger_key = VirtualKeys.W;
        public int _trigger_delay = 0;

        public hax()
        {
            InitializeComponent();
        }

        private void trigger_key_Click(object sender, EventArgs e)
        {
            var key = PromptKey();
            trigger_key.Text = key.ToString();
            _trigger_key = key;
        }

        public VirtualKeys PromptKey()
        {
            var last_key = (VirtualKeys)0;
            var found_key = false;
            var thread = new Thread(GetKey);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            while (!found_key) { }

            return last_key;

            void GetKey()
            {
                var keys = (VirtualKeys[])Enum.GetValues(typeof(VirtualKeys));

                while (true)
                    foreach (var key in keys)
                    {
                        try
                        {
                            if (WinApi.isKeyDown(key))
                            {
                                found_key = true;
                                last_key = key;
                                return;
                            }
                        }
                        catch { }
                    }
            }
        }

        private void aim_key_Click(object sender, EventArgs e)
        {
            var key = PromptKey();
            aim_key.Text = key.ToString();
            _aim_key = key;
        }

        private void aim_smooth_Scroll(object sender, EventArgs e)
        {
            smooth_value.Text = aim_smooth.Value.ToString();
            _aim_smooth = (10 - aim_smooth.Value) / 10;
        }
    }
}

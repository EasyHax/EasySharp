namespace SharpSkin_dll
{
    partial class hax
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hax));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.aim_enabled = new System.Windows.Forms.CheckBox();
            this.trigger_enabled = new System.Windows.Forms.CheckBox();
            this.aim_smooth = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.smooth_value = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aim_key = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.trigger_key = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aim_smooth)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 87);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "HAX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(25, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "ENABLED";
            // 
            // aim_enabled
            // 
            this.aim_enabled.AutoSize = true;
            this.aim_enabled.Checked = true;
            this.aim_enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aim_enabled.Location = new System.Drawing.Point(10, 35);
            this.aim_enabled.Name = "aim_enabled";
            this.aim_enabled.Size = new System.Drawing.Size(15, 14);
            this.aim_enabled.TabIndex = 13;
            this.aim_enabled.UseVisualStyleBackColor = true;
            // 
            // trigger_enabled
            // 
            this.trigger_enabled.AutoSize = true;
            this.trigger_enabled.Checked = true;
            this.trigger_enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trigger_enabled.Location = new System.Drawing.Point(10, 35);
            this.trigger_enabled.Name = "trigger_enabled";
            this.trigger_enabled.Size = new System.Drawing.Size(15, 14);
            this.trigger_enabled.TabIndex = 14;
            this.trigger_enabled.UseVisualStyleBackColor = true;
            // 
            // aim_smooth
            // 
            this.aim_smooth.Location = new System.Drawing.Point(3, 104);
            this.aim_smooth.Name = "aim_smooth";
            this.aim_smooth.Size = new System.Drawing.Size(77, 45);
            this.aim_smooth.TabIndex = 17;
            this.aim_smooth.TickFrequency = 2;
            this.aim_smooth.Scroll += new System.EventHandler(this.aim_smooth_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.smooth_value);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.aim_key);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.aim_enabled);
            this.panel2.Controls.Add(this.aim_smooth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 260);
            this.panel2.TabIndex = 18;
            // 
            // smooth_value
            // 
            this.smooth_value.AutoSize = true;
            this.smooth_value.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smooth_value.ForeColor = System.Drawing.Color.White;
            this.smooth_value.Location = new System.Drawing.Point(80, 127);
            this.smooth_value.Name = "smooth_value";
            this.smooth_value.Size = new System.Drawing.Size(13, 13);
            this.smooth_value.TabIndex = 23;
            this.smooth_value.Text = "1";
            this.smooth_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(80, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "SMOOTH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "AIM KEY";
            // 
            // aim_key
            // 
            this.aim_key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aim_key.ForeColor = System.Drawing.Color.White;
            this.aim_key.Location = new System.Drawing.Point(10, 75);
            this.aim_key.Name = "aim_key";
            this.aim_key.Size = new System.Drawing.Size(64, 23);
            this.aim_key.TabIndex = 21;
            this.aim_key.Text = "V";
            this.aim_key.UseVisualStyleBackColor = true;
            this.aim_key.Click += new System.EventHandler(this.aim_key_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(293, 29);
            this.panel8.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "AIMBOT";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.trigger_key);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.trigger_enabled);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(293, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 260);
            this.panel3.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(80, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "TRIGGER KEY";
            // 
            // trigger_key
            // 
            this.trigger_key.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trigger_key.ForeColor = System.Drawing.Color.White;
            this.trigger_key.Location = new System.Drawing.Point(10, 75);
            this.trigger_key.Name = "trigger_key";
            this.trigger_key.Size = new System.Drawing.Size(64, 23);
            this.trigger_key.TabIndex = 19;
            this.trigger_key.Text = "W";
            this.trigger_key.UseVisualStyleBackColor = true;
            this.trigger_key.Click += new System.EventHandler(this.trigger_key_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ENABLED";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(293, 29);
            this.panel7.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "TRIGGERBOT";
            // 
            // hax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "hax";
            this.Size = new System.Drawing.Size(586, 347);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aim_smooth)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox aim_enabled;
        public System.Windows.Forms.CheckBox trigger_enabled;
        public System.Windows.Forms.TrackBar aim_smooth;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button trigger_key;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button aim_key;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label smooth_value;
    }
}

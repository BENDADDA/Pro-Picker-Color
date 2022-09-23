namespace WindowsFormsApplication1
{
    partial class PickerColor
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickerColor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_h = new System.Windows.Forms.Label();
            this.label_s = new System.Windows.Forms.Label();
            this.label_l = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hex_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rgb_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(29, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 105);
            this.panel1.TabIndex = 0;
            this.panel1.BackColorChanged += new System.EventHandler(this.panel1_BackColorChanged);
            this.panel1.ForeColorChanged += new System.EventHandler(this.panel1_ForeColorChanged);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(19, 186);
            this.trackBar1.Maximum = 360;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(297, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(19, 251);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(297, 45);
            this.trackBar2.TabIndex = 1;
            this.trackBar2.Value = 100;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(19, 327);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(297, 45);
            this.trackBar3.TabIndex = 1;
            this.trackBar3.Value = 50;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(26, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(26, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Saturation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(26, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lightness";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 12);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            // 
            // label_h
            // 
            this.label_h.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_h.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_h.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_h.Location = new System.Drawing.Point(153, 172);
            this.label_h.Name = "label_h";
            this.label_h.Size = new System.Drawing.Size(34, 15);
            this.label_h.TabIndex = 4;
            this.label_h.Text = "0°";
            this.label_h.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_s
            // 
            this.label_s.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_s.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_s.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_s.Location = new System.Drawing.Point(147, 237);
            this.label_s.Name = "label_s";
            this.label_s.Size = new System.Drawing.Size(46, 15);
            this.label_s.TabIndex = 4;
            this.label_s.Text = "100%";
            this.label_s.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_l
            // 
            this.label_l.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_l.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_l.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_l.Location = new System.Drawing.Point(150, 311);
            this.label_l.Name = "label_l";
            this.label_l.Size = new System.Drawing.Size(40, 15);
            this.label_l.TabIndex = 4;
            this.label_l.Text = "50%";
            this.label_l.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hex_textBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.rgb_textbox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.groupBox2.Location = new System.Drawing.Point(173, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 105);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color Conventor";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // hex_textBox
            // 
            this.hex_textBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hex_textBox.Location = new System.Drawing.Point(17, 76);
            this.hex_textBox.Name = "hex_textBox";
            this.hex_textBox.Size = new System.Drawing.Size(108, 22);
            this.hex_textBox.TabIndex = 8;
            this.hex_textBox.TextChanged += new System.EventHandler(this.label8_Click);
            this.hex_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hex_textBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "HEX";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // rgb_textbox
            // 
            this.rgb_textbox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgb_textbox.Location = new System.Drawing.Point(17, 32);
            this.rgb_textbox.Name = "rgb_textbox";
            this.rgb_textbox.Size = new System.Drawing.Size(108, 22);
            this.rgb_textbox.TabIndex = 8;
            this.rgb_textbox.TextChanged += new System.EventHandler(this.rgb_textbox_TextChanged);
            this.rgb_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rgb_textbox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "RGB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.label10.Location = new System.Drawing.Point(12, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Use this color in our Color Picker";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(31, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 16);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 14);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(134, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(139, 14);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(31, 349);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 16);
            this.panel5.TabIndex = 8;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(265, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Pick";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PickerColor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(333, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_l);
            this.Controls.Add(this.label_s);
            this.Controls.Add(this.label_h);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PickerColor";
            this.Text = "Piker Color";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Form1_ControlAdded);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.QueryAccessibilityHelp += new System.Windows.Forms.QueryAccessibilityHelpEventHandler(this.PickerColor_QueryAccessibilityHelp);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.StyleChanged += new System.EventHandler(this.PickerColor_StyleChanged);
            this.SystemColorsChanged += new System.EventHandler(this.PickerColor_SystemColorsChanged);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.Form1_Validating);
            this.Validated += new System.EventHandler(this.Form1_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_h;
        private System.Windows.Forms.Label label_s;
        private System.Windows.Forms.Label label_l;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox hex_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rgb_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
    }
}


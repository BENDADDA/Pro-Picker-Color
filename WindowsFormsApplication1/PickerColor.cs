using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PickerColor : Form
    {
        public Color ResultC { get; set; }
        private Color thecolor; 
        private Color thehue;
        private Color thescolor;
    
        
       
        public PickerColor()
        {
            InitializeComponent();
                
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void trackBar1_Scroll(object sender, EventArgs e)
        {          
                thecolor=panel1.BackColor = SuperColor.FromAhsl(trackBar1.Value, trackBar2.Value, trackBar3.Value);
                label_h.Text = trackBar1.Value.ToString() + "°";
                thehue = SuperColor.FromAhsl(trackBar1.Value, 100, trackBar3.Value);
                int alpha = (int)(trackBar3.Value * 2.55);
                Color leftcolor = Color.FromArgb(alpha, alpha, alpha);
                BrushColor(panel2, leftcolor,thehue);
                thescolor= SuperColor.FromAhsl(trackBar1.Value,trackBar2.Value);
                BrushColor(panel3, Color.Black, thescolor);
                BrushColor(panel4, thescolor, Color.White);
                rgb_textbox.Text = SuperColor.StringFormTextBox(thecolor, "rgb");
                hex_textBox.Text = SuperColor.StringFormTextBox(thecolor, "hex");
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {

            thecolor = panel1.BackColor = SuperColor.FromAhsl(trackBar1.Value, trackBar2.Value, trackBar3.Value);         
            label_s.Text = trackBar2.Value.ToString() + "%";
            thescolor = SuperColor.FromAhsl(trackBar1.Value, trackBar2.Value);
            BrushColor(panel3, Color.Black, thescolor);
            BrushColor(panel4, thescolor, Color.White);
            rgb_textbox.Text = SuperColor.StringFormTextBox(thecolor, "rgb");
            hex_textBox.Text = SuperColor.StringFormTextBox(thecolor, "hex");
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            thecolor = panel1.BackColor = SuperColor.FromAhsl(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            label_l.Text = trackBar3.Value.ToString() + "%";
            thehue = SuperColor.FromAhsl(trackBar1.Value, 100, trackBar3.Value);
            int alpha = (int)(trackBar3.Value * 2.55);
            Color leftcolor = Color.FromArgb(alpha, alpha, alpha);
            BrushColor(panel2, leftcolor, thehue);
            rgb_textbox.Text = SuperColor.StringFormTextBox(thecolor, "rgb");
            hex_textBox.Text = SuperColor.StringFormTextBox(thecolor, "hex");
        }
        void BrushColor(Panel theNewPanel1, Color left, Color right)
        {
            System.Drawing.Drawing2D.LinearGradientBrush lgb = new System.Drawing.Drawing2D.LinearGradientBrush(theNewPanel1.ClientRectangle, left, right, 0F);
            Graphics g = theNewPanel1.CreateGraphics();
            g.FillRectangle(lgb, theNewPanel1.ClientRectangle);
        }

       

        private void rgb_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                thecolor = panel1.BackColor = SuperColor.ColorFormTextBox(rgb_textbox.Text, "rgb");
                setHslScollbar();
                hex_textBox.Text = SuperColor.StringFormTextBox(thecolor, "hex");
            }
            catch { }
        }
        
        private void hex_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            try
            {
                thecolor=panel1.BackColor = SuperColor.ColorFormTextBox(hex_textBox.Text, "hex");
                setHslScollbar();
                rgb_textbox.Text = SuperColor.StringFormTextBox(thecolor,"rgb");

            }
            catch { }
        }
        void setHslScollbar()
        {
            int r=trackBar1.Value= (int)SuperColor.GetHSLValue(thecolor).hue;
            int g=trackBar2.Value = (int)(SuperColor.GetHSLValue(thecolor).saturation*100);
            int b=trackBar3.Value = (int)(SuperColor.GetHSLValue(thecolor).lightness*100);
            label_l.Text = trackBar3.Value.ToString() + "%";
            label_s.Text = trackBar2.Value.ToString() + "%";
            label_h.Text = trackBar1.Value.ToString() + "°";
            thehue = SuperColor.FromAhsl(trackBar1.Value, 100, trackBar3.Value);
            int alpha = (int)(trackBar3.Value * 2.55);
            Color leftcolor = Color.FromArgb(alpha, alpha, alpha);
            BrushColor(panel2, leftcolor, thehue);
            thescolor = SuperColor.FromAhsl(trackBar1.Value, trackBar2.Value);
            BrushColor(panel3, Color.Black, thescolor);
            BrushColor(panel4, thescolor, Color.White);
        }
        public void StartPickerColor(Color c)
        {
            thecolor = c;
            panel1.BackColor = c;
            setHslScollbar();        
            rgb_textbox.Text = SuperColor.StringFormTextBox(thecolor, "rgb");
            hex_textBox.Text = SuperColor.StringFormTextBox(thecolor, "hex");
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ResultC = thecolor;
            this.DialogResult = DialogResult.OK;
            SettingsApp.Default.TheColor = ResultC;
            SettingsApp.Default.Save();
            this.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Color c = SettingsApp.Default.TheColor;
            StartPickerColor(c);
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       

        private void Form1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        private void Form1_Validated(object sender, EventArgs e)
        {
            
        }

        private void Form1_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {

        }

        private void Form1_ControlAdded(object sender, ControlEventArgs e)
        {

        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {

        }

        private void rgb_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            

        }

        private void PickerColor_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {
           
        }

        private void PickerColor_StyleChanged(object sender, EventArgs e)
        {
           
        }

        private void PickerColor_SystemColorsChanged(object sender, EventArgs e)
        {
      
        }

        private void panel1_ForeColorChanged(object sender, EventArgs e)
        {
           
        }

        private void panel1_BackColorChanged(object sender, EventArgs e)
        {
           
        }
     
      

       
    }
}

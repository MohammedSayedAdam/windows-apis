using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inspire_Task
{
    public partial class SetSolidColor : Form
    {
        private Color clr;
        public SetSolidColor()
        {
            InitializeComponent();
        }

        private void btn_solidcolor_Click(object sender, EventArgs e)
        {
            if(!clr.IsEmpty)
            ChangeBackground.SetColor(clr);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap piexeldata = (Bitmap)pictureBox1.Image;
            clr = piexeldata.GetPixel(e.X, e.Y);
            lbl_SmallScreen.BackColor = clr;
            lbl_RGBValues.Text = "R : " + clr.R.ToString() + " G : " + clr.G.ToString() + " B : " + clr.B.ToString();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap piexeldata = (Bitmap)pictureBox1.Image;
            clr = piexeldata.GetPixel(e.X, e.Y);
            txt_Red.Text = clr.R.ToString();
            txt_Blue.Text = clr.B.ToString();
            txt_Green.Text = clr.G.ToString();
            Pane_SelectedScreen.BackColor = clr;
        }

        private void SetSolidColor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void lbl_SmallScreen_Click(object sender, EventArgs e)
        {

        }
    }
}

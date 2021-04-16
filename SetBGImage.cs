using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Inspire_Task
{
    public partial class SetBGImage : Form
    {
        ChangeBackground cb = new ChangeBackground();
        string filePath;
        public SetBGImage()
        {
            InitializeComponent();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            filePath = cb.Broswe_Image(pictureBox1);
            
        }

        private void btn_setwallpaper_Click(object sender, EventArgs e)
        {
            cb.ChangBGImage();
        }

        private void SetBGImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

       
       
        //RunWait rundll32.exe %SystemRoot%\system32\shell32.dll,Control_RunDLL %SystemRoot%\system32\desk.cpl desk,@Themes /Action:OpenTheme /file:"C:\Windows\Resources\Ease of Access Themes\classic.theme"

       //   [rundll32.exe %SystemRoot%\system32\shell32.dll,Control_RunDLL %SystemRoot%\system32\desk.cpl desk,@Themes /Action:OpenTheme /file:"C:\Windows\Resources\Themes\aero.theme"]
       // Run "C:\Windows\Resources\Ease of Access Themes\classic.theme"
    }
} 

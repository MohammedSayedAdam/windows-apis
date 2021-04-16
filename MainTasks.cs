using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Inspire_Task
{
    public partial class MainTasks : Form
    {
        public MainTasks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new SetBGImage();
            this.Hide();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f1 = new SetSolidColor();
            this.Hide();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("ms-settings:themes");

            //Process process = new Process();
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = @"/C explorer.exe shell:::{ED834ED6-4B5A-4bfe-8F11-A626DCB6A921}";
            ////startInfo.Arguments = @"/C rundll32.exe %SystemRoot%\system32\shell32.dll,Control_RunDLL %SystemRoot%\system32\desk.cpl desk,@Themes";
            //process.StartInfo = startInfo;
            //process.Start();
        }

        private void Show_LockScreen_Click(object sender, EventArgs e)
        {
            Process.Start("ms-settings:lockscreen");
        }
    }
}

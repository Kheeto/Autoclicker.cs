using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoclicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern short GetAsyncState(System.Windows.Forms.Keys vKey);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            MinLMB.Text = "Minimum LMB CPS: " + MinLMBbar.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            MinRMB.Text = "Minimum RMB CPS: " + MinRMBbar.Value;
        }

        private void leftEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if(leftEnabled.Checked)
            {
                LeftClicker.Start();
            }
            else if (!leftEnabled.Checked)
            {
                LeftClicker.Stop();
            }
        }
        private void rightEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (rightEnabled.Checked)
            {
                RightClicker.Start();
            }
            else if (!rightEnabled.Checked)
            {
                RightClicker.Stop();
            }
        }

        private void MaxLMBbar_Scroll(object sender, EventArgs e)
        {
            MaxLMB.Text = "Maximum LMB CPS: " + MaxLMBbar.Value;
        }

        private void MaxRMBbar_Scroll(object sender, EventArgs e)
        {
            MaxRMB.Text = "Maximum RMB CPS: " + MaxRMBbar.Value;
        }

        int minL, maxL, minR, maxR, randomL, randomR;
        private void LeftRandom_Tick(object sender, EventArgs e)
        {
            if(leftEnabled.Checked)
            {
                minL = MinLMBbar.Value;
                maxL = MaxLMBbar.Value;
                Random rand = new Random();
                randomL = rand.Next(minL, maxL);
            }
        }
        private void RightRandom_Tick(object sender, EventArgs e)
        {
            if(rightEnabled.Checked)
            {
                minR = MinRMBbar.Value;
                maxR = MaxRMBbar.Value;
                Random rand = new Random();
                randomR = rand.Next(minR, maxR);
            }
        }

        public string getActiveWindowName()
        {
            try
            {
                var activateHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach(Process clsProcess in processes)
                {
                    if(activateHandle == clsProcess.MainWindowHandle)
                    {
                        return clsProcess.ProcessName;
                    }
                }
            }
            catch { }

            return null;
        }

        IntPtr hWnd;
        string currentWin;
        private async void LeftClicker_Tick(object sender, EventArgs e)
        {
            try
            {
                LeftClicker.Interval = 1000 / randomL;
            } catch { }

            if(leftEnabled.Checked)
            {
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach(Process pr in processes)
                {
                    hWnd = FindWindow(null, pr.MainWindowTitle);
                }

                string currentWindow = getActiveWindowName();
                if (currentWin == null) return;

                if (currentWin.Contains("javaw"))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        PostMessage(hWnd, 0x0201, 0, 0);
                        await Task.Delay(30);
                        PostMessage(hWnd, 0x0201, 0, 0);
                    }
                }
            }
        }

        private void RightClicker_Tick(object sender, EventArgs e)
        {

        }



        private void MaxRMB_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

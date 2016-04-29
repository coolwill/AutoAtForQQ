using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoAtForQQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txt_title.Text = Settings.self.Title;
            txt_prefix.Text = Settings.self.Prefix + "";
            txt_list.Text = Settings.self.Slist;
        }

        private void btn_at20_Click(object sender, EventArgs e)
        {
            doAt(20, false);
        }

        private void btn_at20Rnd_Click(object sender, EventArgs e)
        {
            doAt(20, true);
        }

        private void btn_atAll_Click(object sender, EventArgs e)
        {
            doAt(0, false);
        }

        private void btn_atAllRnd_Click(object sender, EventArgs e)
        {
            doAt(0, true);
        }

        private void txt_title_TextChanged(object sender, EventArgs e)
        {
            Settings.self.Title = txt_title.Text;
            Settings.self.save();
        }

        private void txt_prefix_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Settings.self.Prefix = Int32.Parse(txt_prefix.Text);
            }
            catch (Exception)
            {
                txt_prefix.Text = "6";
            }

            Settings.self.save();
        }

        private void txt_list_TextChanged(object sender, EventArgs e)
        {
            Settings.self.parseList(txt_list.Text);
            Settings.self.save();
        }

        private void txt_list_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        private void doAt(int count, bool random)
        {
            long time1 = DateTime.Now.Ticks;

            List<List<string>> list = Settings.self.getItems(count, random);

            IntPtr windowHandle = FindWindow(null, Settings.self.Title);

            if (windowHandle == IntPtr.Zero)
            {
                MessageBox.Show("目标窗口未在运行.");
                return;
            }
            SetForegroundWindow(windowHandle);

            foreach (List<string> list1 in list)
            {
                foreach(string s in list1)
                {
                    SendKeys.SendWait("@");
                    SendKeys.SendWait(s);
                    SendKeys.SendWait("{ENTER}");
                }
                SendKeys.SendWait("{ENTER}");
            }

            long time2 = DateTime.Now.Ticks;
            lbl_cost.Text = "耗时" + (time2 - time1) / 1000000 / 10D + "秒";

        }
    }
}

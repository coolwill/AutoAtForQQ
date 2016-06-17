using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoAtForQQ
{
    public partial class Form1 : Form
    {
        private bool enableEvent = false;

        public Form1()
        {
            InitializeComponent();

            initContent();

            this.enableEvent = true;
        }

        private void initContent()
        {
            txt_count.Text = Settings.self.count + "";
            if (Settings.self.random)
            {
                radio_random.Checked = true;
            }
            else
            {
                radio_order.Checked = true;
            }

            chk_shuffle.Checked = Settings.self.shuffle;
            txt_prefix.Text = Settings.self.prefix + "";
            chk_autosend.Checked = Settings.self.autoSend;

            foreach (Profile profile in Settings.self.profiles)
            {
                combo_profile.Items.Add(profile.getDisplayName());
            }
            combo_profile.SelectedIndex = 0;
            txt_title.Text = Settings.self.currentProfile.title;
            txt_list.Text = Settings.self.currentProfile.slist;
        }

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        private void doAt(List<List<string>> list)
        {
            prog_time.Maximum = (list.Count - 1) * 20 + (list[list.Count - 1].Count);
            prog_time.Value = 0;

            IntPtr windowHandle = FindWindow(null, Settings.self.currentProfile.title);
            if (windowHandle == IntPtr.Zero)
            {
                MessageBox.Show("目标窗口未在运行.");
                return;
            }
            SetForegroundWindow(windowHandle);

            int i = 0;
            foreach (List<string> list1 in list)
            {
                foreach (string s in list1)
                {
                    SendKeys.SendWait("@");
                    SendKeys.SendWait(s);
                    SendKeys.SendWait("{ENTER}");
                    prog_time.Value += 1;
                }

                if (!Settings.self.autoSend && ++i == list.Count)
                {
                    break;
                }
                SendKeys.SendWait("{ENTER}");
            }
        }

        private void btn_top20_Click(object sender, EventArgs e)
        {
            List<List<string>> list = Settings.self.currentProfile.getItems(20, false, false);
            doAt(list);
        }

        private void btn_rand20_Click(object sender, EventArgs e)
        {
            List<List<string>> list = Settings.self.currentProfile.getItems(20, true, false);
            doAt(list);
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            List<List<string>> list = Settings.self.currentProfile.getItems(1000, false, false);
            doAt(list);
        }

        private void btn_at_Click(object sender, EventArgs e)
        {
            List<List<string>> list = Settings.self.currentProfile.getItems(Settings.self.count, Settings.self.random, Settings.self.shuffle);
            doAt(list);
        }

        private void txt_count_TextChanged(object sender, EventArgs e)
        {
            if (!enableEvent) return;

            try
            {
                Settings.self.count = Int32.Parse(txt_count.Text);
            }
            catch (Exception)
            {
                enableEvent = false;
                txt_count.Text = "20";
                enableEvent = true;
            }

            Settings.self.save();
        }

        private void radio_order_CheckedChanged(object sender, EventArgs e)
        {
            if (!enableEvent) return;

            Settings.self.random = false;
            Settings.self.save();
        }

        private void radio_random_CheckedChanged(object sender, EventArgs e)
        {
            if (!enableEvent) return;

            Settings.self.random = true;
            Settings.self.save();
        }

        private void chk_shuffle_CheckedChanged(object sender, EventArgs e)
        {
            if (!enableEvent) return;

            Settings.self.shuffle = chk_shuffle.Checked;
            Settings.self.save();
        }

        private void txt_prefix_TextChanged(object sender, EventArgs e)
        {
            if (!enableEvent) return;

            try
            {
                Settings.self.prefix = Int32.Parse(txt_prefix.Text);
            }
            catch (Exception)
            {
                enableEvent = false;
                txt_prefix.Text = "6";
                enableEvent = true;
            }

            Settings.self.save();
        }

        private void chk_autosend_CheckedChanged(object sender, EventArgs e)
        {
            if (!enableEvent) return;

            Settings.self.autoSend = chk_autosend.Checked;
            Settings.self.save();
        }

        private void combo_profile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!enableEvent) return;

            Profile profile = Settings.self.selectProfile(combo_profile.SelectedIndex);
            
            enableEvent = false;
            txt_title.Text = profile.title;
            txt_list.Text = profile.slist;
            enableEvent = true;
        }

        private void txt_title_TextChanged(object sender, EventArgs e)
        {
            if (!enableEvent) return;

            this.enableEvent = false;
            Settings.self.currentProfile.title = txt_title.Text;
            Settings.self.save();

            int index = combo_profile.SelectedIndex;
            combo_profile.Items.Insert(index, Settings.self.currentProfile.getDisplayName());
            combo_profile.Items.RemoveAt(index + 1);
            combo_profile.SelectedIndex = index;

            this.enableEvent = true;
        }

        private void txt_list_TextChanged(object sender, EventArgs e)
        {
            if (!enableEvent) return;

            this.enableEvent = false;
            Settings.self.currentProfile.slist = txt_list.Text;
            Settings.self.currentProfile.parseList();
            Settings.self.save();

            int index = combo_profile.SelectedIndex;
            combo_profile.Items.Insert(index, Settings.self.currentProfile.getDisplayName());
            combo_profile.Items.RemoveAt(index+1);
            combo_profile.SelectedIndex = index;

            this.enableEvent = true;
        }

        private void btn_addProfile_Click(object sender, EventArgs e)
        {
            if (!enableEvent) return;

            this.enableEvent = false;
            Profile profile = Settings.self.addProfile();
            Settings.self.save();

            combo_profile.Items.Add(profile.getDisplayName());
            combo_profile.SelectedIndex = combo_profile.Items.Count - 1;
            txt_title.Text = profile.title;
            txt_list.Text = profile.slist;

            this.enableEvent = true;
        }

        private void btn_removeProfile_Click(object sender, EventArgs e)
        {
            if (!enableEvent) return;

            this.enableEvent = false;
            Profile profile = Settings.self.removeProfile();
            Settings.self.save();

            combo_profile.Items.RemoveAt(combo_profile.SelectedIndex);
            if (combo_profile.Items.Count == 0)
            {
                combo_profile.Items.Add(profile.getDisplayName());
            }
            combo_profile.SelectedIndex = 0;
            txt_title.Text = profile.title;
            txt_list.Text = profile.slist;

            this.enableEvent = true;
        }

        private void link_about_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/wholeworm/AutoAtForQQ");
        }
    }
}

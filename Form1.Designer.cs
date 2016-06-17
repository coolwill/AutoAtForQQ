namespace AutoAtForQQ
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_top20 = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.prog_time = new System.Windows.Forms.ProgressBar();
            this.link_about = new System.Windows.Forms.LinkLabel();
            this.group_filter = new System.Windows.Forms.GroupBox();
            this.chk_shuffle = new System.Windows.Forms.CheckBox();
            this.lbl_limit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_random = new System.Windows.Forms.RadioButton();
            this.radio_order = new System.Windows.Forms.RadioButton();
            this.btn_at = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.group_quickAt = new System.Windows.Forms.GroupBox();
            this.btn_rand20 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.group_settings = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_prefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_autosend = new System.Windows.Forms.CheckBox();
            this.group_profile = new System.Windows.Forms.GroupBox();
            this.btn_removeProfile = new System.Windows.Forms.Button();
            this.btn_addProfile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_list = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.combo_profile = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.group_filter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.group_quickAt.SuspendLayout();
            this.group_settings.SuspendLayout();
            this.group_profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_top20
            // 
            this.btn_top20.Location = new System.Drawing.Point(6, 15);
            this.btn_top20.Name = "btn_top20";
            this.btn_top20.Size = new System.Drawing.Size(75, 23);
            this.btn_top20.TabIndex = 0;
            this.btn_top20.Text = "@前20个";
            this.btn_top20.UseVisualStyleBackColor = true;
            this.btn_top20.Click += new System.EventHandler(this.btn_top20_Click);
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(6, 73);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(75, 23);
            this.btn_all.TabIndex = 2;
            this.btn_all.Text = "@全体";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.prog_time);
            this.splitContainer1.Panel1.Controls.Add(this.link_about);
            this.splitContainer1.Panel1.Controls.Add(this.group_filter);
            this.splitContainer1.Panel1.Controls.Add(this.group_quickAt);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.group_settings);
            this.splitContainer1.Panel2.Controls.Add(this.group_profile);
            this.splitContainer1.Size = new System.Drawing.Size(332, 320);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.TabIndex = 3;
            // 
            // prog_time
            // 
            this.prog_time.Location = new System.Drawing.Point(5, 276);
            this.prog_time.Name = "prog_time";
            this.prog_time.Size = new System.Drawing.Size(139, 3);
            this.prog_time.TabIndex = 17;
            // 
            // link_about
            // 
            this.link_about.AutoSize = true;
            this.link_about.Location = new System.Drawing.Point(122, 300);
            this.link_about.Name = "link_about";
            this.link_about.Size = new System.Drawing.Size(29, 12);
            this.link_about.TabIndex = 16;
            this.link_about.TabStop = true;
            this.link_about.Text = "关于";
            this.link_about.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_about_LinkClicked);
            // 
            // group_filter
            // 
            this.group_filter.Controls.Add(this.chk_shuffle);
            this.group_filter.Controls.Add(this.lbl_limit);
            this.group_filter.Controls.Add(this.groupBox1);
            this.group_filter.Controls.Add(this.btn_at);
            this.group_filter.Controls.Add(this.label1);
            this.group_filter.Controls.Add(this.txt_count);
            this.group_filter.Location = new System.Drawing.Point(5, 120);
            this.group_filter.Name = "group_filter";
            this.group_filter.Size = new System.Drawing.Size(139, 153);
            this.group_filter.TabIndex = 10;
            this.group_filter.TabStop = false;
            this.group_filter.Text = "按照指定条件选取";
            // 
            // chk_shuffle
            // 
            this.chk_shuffle.AutoSize = true;
            this.chk_shuffle.Location = new System.Drawing.Point(9, 102);
            this.chk_shuffle.Name = "chk_shuffle";
            this.chk_shuffle.Size = new System.Drawing.Size(96, 16);
            this.chk_shuffle.TabIndex = 15;
            this.chk_shuffle.Text = "打乱选取结果";
            this.chk_shuffle.UseVisualStyleBackColor = true;
            this.chk_shuffle.CheckedChanged += new System.EventHandler(this.chk_shuffle_CheckedChanged);
            // 
            // lbl_limit
            // 
            this.lbl_limit.AutoSize = true;
            this.lbl_limit.Location = new System.Drawing.Point(98, 23);
            this.lbl_limit.Name = "lbl_limit";
            this.lbl_limit.Size = new System.Drawing.Size(35, 12);
            this.lbl_limit.TabIndex = 14;
            this.lbl_limit.Text = "(1-0)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_random);
            this.groupBox1.Controls.Add(this.radio_order);
            this.groupBox1.Location = new System.Drawing.Point(7, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 54);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // radio_random
            // 
            this.radio_random.AutoSize = true;
            this.radio_random.Location = new System.Drawing.Point(6, 33);
            this.radio_random.Name = "radio_random";
            this.radio_random.Size = new System.Drawing.Size(71, 16);
            this.radio_random.TabIndex = 1;
            this.radio_random.Text = "随机选取";
            this.radio_random.UseVisualStyleBackColor = true;
            this.radio_random.CheckedChanged += new System.EventHandler(this.radio_random_CheckedChanged);
            // 
            // radio_order
            // 
            this.radio_order.AutoSize = true;
            this.radio_order.Checked = true;
            this.radio_order.Location = new System.Drawing.Point(6, 11);
            this.radio_order.Name = "radio_order";
            this.radio_order.Size = new System.Drawing.Size(71, 16);
            this.radio_order.TabIndex = 0;
            this.radio_order.TabStop = true;
            this.radio_order.Text = "顺序选取";
            this.radio_order.UseVisualStyleBackColor = true;
            this.radio_order.CheckedChanged += new System.EventHandler(this.radio_order_CheckedChanged);
            // 
            // btn_at
            // 
            this.btn_at.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_at.Location = new System.Drawing.Point(38, 124);
            this.btn_at.Name = "btn_at";
            this.btn_at.Size = new System.Drawing.Size(67, 23);
            this.btn_at.TabIndex = 3;
            this.btn_at.Text = "开始艾特";
            this.btn_at.UseVisualStyleBackColor = true;
            this.btn_at.Click += new System.EventHandler(this.btn_at_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "总人数";
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(54, 17);
            this.txt_count.MaxLength = 4;
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(38, 21);
            this.txt_count.TabIndex = 4;
            this.txt_count.Text = "20";
            this.txt_count.TextChanged += new System.EventHandler(this.txt_count_TextChanged);
            // 
            // group_quickAt
            // 
            this.group_quickAt.Controls.Add(this.btn_rand20);
            this.group_quickAt.Controls.Add(this.btn_top20);
            this.group_quickAt.Controls.Add(this.btn_all);
            this.group_quickAt.Location = new System.Drawing.Point(5, 12);
            this.group_quickAt.Name = "group_quickAt";
            this.group_quickAt.Size = new System.Drawing.Size(139, 102);
            this.group_quickAt.TabIndex = 9;
            this.group_quickAt.TabStop = false;
            this.group_quickAt.Text = "快速艾特";
            // 
            // btn_rand20
            // 
            this.btn_rand20.Location = new System.Drawing.Point(6, 44);
            this.btn_rand20.Name = "btn_rand20";
            this.btn_rand20.Size = new System.Drawing.Size(75, 23);
            this.btn_rand20.TabIndex = 4;
            this.btn_rand20.Text = "@随机20个";
            this.btn_rand20.UseVisualStyleBackColor = true;
            this.btn_rand20.Click += new System.EventHandler(this.btn_rand20_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "made by:极好耶教主";
            // 
            // group_settings
            // 
            this.group_settings.Controls.Add(this.label2);
            this.group_settings.Controls.Add(this.txt_prefix);
            this.group_settings.Controls.Add(this.label3);
            this.group_settings.Controls.Add(this.chk_autosend);
            this.group_settings.Location = new System.Drawing.Point(5, 12);
            this.group_settings.Name = "group_settings";
            this.group_settings.Size = new System.Drawing.Size(159, 67);
            this.group_settings.TabIndex = 15;
            this.group_settings.TabStop = false;
            this.group_settings.Text = "设定";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "仅输入前";
            // 
            // txt_prefix
            // 
            this.txt_prefix.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_prefix.Location = new System.Drawing.Point(65, 14);
            this.txt_prefix.MaxLength = 1;
            this.txt_prefix.Name = "txt_prefix";
            this.txt_prefix.Size = new System.Drawing.Size(26, 21);
            this.txt_prefix.TabIndex = 4;
            this.txt_prefix.Text = "6";
            this.txt_prefix.TextChanged += new System.EventHandler(this.txt_prefix_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "个数字";
            // 
            // chk_autosend
            // 
            this.chk_autosend.AutoSize = true;
            this.chk_autosend.Location = new System.Drawing.Point(6, 41);
            this.chk_autosend.Name = "chk_autosend";
            this.chk_autosend.Size = new System.Drawing.Size(132, 16);
            this.chk_autosend.TabIndex = 12;
            this.chk_autosend.Text = "艾特完毕后直接发送";
            this.chk_autosend.UseVisualStyleBackColor = true;
            this.chk_autosend.CheckedChanged += new System.EventHandler(this.chk_autosend_CheckedChanged);
            // 
            // group_profile
            // 
            this.group_profile.Controls.Add(this.btn_removeProfile);
            this.group_profile.Controls.Add(this.btn_addProfile);
            this.group_profile.Controls.Add(this.label5);
            this.group_profile.Controls.Add(this.txt_list);
            this.group_profile.Controls.Add(this.label6);
            this.group_profile.Controls.Add(this.txt_title);
            this.group_profile.Controls.Add(this.combo_profile);
            this.group_profile.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.group_profile.Location = new System.Drawing.Point(5, 85);
            this.group_profile.Name = "group_profile";
            this.group_profile.Size = new System.Drawing.Size(159, 227);
            this.group_profile.TabIndex = 14;
            this.group_profile.TabStop = false;
            this.group_profile.Text = "配置文件";
            // 
            // btn_removeProfile
            // 
            this.btn_removeProfile.Location = new System.Drawing.Point(60, 20);
            this.btn_removeProfile.Name = "btn_removeProfile";
            this.btn_removeProfile.Size = new System.Drawing.Size(48, 23);
            this.btn_removeProfile.TabIndex = 14;
            this.btn_removeProfile.Text = "删除";
            this.btn_removeProfile.UseVisualStyleBackColor = true;
            this.btn_removeProfile.Click += new System.EventHandler(this.btn_removeProfile_Click);
            // 
            // btn_addProfile
            // 
            this.btn_addProfile.Location = new System.Drawing.Point(6, 20);
            this.btn_addProfile.Name = "btn_addProfile";
            this.btn_addProfile.Size = new System.Drawing.Size(48, 23);
            this.btn_addProfile.TabIndex = 13;
            this.btn_addProfile.Text = "增加";
            this.btn_addProfile.UseVisualStyleBackColor = true;
            this.btn_addProfile.Click += new System.EventHandler(this.btn_addProfile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "QQ号列表";
            // 
            // txt_list
            // 
            this.txt_list.Location = new System.Drawing.Point(6, 127);
            this.txt_list.Multiline = true;
            this.txt_list.Name = "txt_list";
            this.txt_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_list.Size = new System.Drawing.Size(146, 94);
            this.txt_list.TabIndex = 11;
            this.txt_list.TextChanged += new System.EventHandler(this.txt_list_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "窗口标题";
            // 
            // txt_title
            // 
            this.txt_title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_title.Location = new System.Drawing.Point(6, 88);
            this.txt_title.MaxLength = 50;
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(144, 21);
            this.txt_title.TabIndex = 8;
            this.txt_title.TextChanged += new System.EventHandler(this.txt_title_TextChanged);
            // 
            // combo_profile
            // 
            this.combo_profile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_profile.FormattingEnabled = true;
            this.combo_profile.Location = new System.Drawing.Point(6, 49);
            this.combo_profile.Name = "combo_profile";
            this.combo_profile.Size = new System.Drawing.Size(144, 20);
            this.combo_profile.TabIndex = 10;
            this.combo_profile.SelectedIndexChanged += new System.EventHandler(this.combo_profile_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 320);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "QQ群大召唤术";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.group_filter.ResumeLayout(false);
            this.group_filter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group_quickAt.ResumeLayout(false);
            this.group_settings.ResumeLayout(false);
            this.group_settings.PerformLayout();
            this.group_profile.ResumeLayout(false);
            this.group_profile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_top20;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_prefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_autosend;
        private System.Windows.Forms.ComboBox combo_profile;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Button btn_at;
        private System.Windows.Forms.GroupBox group_settings;
        private System.Windows.Forms.GroupBox group_profile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_random;
        private System.Windows.Forms.RadioButton radio_order;
        private System.Windows.Forms.GroupBox group_quickAt;
        private System.Windows.Forms.GroupBox group_filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_rand20;
        private System.Windows.Forms.LinkLabel link_about;
        private System.Windows.Forms.Label lbl_limit;
        private System.Windows.Forms.CheckBox chk_shuffle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_list;
        private System.Windows.Forms.Button btn_addProfile;
        private System.Windows.Forms.Button btn_removeProfile;
        private System.Windows.Forms.ProgressBar prog_time;
    }
}


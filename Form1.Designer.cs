namespace _8Mi_MCAriaPlus
{
    partial class Form_MCAriaPlus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MCAriaPlus));
            this.Label_ProjectGroup = new System.Windows.Forms.Label();
            this.ComboBox_ProjectGroup = new System.Windows.Forms.ComboBox();
            this.Label_ProjectName = new System.Windows.Forms.Label();
            this.ComboBox_ProjectName = new System.Windows.Forms.ComboBox();
            this.Label_Folder = new System.Windows.Forms.Label();
            this.TextBox_SaveFolder = new System.Windows.Forms.TextBox();
            this.Tips = new System.Windows.Forms.ToolTip(this.components);
            this.TextBox_FileName = new System.Windows.Forms.TextBox();
            this.CheckBox_AutoWriteName = new System.Windows.Forms.CheckBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.Label_AppStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.Label_DownloadSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.Button_Download = new System.Windows.Forms.ToolStripStatusLabel();
            this.Label_File = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu_Main = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Languages = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Language_zhCN = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Language_enUS = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StatusStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_ProjectGroup
            // 
            this.Label_ProjectGroup.AutoSize = true;
            this.Label_ProjectGroup.Location = new System.Drawing.Point(12, 32);
            this.Label_ProjectGroup.Name = "Label_ProjectGroup";
            this.Label_ProjectGroup.Size = new System.Drawing.Size(65, 12);
            this.Label_ProjectGroup.TabIndex = 0;
            this.Label_ProjectGroup.Text = "项目组/名:";
            this.Label_ProjectGroup.Click += new System.EventHandler(this.Label_ProjectGroup_Click);
            // 
            // ComboBox_ProjectGroup
            // 
            this.ComboBox_ProjectGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_ProjectGroup.FormattingEnabled = true;
            this.ComboBox_ProjectGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_ProjectGroup.Location = new System.Drawing.Point(113, 29);
            this.ComboBox_ProjectGroup.Name = "ComboBox_ProjectGroup";
            this.ComboBox_ProjectGroup.Size = new System.Drawing.Size(164, 20);
            this.ComboBox_ProjectGroup.TabIndex = 1;
            this.Tips.SetToolTip(this.ComboBox_ProjectGroup, "开头带有SG;PG就代表这是个组");
            this.ComboBox_ProjectGroup.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ProjectGroup_SelectedIndexChanged);
            // 
            // Label_ProjectName
            // 
            this.Label_ProjectName.AutoSize = true;
            this.Label_ProjectName.Location = new System.Drawing.Point(12, 57);
            this.Label_ProjectName.Name = "Label_ProjectName";
            this.Label_ProjectName.Size = new System.Drawing.Size(101, 12);
            this.Label_ProjectName.TabIndex = 0;
            this.Label_ProjectName.Text = "项目名/适用版本:";
            // 
            // ComboBox_ProjectName
            // 
            this.ComboBox_ProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_ProjectName.FormattingEnabled = true;
            this.ComboBox_ProjectName.Location = new System.Drawing.Point(113, 54);
            this.ComboBox_ProjectName.Name = "ComboBox_ProjectName";
            this.ComboBox_ProjectName.Size = new System.Drawing.Size(164, 20);
            this.ComboBox_ProjectName.TabIndex = 1;
            this.Tips.SetToolTip(this.ComboBox_ProjectName, "一般显示插件名称或插件适用的服务端类型与(或)版本");
            this.ComboBox_ProjectName.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ProjectName_SelectedIndexChanged);
            // 
            // Label_Folder
            // 
            this.Label_Folder.AutoSize = true;
            this.Label_Folder.Location = new System.Drawing.Point(12, 82);
            this.Label_Folder.Name = "Label_Folder";
            this.Label_Folder.Size = new System.Drawing.Size(83, 12);
            this.Label_Folder.TabIndex = 2;
            this.Label_Folder.Text = "文件保存路径:";
            // 
            // TextBox_SaveFolder
            // 
            this.TextBox_SaveFolder.Location = new System.Drawing.Point(113, 79);
            this.TextBox_SaveFolder.Name = "TextBox_SaveFolder";
            this.TextBox_SaveFolder.Size = new System.Drawing.Size(326, 21);
            this.TextBox_SaveFolder.TabIndex = 3;
            this.Tips.SetToolTip(this.TextBox_SaveFolder, "插件保存在哪个文件夹?");
            this.TextBox_SaveFolder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextBox_SaveFloder_MouseUp);
            // 
            // Tips
            // 
            this.Tips.ToolTipTitle = "8Mi-MCAriaPlus\'s Help:";
            // 
            // TextBox_FileName
            // 
            this.TextBox_FileName.Location = new System.Drawing.Point(113, 105);
            this.TextBox_FileName.Name = "TextBox_FileName";
            this.TextBox_FileName.Size = new System.Drawing.Size(248, 21);
            this.TextBox_FileName.TabIndex = 3;
            this.Tips.SetToolTip(this.TextBox_FileName, "一般按默认或者自动更名的格式,如需手动更改文件名请取消自动更名.");
            // 
            // CheckBox_AutoWriteName
            // 
            this.CheckBox_AutoWriteName.AutoSize = true;
            this.CheckBox_AutoWriteName.Location = new System.Drawing.Point(367, 107);
            this.CheckBox_AutoWriteName.Name = "CheckBox_AutoWriteName";
            this.CheckBox_AutoWriteName.Size = new System.Drawing.Size(72, 16);
            this.CheckBox_AutoWriteName.TabIndex = 5;
            this.CheckBox_AutoWriteName.Text = "自动更名";
            this.Tips.SetToolTip(this.CheckBox_AutoWriteName, "开启:按程序内置格式更改文件名.\r\n取消:按下载地址提供的文件名.");
            this.CheckBox_AutoWriteName.UseVisualStyleBackColor = true;
            this.CheckBox_AutoWriteName.CheckedChanged += new System.EventHandler(this.CheckBox_AutoWriteName_CheckedChanged);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Label_AppStatus,
            this.Label_DownloadSpeed,
            this.ProgressBar,
            this.Button_Download});
            this.StatusStrip.Location = new System.Drawing.Point(0, 131);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(451, 26);
            this.StatusStrip.TabIndex = 4;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // Label_AppStatus
            // 
            this.Label_AppStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.Label_AppStatus.Name = "Label_AppStatus";
            this.Label_AppStatus.Size = new System.Drawing.Size(111, 21);
            this.Label_AppStatus.Text = "程序状态: 当前空闲";
            // 
            // Label_DownloadSpeed
            // 
            this.Label_DownloadSpeed.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.Label_DownloadSpeed.Name = "Label_DownloadSpeed";
            this.Label_DownloadSpeed.Size = new System.Drawing.Size(101, 21);
            this.Label_DownloadSpeed.Text = "下载速度: 0 KB/s";
            // 
            // ProgressBar
            // 
            this.ProgressBar.AutoToolTip = true;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 20);
            this.ProgressBar.Step = 1;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // Button_Download
            // 
            this.Button_Download.BackColor = System.Drawing.Color.White;
            this.Button_Download.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Button_Download.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.Button_Download.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.Button_Download.Name = "Button_Download";
            this.Button_Download.Size = new System.Drawing.Size(60, 21);
            this.Button_Download.Text = "点击下载";
            this.Button_Download.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Download_MouseDown);
            this.Button_Download.MouseEnter += new System.EventHandler(this.Button_Download_MouseEnter);
            this.Button_Download.MouseLeave += new System.EventHandler(this.Button_Download_MouseLeave);
            this.Button_Download.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Download_MouseUp);
            // 
            // Label_File
            // 
            this.Label_File.AutoSize = true;
            this.Label_File.Location = new System.Drawing.Point(12, 107);
            this.Label_File.Name = "Label_File";
            this.Label_File.Size = new System.Drawing.Size(95, 12);
            this.Label_File.TabIndex = 2;
            this.Label_File.Text = "文件名称(.jar):";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Main,
            this.Menu_Languages});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(451, 25);
            this.MenuStrip.TabIndex = 7;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // Menu_Main
            // 
            this.Menu_Main.Name = "Menu_Main";
            this.Menu_Main.Size = new System.Drawing.Size(60, 21);
            this.Menu_Main.Text = "操作(&C)";
            // 
            // Menu_Languages
            // 
            this.Menu_Languages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Language_zhCN,
            this.Menu_Language_enUS});
            this.Menu_Languages.Name = "Menu_Languages";
            this.Menu_Languages.Size = new System.Drawing.Size(58, 21);
            this.Menu_Languages.Text = "语言(&L)";
            // 
            // Menu_Language_zhCN
            // 
            this.Menu_Language_zhCN.Checked = true;
            this.Menu_Language_zhCN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Menu_Language_zhCN.Name = "Menu_Language_zhCN";
            this.Menu_Language_zhCN.Size = new System.Drawing.Size(141, 22);
            this.Menu_Language_zhCN.Text = "中文(简体)";
            // 
            // Menu_Language_enUS
            // 
            this.Menu_Language_enUS.Name = "Menu_Language_enUS";
            this.Menu_Language_enUS.Size = new System.Drawing.Size(141, 22);
            this.Menu_Language_enUS.Text = "&English(US)";
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Name = "ContextMenuStrip";
            this.ContextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // Form_MCAriaPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 157);
            this.Controls.Add(this.CheckBox_AutoWriteName);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.TextBox_FileName);
            this.Controls.Add(this.Label_File);
            this.Controls.Add(this.TextBox_SaveFolder);
            this.Controls.Add(this.Label_Folder);
            this.Controls.Add(this.ComboBox_ProjectName);
            this.Controls.Add(this.ComboBox_ProjectGroup);
            this.Controls.Add(this.Label_ProjectName);
            this.Controls.Add(this.Label_ProjectGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form_MCAriaPlus";
            this.Text = "8Mi-MCAriaPlus";
            this.Load += new System.EventHandler(this.Form_MCAriaPlus_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_ProjectGroup;
        private System.Windows.Forms.ComboBox ComboBox_ProjectGroup;
        private System.Windows.Forms.Label Label_ProjectName;
        private System.Windows.Forms.ComboBox ComboBox_ProjectName;
        private System.Windows.Forms.Label Label_Folder;
        private System.Windows.Forms.TextBox TextBox_SaveFolder;
        private System.Windows.Forms.ToolTip Tips;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel Label_AppStatus;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel Label_DownloadSpeed;
        private System.Windows.Forms.Label Label_File;
        private System.Windows.Forms.TextBox TextBox_FileName;
        private System.Windows.Forms.CheckBox CheckBox_AutoWriteName;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Menu_Main;
        private System.Windows.Forms.ToolStripMenuItem Menu_Languages;
        private System.Windows.Forms.ToolStripMenuItem Menu_Language_zhCN;
        private System.Windows.Forms.ToolStripMenuItem Menu_Language_enUS;
        private new System.Windows.Forms.ContextMenuStrip ContextMenuStrip;
        private System.Windows.Forms.ToolStripStatusLabel Button_Download;
    }
}


using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Diagnostics;

namespace _8Mi_MCAriaPlus
{
    public partial class Form_MCAriaPlus : Form
    {
        public Form_MCAriaPlus()
        {
            InitializeComponent();
        }


        private void Form_MCAriaPlus_Load(object sender, EventArgs e)
        {
            //E:程序集变量 名称 ProjectGroup 类型 文本型_数组 数组 0
            //C#:忘了..
            ComboBox_ProjectGroup.Items.AddRange("PG-Via;PG-Vle;PG-AuthMe;PG-BentoBoxWorld;P-LuckPerms;P-PlotSquared;P-FastAsyncWorldEdit;S-Mohist;S-Paper;S-BungeeCord;S-Waterfall;S-Travertine;SG-OneKeyDownload".Split(';'));
            //C#:string[] 文本数组变量="文本".Split('用作分割的文本');<前面有 string[] 是直接生成一个变量>
            //E: 文本数组变量 = 分割文本("文本","用作分割的文本",)

            //Environment.GetFolderPath(Environment.SpecialFolder.);

            string dlpath = null;
            Program.SHGetKnownFolderPath(new Guid("374DE290-123F-4565-9164-39C4925E467B"), 0, IntPtr.Zero, ref dlpath);
            TextBox_SaveFolder.Text=dlpath;
        }
        private void shadiao_command()
        {

            MessageBox.Show("你是不是触发了 以勒 写的 C#沙雕代码库集 ?"+ Environment.NewLine + " Application By 8Mi_Yile, Thanks for Mr.lv", "8Mi-MCAriaPlus", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //一般来讲如果在C#要对一个文本执行操作的时候 可以
            //文本变量.xxx指令()
            //"文本字符".xxx指令()

            //C#:MessageBox.Show("内容","窗口标题",MessageBoxButtons.按钮值,MessageBoxIcon.图标值);
            //E:信息框("内容",#按钮值 + #图标值,"窗口标题")
            //E+黑月界面模块:<窗口类>.信息框("内容",#按钮值 + #图标值,"窗口标题")

            //C#: "文本".ToLower();
            //E: 到小写("文本")
        }
        public static void AppendToArray<T>(ref T[] array, T[] data)
        {
            T[] result = new T[array.Length + data.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }
            for (int i = array.Length; i < array.Length + data.Length; i++)
            {
                result[i] = data[i - array.Length];
            }
            array = result;
        }
        public static void AppendToArray<T>(ref T[] array, T data)
        {
            T[] result = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i];
            }
            result[array.Length] = data;
            array = result;
        }
        public static void setEnabledforAllComponents(Control c,bool e)
        {
            foreach(Control i in c.Controls)
                i.Enabled=e;
        }
        private void ComboBox_ProjectGroup_SelectedIndexChanged(object sender, EventArgs e){
            setEnabledforAllComponents(this,false);
            ComboBox_ProjectName.Items.Clear();
            Program.FileName = "";
            TextBox_FileName.Text  = "";
            All_Boxs_Enabled_Check(false, -1);
            new Thread(()=> {
                var JSON = new JObject();
                switch (ComboBox_ProjectGroup.Text)
                {
                    case ("PG-Via"):
                        //Thread.Sleep(1000);
                        JSON = JObject.Parse(readHtml("https://ci.viaversion.com/api/json"));
                        foreach (var Name in JSON["jobs"])
                            if (Name["name"].ToString().StartsWith("Via"))
                                ComboBox_ProjectName.Items.Add(Name["name"]);
                        break;
                    case ("P-LuckPerms"):
                        JSON = JObject.Parse(readHtml("https://ci.lucko.me/job/LuckPerms/lastSuccessfulBuild/api/json"));
                        foreach (var Name in JSON["artifacts"])
                            ComboBox_ProjectName.Items.Add(SplitMavenFile(Name["fileName"].ToString())[1]);
                        break;
                    case ("PG-AuthMe"):
                        JSON = JObject.Parse(readHtml("https://ci.codemc.org/job/AuthMe/api/json"));
                        break;
                    case ("PG-BentoBoxWorld"):
                        JSON = JObject.Parse(readHtml("https://ci.codemc.org/job/BentoBoxWorld/api/json"));
                        foreach (var Name in JSON["jobs"])
                            ComboBox_ProjectName.Items.Add(Name["name"]);
                        break;
                    case ("P-PlotSquared"):
                        JSON = JObject.Parse(readHtml("https://ci.athion.net/job/PlotSquared-Breaking/lastSuccessfulBuild/api/json"));
                        break;
                    case ("P-FastAsyncWorldEdit"):
                        JSON = JObject.Parse(readHtml(""));
                        break;
                    case ("S-Mohist"):
                        JSON = JObject.Parse(readHtml("https://ci.codemc.io/job/Mohist-Community/api/json"));
                        foreach (var Name in JSON["jobs"])
                            ComboBox_ProjectName.Items.Add(Name["name"]);
                        break;
                    case ("S-Paper"):
                        JSON = JObject.Parse(readHtml("https://papermc.io/api/v1/paper/"));
                        foreach (var Name in JSON["versions"])
                            ComboBox_ProjectName.Items.Add(Name.ToString());
                        break;
                    case ("S-BungeeCord"):
                        JSON = JObject.Parse(readHtml("https://ci.md-5.net/job/BungeeCord/lastSuccessfulBuild/api/json"));
                        foreach (var Name in JSON["artifacts"])
                            ComboBox_ProjectName.Items.Add(Name["fileName"]);
                        break;
                    case ("S-Waterfall"):
                        JSON = JObject.Parse(readHtml("https://papermc.io/ci/job/Waterfall/lastSuccessfulBuild/api/json"));
                        foreach (var Name in JSON["artifacts"])
                            ComboBox_ProjectName.Items.Add(Name["fileName"]);
                        break;
                    case ("S-Travertine"):
                        JSON = JObject.Parse(readHtml("https://papermc.io/ci/job/Travertine/lastSuccessfulBuild/api/json"));
                        foreach (var Name in JSON["artifacts"])
                            ComboBox_ProjectName.Items.Add(Name["fileName"]);
                        break;
                    case ("SG-OneKeyDownload"):
                        ComboBox_ProjectName.Items.AddRange("BungeeCord;Waterfall;Travertine;Paper-1.12;Paper-1.13;Paper-1.14".Split(';'));
                        break;
                }
                All_Boxs_Enabled_Check(true, 0);
                if (ComboBox_ProjectName.Items.Count > 0)
                    ComboBox_ProjectName.SelectedIndex = 0;
                GetProjectBranch();
                setEnabledforAllComponents(this, true);
            }).Start();
            
        }

        private void TextBox_SaveFloder_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                FolderBrowserDialog temp = new FolderBrowserDialog();
                //temp.Title = "8Mi-MCAriaPlus:选择保存位置";
                //temp.CheckPathExists = true;
                //temp.AddExtension = true;
                //temp.AutoUpgradeEnabled = true;
                //temp.Filter = "Java文件(*.jar)|*.jar";
                temp.ShowDialog();
                if (temp.SelectedPath!="")
                {
                    TextBox_SaveFolder.Text = temp.SelectedPath;
                }
            }
        }
        public static String readHtml(String url){
            return System.Text.Encoding.UTF8.GetString(new WebClient().DownloadData(url));
            /*HttpWebRequest a = (HttpWebRequest)WebRequest.Create(url);
            a.Accept = "text/html";
            a.Method = "GET";
            HttpWebResponse b = (HttpWebResponse)a.GetResponse();
            Stream s = b.GetResponseStream();
            StreamReader r = new StreamReader(s, System.Text.Encoding.UTF8);
            return r.ReadToEnd();*/
        }
        private void All_Boxs_Enabled_Check(bool TrueOrFalse, int StatusID)
        {
            switch (StatusID){
                case (0):
                    Label_AppStatus.Text = "程序状态: 当前空闲";
                    break;
                case (-1):
                    Label_AppStatus.Text = "程序状态: 正在加载";
                    break;
                case (1):
                    Label_AppStatus.Text = "程序状态: 正在下载";
                    break;
            }
            Button_Download.Enabled = TrueOrFalse;
            foreach (Control Boxs in this.Controls)
            {
                Boxs.Enabled = TrueOrFalse;
            }
            StatusStrip.Enabled = Label_AppStatus.Enabled = Label_DownloadSpeed.Enabled = ProgressBar.Enabled = true;
        }
        private void Button_Download_MouseLeave(object sender, EventArgs e)
        {
            Button_Download.BackColor=System.Drawing.Color.White;
            Button_Download.BorderStyle = Border3DStyle.Raised;
        }
        private void Button_Download_MouseEnter(object sender, EventArgs e)
        {
            Button_Download.BackColor = System.Drawing.Color.LightGray;
        }
        private void Button_Download_MouseDown(object sender, MouseEventArgs e)
        {
            Button_Download.BorderStyle = Border3DStyle.Sunken;
        }
        private void Button_Download_MouseUp(object sender, MouseEventArgs e)
        {
            All_Boxs_Enabled_Check(false, 1);
            setEnabledforAllComponents(this,false);
            Button_Download.BorderStyle = Border3DStyle.Raised;
            new Thread(()=> {
                WebClient WDNMD_WC = new WebClient();
                Stopwatch awawa = new Stopwatch();
               
                WDNMD_WC.DownloadProgressChanged += (a,b) => {
                    ProgressBar.Value = b.ProgressPercentage;
                    Label_DownloadSpeed.Text = "下载速度: "+Math.Round(b.BytesReceived/(double)(awawa.ElapsedMilliseconds/(double)1000))+" bytes/s";
                };
                awawa.Start();
                WDNMD_WC.DownloadFileAsync(new Uri(Program.DownloadLink), TextBox_SaveFolder.Text + "\\" + TextBox_FileName.Text);
                while (WDNMD_WC.IsBusy)
                {
                    setEnabledforAllComponents(this, false);
                    Thread.Sleep(1);
                }
                MessageBox.Show("下载完毕!~","8Mi-MCAriaPlus",MessageBoxButtons.OK,MessageBoxIcon.Information);
                All_Boxs_Enabled_Check(true, 0);
                ProgressBar.Value = 0;
                Label_DownloadSpeed.Text = "下载速度: 0 KB/s";
                setEnabledforAllComponents(this,true);
            }).Start();
             
        }
        private void ComboBox_ProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProjectBranch();
        }
        private void GetProjectBranch()
        {
            setEnabledforAllComponents(this,false);
            Program.FileName = "";
            TextBox_FileName.Text = "";
            All_Boxs_Enabled_Check(false, -1);
            new Thread(()=> {
                var JSON = new JObject();
                switch (ComboBox_ProjectGroup.Text)
                {
                    case ("PG-Via"):
                        JSON = JObject.Parse(readHtml("https://ci.viaversion.com/job/" + ComboBox_ProjectName.Text + "/lastSuccessfulBuild/api/json"));
                        Program.DownloadLink = "https://ci.viaversion.com/job/" + ComboBox_ProjectName.Text + "/lastSuccessfulBuild/artifact/" + JSON["artifacts"][0]["relativePath"];
                        Program.FileName = JSON["artifacts"][0]["fileName"].ToString();
                        break;
                    case ("P-LuckPerms"):
                        JSON = JObject.Parse(readHtml("https://ci.lucko.me/job/LuckPerms/lastSuccessfulBuild/api/json"));
                        Program.DownloadLink = "https://ci.lucko.me/job/LuckPerms/lastSuccessfulBuild/artifact/" + JSON["artifacts"][ComboBox_ProjectName.SelectedIndex]["relativePath"];
                        Program.FileName = JSON["artifacts"][ComboBox_ProjectName.SelectedIndex]["fileName"].ToString();
                        break;
                    case ("PG-BentoBoxWorld"):
                        JSON = JObject.Parse(readHtml("https://ci.codemc.org/job/BentoBoxWorld/job/" + ComboBox_ProjectName.Text + "/lastSuccessfulBuild/api/json"));
                        Program.DownloadLink = "https://ci.codemc.org/job/BentoBoxWorld/job/" + ComboBox_ProjectName.Text + "/lastSuccessfulBuild/artifact/" + JSON["artifacts"].Last["relativePath"];
                        Program.FileName = JSON["artifacts"].Last["fileName"].ToString();
                        break;
                    case ("S-Paper"):
                        JSON = JObject.Parse(readHtml("https://papermc.io/api/v1/paper/" + ComboBox_ProjectName.Text + "/latest"));
                        Program.DownloadLink = "https://papermc.io/api/v1/paper/" + ComboBox_ProjectName.Text + "/latest/download";
                        Program.FileName = "paper"+"-"+JSON["build"].ToString()+".jar";
                        break;
                    case ("S-Travertine"):
                        JSON = JObject.Parse(readHtml("https://papermc.io/ci/job/Travertine/lastSuccessfulBuild/api/json"));
                        Program.DownloadLink = "https://papermc.io/ci/job/Travertine/lastSuccessfulBuild/artifact/" + JSON["artifacts"][ComboBox_ProjectName.SelectedIndex]["relativePath"];
                        Program.FileName = JSON["artifacts"][ComboBox_ProjectName.SelectedIndex]["fileName"].ToString();
                        break;
                    case ("S-Waterfall"):
                        JSON = JObject.Parse(readHtml("https://papermc.io/ci/job/Waterfall/lastSuccessfulBuild/api/json"));
                        Program.DownloadLink = "https://papermc.io/ci/job/Waterfall/lastSuccessfulBuild/artifact/" + JSON["artifacts"][ComboBox_ProjectName.SelectedIndex]["relativePath"];
                        Program.FileName = JSON["artifacts"][ComboBox_ProjectName.SelectedIndex]["fileName"].ToString();
                        break;
                    case ("S-Mohist"):
                        JSON = JObject.Parse(readHtml("https://ci.codemc.org/job/Mohist-Community/job/" + ComboBox_ProjectName.Text + "/lastSuccessfulBuild/api/json"));
                        Program.DownloadLink = "https://ci.codemc.org/job/Mohist-Community/job/" + ComboBox_ProjectName.Text + "/lastSuccessfulBuild/artifact/" + JSON["artifacts"].Last["relativePath"];
                        Program.FileName = JSON["artifacts"].Last["fileName"].ToString();
                        break;
                    case ("S-BungeeCord"):
                        JSON = JObject.Parse(readHtml("https://ci.md-5.net/job/BungeeCord//lastSuccessfulBuild/api/json"));
                        Program.DownloadLink = "https://ci.md-5.net/job/BungeeCord//lastSuccessfulBuild/artifact/" + JSON["artifacts"][ComboBox_ProjectName.SelectedIndex]["relativePath"];
                        Program.FileName = JSON["artifacts"][ComboBox_ProjectName.SelectedIndex]["fileName"].ToString();
                        break;
                }
                AutoChangeName();
                All_Boxs_Enabled_Check(true, 0);
                setEnabledforAllComponents(this, true);
            }).Start();
            
        }
        private void CheckBox_AutoWriteName_CheckedChanged(object sender, EventArgs e)
        {
            AutoChangeName();
        }
        private void AutoChangeName(){
            if (CheckBox_AutoWriteName.Checked)
            {
                var ProjectGroupName=ComboBox_ProjectGroup.Text.Split('-');
                if (ProjectGroupName[0] == "PG")
                {
                    TextBox_FileName.Text = ComboBox_ProjectName.Text+".jar";
                }
                else if (ProjectGroupName[0] == "SG")
                {
                    TextBox_FileName.Text = ComboBox_ProjectName.Text+".jar";
                }
                else if(ProjectGroupName[0] == "S")
                {
                    TextBox_FileName.Text = ComboBox_ProjectName.Text + ".jar";
                }
                else
                {
                    TextBox_FileName.Text = ProjectGroupName[1] + "-"+ComboBox_ProjectName.Text+".jar";
                }
            }
            else
            {
                TextBox_FileName.Text = Program.FileName;
            }
        }

        public static String GetStringMiddle(String s, String left, String right)
        {
            if (!s.Contains(left))
                throw new ArgumentException("left cannot be found in the source string.");
            if (!s.Substring(s.IndexOf(left) + left.Length).Contains(right))
                throw new ArgumentException("right cannot be found in the source string.");
            return s.Substring(s.IndexOf(left) + left.Length, s.Substring(s.IndexOf(left) + left.Length).IndexOf(right) + right.Length - (s.IndexOf(left) + left.Length));
        }
        public static String[] SplitMavenFile(String s)
        {
            String[] ret = new String[3];
            ret[0] = s.Substring(0, s.IndexOf("-"));
            ret[1] = s.Substring(s.IndexOf("-") + 1, s.LastIndexOf("-") - ret[0].Length - 1);
            ret[2] = s.Substring(s.LastIndexOf("-") + 1, s.LastIndexOf(".jar") - (ret[0].Length + ret[1].Length) - 2);
            return ret;
        }

        private void Label_ProjectGroup_Click(object sender, EventArgs e)
        {
    
        }
    }
}

using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;

namespace _8Mi_MCAriaPlus
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        public static String DownloadLink="";
        public static String FileName = "";
        [DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true, EntryPoint = "SHGetKnownFolderPath")]
        public static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, ref string pszPath);
        [STAThread]
        static void Main()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3
                                      | SecurityProtocolType.Tls
                                      | (SecurityProtocolType)0x300 //Tls11
                                      | (SecurityProtocolType)0xC00; //Tls12
            Control.CheckForIllegalCrossThreadCalls = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_MCAriaPlus());
        }
    }
}

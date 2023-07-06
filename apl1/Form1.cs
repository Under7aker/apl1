using System.Data;
using Microsoft.Win32;
using System;

using System.Diagnostics;
using System.Windows.Forms;


namespace apl1
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            regkey.SetValue("sShortDate", "MM/yyyy/d");
            
            //Process.Start("explorer.exe", "/n /r ");
           
            KillExplorerProcess();
        }
        private void KillExplorerProcess()
        {
            Process[] explorerProcesses = Process.GetProcessesByName("explorer");
            foreach (Process process in explorerProcesses)
            {
                process.Kill();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            regkey.SetValue("sShortDate", "d/MM/yyyy");
            //  regkey.SetValue("sLongDate", "dddd,MMMMM d,yyyy ");
            KillExplorerProcess();


        }
    }
}

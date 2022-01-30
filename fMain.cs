using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserEnhanced
{
    public partial class fMain : Form
    {

        string appName = "MagazinesRobot.exe";
        string BrowserFeatureKey32 = @"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION";
        string BrowserFeatureKey64 = @"SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION";
        string BrowserFeatureKey = "";

        public fMain()
        {
            InitializeComponent();

            //判斷作業系統
            BrowserFeatureKey = (Environment.Is64BitOperatingSystem) ?
                BrowserFeatureKey64 : BrowserFeatureKey32;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            using (RegistryKey Key = Registry.LocalMachine.OpenSubKey(BrowserFeatureKey, false))
            {
                //先檢查值是否存在，並變換相對應的按鈕狀態
                object val = Key.GetValue(appName);

                btnREG.Enabled = (string.IsNullOrEmpty(val?.ToString()));
                btnUnreg.Enabled = !(btnREG.Enabled);
            }
        }

        private void btnREG_Click(object sender, EventArgs e)
        {
            //註冊機碼，用以改變 WebBrowser 的 UserAgent 字串
            //appName = Process.GetCurrentProcess().MainModule.ModuleName;

            Registry.LocalMachine.OpenSubKey(BrowserFeatureKey, true).
                SetValue(appName, 11000, RegistryValueKind.DWord);

            MessageBox.Show("註冊成功。");
            
            btnREG.Enabled = false;
            btnUnreg.Enabled = true;
        }

        private void btnUnreg_Click(object sender, EventArgs e)
        {
            //刪除註冊的機碼
            Registry.LocalMachine.OpenSubKey(BrowserFeatureKey, true).
                DeleteValue(appName, false);

            MessageBox.Show("清除完成。");

            btnREG.Enabled = true;
            btnUnreg.Enabled = false;
        }
    }
}

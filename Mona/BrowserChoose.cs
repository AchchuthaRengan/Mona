using ComponentFactory.Krypton.Toolkit;
using Microsoft.Win32;
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

namespace Mona
{
    public partial class BrowserChoose : KryptonForm
    {
        public BrowserChoose()
        {
            InitializeComponent();            
        }

        public static bool checkInstalled(string c_name)
        {
            string displayName;

            string registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key != null)
            {
                foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    displayName = subkey.GetValue("DisplayName") as string;
                    if (displayName != null && displayName.Contains(c_name))
                    {
                        return true;
                    }
                }
                key.Close();
            }

            registryKey = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key != null)
            {
                foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    displayName = subkey.GetValue("DisplayName") as string;
                    if (displayName != null && displayName.Contains(c_name))
                    {
                        return true;
                    }
                }
                key.Close();
            }
            return false;
        }

        private void btnchrome_Click(object sender, EventArgs e)
        {
            if (checkInstalled("Chrome"))
            {
                BrowserPassword browserPassword = new BrowserPassword();
                browserPassword.ShowDialog();
            }
            else
            {
                MessageBox.Show("You don't have chrome browser installed on your machine", "Error");
            }
        }

        private void btnMozilla_Click(object sender, EventArgs e)
        {
            if (checkInstalled("Firefox"))
            {
                FirefoxPasswords firefox = new FirefoxPasswords();
                firefox.ShowDialog();
            }
            else
            {
                MessageBox.Show("You don't have firefox browser installed on your machine", "Error");
            }
        }
    }    
}

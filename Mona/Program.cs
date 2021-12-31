using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Mona
{
    static class Program
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ///<summary/>
            ///For Running Only On Single Instance
            ///<summary/>
            bool createdNew = true;
            using (Mutex mutex = new Mutex(true, "Mona", out createdNew))
            {
                if (createdNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    if (condition() == true)
                    {
                        Application.Run(new Mona());
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    Process current = Process.GetCurrentProcess();
                    foreach (Process process in Process.GetProcessesByName(current.ProcessName))
                    {
                        if (process.Id != current.Id)
                        {
                            SetForegroundWindow(process.MainWindowHandle);
                            break;
                        }
                    }
                }
            }

        }
        static bool condition()
        {
            using (var signIn = new SignIn())
            {
                switch (signIn.ShowDialog())
                {
                    case DialogResult.OK:
                        return true;
                    default:                        
                        return false;
                }
            }
        }
    }
}

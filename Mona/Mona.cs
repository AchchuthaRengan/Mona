using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using BLL;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using ComponentFactory.Krypton.Toolkit;
using System.Net;
using DBLL;
using System.Media;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using Org.BouncyCastle.Asn1.Ocsp;

namespace Mona
{
    public partial class Mona : KryptonForm
    {
        PasswordService obj = new PasswordService();
        DataTable dt;
        public Mona()
        {
            InitializeComponent();                   
            dt = obj.PasswordDetails();            
            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.Columns[3].Visible = false;            
            KryptonDataGridViewButtonColumn copy = (KryptonDataGridViewButtonColumn)kryptonDataGridView1.Columns["Copy"];
            KryptonDataGridViewButtonColumn edit = (KryptonDataGridViewButtonColumn)kryptonDataGridView1.Columns["Edit"];
            KryptonDataGridViewButtonColumn delete = (KryptonDataGridViewButtonColumn)kryptonDataGridView1.Columns["Delete"];
            copy.ButtonStyle = ButtonStyle.ButtonSpec;
            copy.Text = "Copy";            
            copy.CellTemplate.Style.ForeColor = Color.White;
            edit.ButtonStyle = ButtonStyle.ButtonSpec;
            edit.Text = "Edit";
            edit.CellTemplate.Style.BackColor = Color.Teal;
            edit.CellTemplate.Style.ForeColor = Color.White;
            delete.ButtonStyle = ButtonStyle.ButtonSpec;
            delete.Text = "Delete";
            delete.CellTemplate.Style.BackColor = Color.Teal;
            delete.CellTemplate.Style.ForeColor = Color.White;
            notifyIcon1.BalloonTipTitle = "Mona Here!";
            notifyIcon1.BalloonTipText = "Just running in the Background!";
            notifyIcon1.Text = "Mona";            
            notifyIcon1.ContextMenuStrip = new ContextMenuStrip();
            notifyIcon1.ContextMenuStrip.Items.Add("Add New Password", null, btnaddPass_Click);
            notifyIcon1.ContextMenuStrip.Items.Add("Encrypt File", null, btnLockOpt_Click);
            notifyIcon1.ContextMenuStrip.Items.Add("Log Out",null,btnLogOut_Click_1);
            kryptonDataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.Closing += OnClosing;
        }                
        private void GetPasswordFromDatabase()
        {
            PasswordService passService = new PasswordService();
            DataTable dt = passService.PasswordDetails();
            kryptonDataGridView1.DataSource = dt;            
        }
        
        private void F3_UpdateEventHandler1(object sender, NewPassword.UpdateEventArgs args)
        {
            try
            {
                PasswordService passservice = new PasswordService();
                DataTable dt = passservice.PasswordDetails();
                if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
                {
                    kryptonDataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data Found..! Add Some Passwords","Oops!");
                }
            }    
            catch(Exception ex)
            {
                MessageBox.Show("Sorry This Occurred => " + ex.Message + "NODATAONDB","Sorry");
            }
        }
                        
        private void kryptonDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                e.Value = new string('•', e.Value.ToString().Length);
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 6 && e.Value != null)
            {
                e.Value = new string('•', e.Value.ToString().Length);
                e.FormattingApplied = true;
            }
        }
        
        private void btnaddPass_Click(object sender, EventArgs e)
        {
            NewPassword obj = new NewPassword();
            obj.UpdateEventHandler += F3_UpdateEventHandler1;
            obj.ShowDialog();            
        }
        
        private void btnBroswerPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Close All Browsers Before Choosing the Browser, Or else I cannot access the data","Warning");
            if(checkInstance() == true)
            {
                BrowserChoose browserChoose = new BrowserChoose();
                browserChoose.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Close All Browsers and Try Again","Oops!");
            }
            
        }

        private bool checkInstance()
        {
            var RunningProcessPaths = ProcessFileNameFinderClass.GetAllRunningProcessFilePaths();

            if (RunningProcessPaths.Contains("firefox.exe"))
            {
                MessageBox.Show("Firefox Browser Was Detected As Open",
              "Oops",
              MessageBoxButtons.OK,
              MessageBoxIcon.None);
                return false;
            }

            if (RunningProcessPaths.Contains("chrome.exe"))
            {
                MessageBox.Show("Google Chrome Browser Was Detected As Open",
                "Oops",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
                return false;
            }
            return true;
        }

        private void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (kryptonDataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
                    {
                        try
                        {
                            int passwordId = Convert.ToInt32(kryptonDataGridView1.Rows[e.RowIndex].Cells["PasswordId"].Value);
                            if (passwordId >= 0)
                            {
                                if (MessageBox.Show("Are You Sure.. You want to delete this password?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    Password password = new Password(passwordId);
                                    PasswordService passwordService = new PasswordService();
                                    string result = passwordService.DeletePassword(password);
                                    if (result.Equals("1"))
                                    {
                                        MessageBox.Show("Password Deleted ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Something Went Wrong","Sorry");
                                    }
                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Sorry... this Happened => "+ex.Message);
                        }
                        
                    }
                    else if (kryptonDataGridView1.Columns[e.ColumnIndex].HeaderText == "Copy")
                    {
                        try
                        {
                            Clipboard.Clear();
                            int passwordId = Convert.ToInt32(kryptonDataGridView1.Rows[e.RowIndex].Cells["PasswordId"].Value);
                            if(passwordId != 0)
                            {
                                PasswordService passService = new PasswordService();

                                DataTable dt = passService.DisplayForUpdatePassword(passwordId);
                                DataRow row = dt.Rows[0];
                                string realPassword = passService.getPassword(CurrentUser.Email, passwordId);
                                Clipboard.SetText(realPassword);
                                MessageBox.Show(kryptonDataGridView1.Rows[e.RowIndex].Cells["EmailorUsername"].Value.ToString() + " Password Copied.","Copied!");
                                string website = kryptonDataGridView1.Rows[e.RowIndex].Cells["Url"].Value.ToString();
                                System.Diagnostics.Process.Start(website);
                            }
                            else
                            {
                                MessageBox.Show("Something Went Wrong - PWDIDNOTFOUND", "Sorry");
                            }
                            
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Sorry.. this Happened => " + ex.Message+"Sorry");
                        }
                        
                    }
                    if (kryptonDataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit")
                    {
                        try
                        {
                            int passwordId = Convert.ToInt32(kryptonDataGridView1.Rows[e.RowIndex].Cells["PasswordId"].Value);
                            if (passwordId != 0)
                            {
                                if (kryptonDataGridView1.Rows.Count > 0)
                                {
                                    UpdatePassword updatepassword = new UpdatePassword();
                                    updatepassword.PasswordId = passwordId;
                                    PasswordService passwordService2 = new PasswordService();
                                    DataTable dt = passwordService2.PasswordDetails();
                                    if (dt.Rows.Count > 0)
                                    {
                                        kryptonDataGridView1.DataSource = dt;
                                        updatepassword.ShowDialog();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Something Went Wrong - UPDPWDNODATA","Sorry");
                                    }

                                }
                            }
                            else
                            {
                                MessageBox.Show("Something Went Wrong","Oops");
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Sorry.. this Happened => " + ex.Message,"Sorry");
                        }
                        
                    }
                }
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry.. this Happened => " + ex.Message + "\nERRONDGV","Sorry");
            }
            
        }

        private void Mona_Activated(object sender, EventArgs e)
        {
            GetPasswordFromDatabase();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            Mona___My_Account mona___My_Account = new Mona___My_Account();
            mona___My_Account.ShowDialog();
        }

        private void btnLockOpt_Click(object sender, EventArgs e)
        {
            FileLock fileLock = new FileLock();
            fileLock.ShowDialog();
        }

        private void kryptonDataGridView1_Paint(object sender, PaintEventArgs e)
        {
            if (kryptonDataGridView1.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "Seems Nothing in Here right? \n Add Some Passwords by [Add New] Button",
                    new Font("QuickSand", 20), kryptonDataGridView1.ClientRectangle,
                    Color.FromArgb(255,255,255), Color.FromArgb(13,35,43),
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);            
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection sqlcon = new SQLServerConnection().Connect();
            sqlcon.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select PasswordId,EmailorUsername,Password,ConfirmPassword,Url,DateOfRegistration from Password where EmailorUsername like '" + txtSearch.Text + "%' and UserId = '" + CurrentUser.UserId + "'", sqlcon);
            dt = new DataTable();
            adapt.Fill(dt);
            kryptonDataGridView1.DataSource = dt;
            kryptonDataGridView1.Columns[3].Visible = false;
            sqlcon.Close();
        }
                  
        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            logOut();            
        }

        private void logOut()
        {
            if (MessageBox.Show("Are you sure... You want to Log Out?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {                
                notifyIcon1.Visible = false;
                notifyIcon1.Dispose();
                MessageBox.Show("Logging Out will close this application","Warning");
                this.Close();
                Application.Exit();
            }
        }
                
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();      
            WindowState = FormWindowState.Normal;
            this.Activate();
            this.Focus();           
        }

        private void Mona_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void OnClosing(object sender, CancelEventArgs cancelEventArgs)
        {
            string msg = "Closing this will Log you Out. Still want to close?";
            DialogResult result = MessageBox.Show(msg, "Close Confirmation",
                MessageBoxButtons.OK/*Cancel*/, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                cancelEventArgs.Cancel = false;
            }                                            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About___Mona about___Mona = new About___Mona();
            about___Mona.ShowDialog();
        }
    }   
}

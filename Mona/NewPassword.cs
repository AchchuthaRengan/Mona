using BLL;
using BO;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mona
{
    public partial class NewPassword : KryptonForm
    {        
        public NewPassword()
        {            
            InitializeComponent();
        }
        
        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void raiseUpdate()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler?.Invoke(this, args);
        }
        
        private bool IsValid()
        {
            if (txtUsername.Text.Trim() == string.Empty && txtCnfmPassword.Text.Trim() == string.Empty && txtPassword.Text.Trim() == string.Empty && txtUrl.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Boxes eh..? Fill your Credentials!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }
            else if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Email/Username", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Password", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            else if (txtUrl.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter URL", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUrl.Focus();
                return false;
            }
            else if (txtUsername.Text.Length > 25)
            {
                MessageBox.Show("Please Enter Under 25 characters", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }
            else if (!txtPassword.Text.Equals(txtCnfmPassword.Text))
            {
                MessageBox.Show("Password and confirm-password do not match", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCnfmPassword.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtUrl.Text, @"[(http(s)?):\/\/(www\.)?a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Please Enter a Valid URL", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUrl.Focus();
                return false;
            }
            return true;
        }

        private void btnAddPass_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string pass = txtPassword.Text;
                string confirm_password = txtCnfmPassword.Text;
                string url = txtUrl.Text;
                DateTime DateOfCreation = dateTimePicker1.Value;
                if (IsValid())
                {
                    Password password = new Password(username, pass, confirm_password, url, DateOfCreation);
                    PasswordService passwordService = new PasswordService();
                    string result = passwordService.InsertPassword(password);
                    raiseUpdate();
                    if(result.Equals("1"))
                    {
                        MessageBox.Show("Password Added!","Success");
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtCnfmPassword.Clear();
                        txtUrl.Clear();
                        this.Close();
                    }                    
                    else
                    {
                        MessageBox.Show("Password Addition Failed :(", "Error");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry this Happened => " + ex.Message, "Sorry");
            }
                      
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to cancel adding password?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Hand);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

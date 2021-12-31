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
    public partial class AddUser : KryptonForm
    {
        public AddUser()
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
            if (txtUsername.Text.Trim() == string.Empty && txtMasterPassword.Text.Trim() == string.Empty && txtEmail.Text.Trim() == string.Empty)
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
            else if (txtMasterPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Password", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMasterPassword.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Please Enter Valid Email", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            else if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter URL", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            else if (txtUsername.Text.Length > 25)
            {
                MessageBox.Show("Please Enter Under 25 characters", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }                        
            return true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string email = txtEmail.Text;
                string password = txtMasterPassword.Text;
                string emailCheck = "";
                string usernameCheck = "";
                if(IsValid())
                {
                    UserService userService = new UserService();
                    DataTable dt = userService.SignupEmailCheck(txtEmail.Text);
                    DataTable dt1 = userService.SignupUsernameCheck(txtUsername.Text);
                    foreach (DataRow rw in dt.Rows)
                    {
                        emailCheck = rw["Email"].ToString();
                    }
                    foreach (DataRow row in dt1.Rows)
                    {
                        usernameCheck = row["Username"].ToString();
                    }
                    if (txtEmail.Text.Equals(emailCheck))
                    {
                        MessageBox.Show("This Email is already registered with us. Use Another Email.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Text = "";
                        txtEmail.Focus();
                    }
                    else if (txtUsername.Text.Equals(usernameCheck))
                    {
                        MessageBox.Show("Try Some New Username, Username Already Found! :(", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Text = "";
                        txtUsername.Focus();
                    }
                    else
                    {
                        User user = new User(username, email, password);
                        userService.SignUp(user);
                        if (MessageBox.Show("User Added Successfully!", "Success!", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry... This Occurred => " + ex.Message + " ADDUSRERR","Sorry");
            }            
            raiseUpdate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to cancel add password?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

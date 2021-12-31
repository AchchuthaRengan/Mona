using BLL;
using BO;
using ComponentFactory.Krypton.Toolkit;
using DBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mona
{
    public partial class UpdatePassword : KryptonForm
    {
                
        public UpdatePassword()
        {
            InitializeComponent();
        }

        public int PasswordId { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void UpdatePassword_Load(object sender, EventArgs e)
        {
            try
            {
                EncandDecr encandDecr = new EncandDecr();
                PasswordService passService = new PasswordService();
                DataTable dt = passService.DisplayForUpdatePassword(PasswordId);               
                if(dt.Rows.Count > 0 && dt.Columns.Count > 0 && CurrentUser.Key != "")
                {
                    DataRow row = dt.Rows[0];
                    txtUsername.Text = row["EmailorUsername"].ToString();
                    txtPassword.Text = encandDecr.Decrypt(CurrentUser.Key, row["Password"].ToString());
                    txtCnfmPassword.Text = encandDecr.Decrypt(CurrentUser.Key, row["ConfirmPassword"].ToString());
                    txtUrl.Text = row["Url"].ToString();
                    dateTimePicker1.Value = (DateTime)row["DateOfRegistration"];
                }   
                else
                {
                    MessageBox.Show("Something Went wrong - NODATAONDB","Sorry");
                }    
            }            
            catch(Exception ex)
            {
                MessageBox.Show("Sorry this Occurred =>" + ex.Message,"Sorry");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string pass = txtPassword.Text;
                string confirmPassword = txtCnfmPassword.Text;
                string url = txtUrl.Text;
                DateTime dateOfReg = dateTimePicker1.Value;
                if(IsValid())
                {
                    if (pass.Equals(confirmPassword))
                    {
                        Password password = new Password(username, pass, confirmPassword, url, dateOfReg);
                        PasswordService passService = new PasswordService();
                        string result = passService.UpdatePassword(password, PasswordId);
                        if(result.Equals("1"))
                        {
                            if (MessageBox.Show("Password Updated!", "Success!", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password Updation Failed :(", "Error");
                        }
                        
                    }
                    else
                    {
                        if (MessageBox.Show("Passwords Do Not Match!", "Oops!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            txtPassword.Text = "";
                            txtCnfmPassword.Text = "";
                        }
                        else if(MessageBox.Show("Passwords Do Not Match!", "Oops!", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            this.Close();
                        }
                    }
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry this Occurred => "+ex.Message,"Sorry");
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to cancel the update?", "Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if(dialog == DialogResult.Yes)
            {
                this.Close();
            }                        
        }
    }
}

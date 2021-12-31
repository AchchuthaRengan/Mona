using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLL;
using ComponentFactory.Krypton.Toolkit;
using System.Threading;
using DBLL;

namespace Mona
{
    public partial class SignUp : KryptonForm
    {
        public SignUp()
        {
            InitializeComponent();            
        }
                        
        private bool IsValidForm()
        {            
            if (txtUsername.Text.Trim() == string.Empty && txtUsername.Text.Trim() == string.Empty && txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Boxes eh..? Fill your Credentials!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Username", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }
            else if(txtUsername.Text.Length > 20)
            {
                MessageBox.Show("Username is limited to 20 characters", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }
            else if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Email", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Please Enter Valid Email", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }                        
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Password", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            else if (txtPassword.Text.Length > 20)
            {
                MessageBox.Show("Please Enter password between 0 to 20 characters", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }           
            return true;
        }
                        
        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string emailCheck = "";
                string usernameCheck = "";
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
                if (IsValidForm())
                {
                    if (txtEmail.Text.Equals(emailCheck))
                    {
                        MessageBox.Show("This Email is already registered with us. Use Another Email.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Focus();
                    }
                    else if (txtUsername.Text.Equals(usernameCheck))
                    {
                        MessageBox.Show("Try Some New Username, Username Already Found! :(", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Focus();
                    }
                    else
                    {                        
                        User user = new User(username, email, password);
                        string result = userService.SignUp(user);
                        if(result.Equals("1"))
                        {
                            if (MessageBox.Show("Sign Up Successfull!", "Success!", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                this.Hide();
                                Application.Restart();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Something Went Wrong - SIGNINMRETHN1","Sorry");
                        }                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry... this Happened => " + ex.Message,"Sorry");
            }
        }
                
        private void btnSignin_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }                     
    }
}

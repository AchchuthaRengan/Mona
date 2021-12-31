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
            if(txtUsername.Text.Trim() == string.Empty && txtUsername.Text.Trim() == string.Empty && txtEmail.Text.Trim() == string.Empty)
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
                txtUsername.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Please Enter Valid Email", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Password", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            else if (txtPassword.Text.Length > 20)
            {
                MessageBox.Show("Please Enter password between 0 to 20 characters", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            return true;
        }

        

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (IsValidForm())
            {
                User user = new User(username, email, password);
                UserService userService = new UserService();
                userService.SignUp(user);
                MessageBox.Show("Signup Successfull", "Success!");
                this.Hide();
                SignIn signIn = new SignIn();
                signIn.ShowDialog();
                this.Close();
            }
        }

        private void btnSignin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            this.Close();
        }
    }
}

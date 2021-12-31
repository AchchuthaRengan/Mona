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
    public partial class SignIn : KryptonForm
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
                    
        }

        private bool isValid()
        {
            if(txtEmail.Text.Trim() == string.Empty && txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Empty Boxes eh..? Fill your Credentials!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            else if (txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Valid Email Id", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            else if(txtEmail.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Valid Password", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Please Enter In a Valid Email Format", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (isValid())
            {
                User user = new User(email, password);
                UserService userService = new UserService();
                DataTable dt = userService.SignIn(user);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid Credentials", "Error!");
                }
                else if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Mona mona = new Mona();
                    mona.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnSignin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Close();
        }
    }
}

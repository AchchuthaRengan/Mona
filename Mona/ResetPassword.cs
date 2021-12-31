using BLL;
using BO;
using ComponentFactory.Krypton.Toolkit;
using DBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mona
{
    public partial class ResetPassword : KryptonForm
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string oldPassword = txtOldPassword.Text;
                string newPassword = txtNewPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;
                BEncryption bEncryption = new BEncryption();                
                if (oldPassword != "" && newPassword != "" && confirmPassword != "" && CurrentUser.Email != "")
                {
                    User user = new User(CurrentUser.Email, txtNewPassword.Text);
                    EncandDecr encandDecr = new EncandDecr();
                    UserService userService = new UserService();
                    string masterpassword = userService.GetMasterPassword();
                    string decPassword = encandDecr.Decrypt(CurrentUser.Key, masterpassword);
                    if (bEncryption.VerifyPassword(txtOldPassword.Text,decPassword))
                    {
                        if (txtNewPassword.Text.Equals(txtConfirmPassword.Text))
                        {
                            string i = userService.ResetPassword(user);
                            if (i.Equals("1"))
                            {
                                if(MessageBox.Show("Password Update Successfull", "Success!",MessageBoxButtons.OK) == DialogResult.OK)
                                {
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password Update Failed", "Oops!");
                                txtNewPassword.Text = "";
                                txtConfirmPassword.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("New Password and Confirm Password are not same!","Oops!");
                            txtNewPassword.Text = "";
                            txtConfirmPassword.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter the Correct Master Password", "Oops!");
                        txtOldPassword.Text = "";
                        txtNewPassword.Text = "";
                        txtConfirmPassword.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Empty Boxed Ehh..?. Please Fill You Credentials", "Oops!");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry this Occurred => " + ex.Message + "\nRESETPWDERR", "Sorry");
            }
            
        }
    }
}

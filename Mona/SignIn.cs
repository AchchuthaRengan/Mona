using BLL;
using BO;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Mona
{    
    public partial class SignIn : KryptonForm
    {                      
        public SignIn()
        {
            InitializeComponent();
            notifyIcon1.BalloonTipTitle = "Mona";
            notifyIcon1.BalloonTipText = "We are here to help!";
            notifyIcon1.Text = "Mona";            
        }
                      
        bool usbCondition = false;        

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
                
        private bool USBAuth()
        {
            try
            {
               string _correctHash = @"b+Gpx+d2oFEs5eg3hX15aFHh9fwJzwQpcYAmWKwS/53j/PVhn1yphy8s7tGzO5u2xkbfnTy36nxPg3jEEiS1tg==";
                if(_correctHash != "")
                {
                    if (MessageBox.Show("Awaiting... For USB Authentication", "Access Restricted", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (USBDevice.GetUSBDevices().Any(x => x.ToString() == _correctHash))
                        {
                            usbCondition = true;
                            MessageBox.Show("Successfully Authenticated!", "Success!");
                        }
                        else
                        {
                            usbCondition = false;
                            MessageBox.Show("Cannot Authenticate :(", "Failed!");
                        }
                    }
                    return usbCondition;
                }
                return false;
            }            
            catch(Exception ex)
            {
                MessageBox.Show("Sorry this Happened =>" + ex.Message,"Sorry");
            }
            return false;
        }
                       
        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(chkboxrmberme.Checked)
            {
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Reset();
            }
            
        }
        
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            signInButton();
        }

        public bool signInButton()
        {
            try
            {
                if (isValid())
                {
                    string email = txtEmail.Text;
                    string password = txtPassword.Text;
                    User user = new User(email, password);
                    UserService userService = new UserService();
                    bool dt = userService.SignIn(user);
                    DataTable ddt1 = userService.GetUser(user);
                    if (dt == false)
                    {
                        MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OKCancel);                                            
                        return false;
                    }
                    else
                    {                        
                        DialogResult = DialogResult.OK;                        
                        return true;                        
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry this Occurred => " + ex.Message + "\nSIGNINFAILURE","Sorry");
            }
            return false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            //this.Close();
        }

        private void usbAuthButton_Click(object sender, EventArgs e)
        {
            USBAuth();
            if (usbCondition == true)
            {
                this.Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
                this.Close();
            }
        }
    }
}

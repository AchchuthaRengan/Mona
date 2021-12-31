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
    public partial class UpdateUser : KryptonForm
    {
        public UpdateUser()
        {
            InitializeComponent();
        }

        public int userId { get; set; }

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
                MessageBox.Show("Please Enter Valid Username", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }
            else if (txtMasterPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Password", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMasterPassword.Focus();
                return false;
            }            
            else if (txtUsername.Text.Length > 25)
            {
                MessageBox.Show("Please Enter Under 25 characters", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return true;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {
                    string username = txtUsername.Text;
                    string pass = txtMasterPassword.Text;
                    string email = txtEmail.Text;
                    User user = new User(username, email, pass);
                    UserService userService = new UserService();
                    string result = userService.AdminUserUpdate(user);
                    if(result.Equals("1"))
                    {
                        if(MessageBox.Show("User Updated!", "Success!",MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Update Failed :(", "Oops!");
                    }                    
                }
                else
                {
                    MessageBox.Show("Please Fill All Fields.","Oops!");
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Sorry this Happened => "+ex.Message,"Sorry");
            }
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            try
            {
                EncandDecr encandDecr = new EncandDecr();
                UserService userService = new UserService();
                DataTable dt = userService.DisplayForUpdateUser(userId);                
                if(dt.Rows.Count > 0 && dt.Columns.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtUsername.Text = row["Username"].ToString();
                    string emailId = row["Email"].ToString();
                    PasswordService passwordService = new PasswordService();
                    string Key = passwordService.GetKeyWithEmail(emailId);
                    txtMasterPassword.Text = encandDecr.Decrypt(Key, row["MasterPassword"].ToString());
                    txtEmail.Text = row["Email"].ToString();
                }
                else
                {
                    MessageBox.Show("No Data on DB :(, Contact Admin","Oops!");
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry.. This Happened =>" + ex.Message+"Sorry");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to cancel the update?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

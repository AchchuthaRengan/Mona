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

        private void UpdatePassword_Load(object sender, EventArgs e)
        {            
            PasswordService passService = new PasswordService();
            DataTable dt = passService.DisplayForUpdatePassword(PasswordId);
            DataRow row = dt.Rows[0];            
            
            txtUsername.Text = row["EmailorUsername"].ToString();
            txtPassword.Text = row["Password"].ToString();
            txtCnfmPassword.Text = row["ConfirmPassword"].ToString();
            txtUrl.Text = row["Url"].ToString();
            dateTimePicker1.Value = (DateTime)row["DateOfRegistration"];
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pass = txtPassword.Text;
            string confirmPassword = txtCnfmPassword.Text;           
            string url = txtUrl.Text;
            DateTime dateOfReg = dateTimePicker1.Value;
            if(pass.Equals(confirmPassword))
            {
                string encryptedPassword = Eramake.eCryptography.Encrypt(pass);
                string encConfirmPassword = Eramake.eCryptography.Encrypt(confirmPassword);
                Password password = new Password(username, encryptedPassword, encConfirmPassword, url, dateOfReg);
                PasswordService passService = new PasswordService();
                passService.UpdatePassword(password, PasswordId);
                MessageBox.Show("Password Updated!", "Success!");
            }
            else
            {
                MessageBox.Show("Passwords do not match!", "Warning");
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

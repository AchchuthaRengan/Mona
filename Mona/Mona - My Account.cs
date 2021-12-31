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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mona
{
    public partial class Mona___My_Account : KryptonForm
    {
        public Mona___My_Account()
        {
            InitializeComponent();
        }
        
        private void Mona___My_Account_Load(object sender, EventArgs e)
        {
            try
            {
                PasswordService passwordService = new PasswordService();
                UserService userService = new UserService();
                string name = userService.GetUsernameFromEmail();
                string passwordcount = passwordService.GetPasswordCount();
                if(name != "" && CurrentUser.Email != "")
                {
                    lblPassCount.Text = passwordcount;
                    lblEmail.Text = CurrentUser.Email;
                    lblName.Text = name;
                    lblComputersName.Text = Environment.MachineName.ToString();
                }
                else
                {
                    MessageBox.Show("Nothing to Show :(","Oops!");
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry.. This Occurred => "+ex.Message + "\nACCRETRIVALERR","Sorry");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                PasswordService passwordService = new PasswordService();
                int passwordcount = Convert.ToInt32(passwordService.GetPasswordCount());
                if (passwordcount > 0)
                {
                    ExportFormats exportFormats = new ExportFormats();
                    exportFormats.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No Passwords are Found to Export, Add Some and then Try Again", "Oops!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry this Occurred => " + ex.Message + "\nEXPRTERR", "Sorry");
            }
            
            
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.ShowDialog();
        }        
    }
}

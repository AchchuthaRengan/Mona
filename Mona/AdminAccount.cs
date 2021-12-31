using BLL;
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
    public partial class AdminAccount : KryptonForm
    {
        public AdminAccount()
        {
            InitializeComponent();
            try
            {
                UserService userService = new UserService();
                string count = userService.GetUsersCount();
                if(count != " ")
                {
                    lblName.Text = "Admin";
                    lblEmail.Text = "Admin@mona.com";
                    lblComputersName.Text = Environment.MachineName.ToString();
                    lblPassCount.Text = count;
                }
                else
                {
                    MessageBox.Show("Oops!.. Something Went Wrong.");
                }                                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry this Occurred => " + ex.Message + "\nNOUSRRECORDFOUND","Sorry");
            }
            
        }
    }
}

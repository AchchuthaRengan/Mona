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
    public partial class FileLock : KryptonForm
    {
        public FileLock()
        {
            InitializeComponent();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "All files|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    txtLocation.Text = ofd.FileName;
            }
        }
        
        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {            
            try
            {
                string key = txtKey.Text;
                string location = txtLocation.Text;
                if (key != "" && location != "")
                {
                    EncryptionFileCore tDES = new EncryptionFileCore(key);
                    tDES.EncryptFile(location);
                    GC.Collect();
                    MessageBox.Show("Successfully Encrypted :)", "Success!");
                }
                else
                {
                    MessageBox.Show("Location and ****** Not Found","Error");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry... this Occurred => "+ex.Message+"\nENCERR","Sorry");
            }
        }

        private void btnCrypt_Click(object sender, EventArgs e)
        {            
            try
            {
                string key = txtKey.Text;
                string location = txtLocation.Text;
                if (key != "" && location != "")
                {
                    EncryptionFileCore tDES = new EncryptionFileCore(key);
                    tDES.DecryptFile(location);
                    GC.Collect();
                    MessageBox.Show("Successfully Decrypted :)", "Success!");
                }
                else
                {
                    MessageBox.Show("Location and ****** Not Found", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry... this Occurred => " + ex.Message + "\nENCERR","Sorry");
            }
        }
    }
}

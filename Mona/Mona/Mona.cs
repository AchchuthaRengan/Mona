using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using BLL;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using ComponentFactory.Krypton.Toolkit;
using System.Net;

namespace Mona
{
    public partial class Mona : KryptonForm
    {                        
        public Mona()
        {
            InitializeComponent();
            PasswordService passService = new PasswordService();
            DataView dv = passService.PasswordDetails();
            kryptonDataGridView1.DataSource = dv;
            kryptonDataGridView1.Columns[0].Visible = false;
        }
               
        private void Form1_Load(object sender, EventArgs e)
        {
            PasswordService passService = new PasswordService();
            DataView dv = passService.PasswordDetails();
            kryptonDataGridView1.DataSource = dv;
        }
        
        
                                                        
        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            //string username = textBoxUsername.Text;
            //string pass = txtBoxPassword.Text;
            //string confirmPassword = textBoxCnfmPass.Text;
            //string url = txtBoxUrl.Text;
            //DateTime timeofregistration = dateTimePicker1.Value;

            //if(IsValid())
            //{
            //    Password password = new Password(username, pass, confirmPassword, url, timeofregistration);
            //    PasswordService passService = new PasswordService();

            //    passService.InsertPassword(password);
            //    MessageBox.Show("New Password Added!", "Success!");
            //    textBoxUsername.Clear();
            //    txtBoxPassword.Clear();
            //    textBoxCnfmPass.Clear();
            //    txtBoxUrl.Clear();
            //}                        
        }
                       
        private void btnShowAllPass_Click(object sender, EventArgs e)
        {
            PasswordService passService = new PasswordService();
            DataView dv = passService.PasswordDetails();
            kryptonDataGridView1.DataSource = dv;
        }
        
        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //panel6.Visible = true;
            //string email = Convert.ToString(kryptonDataGridView1.SelectedRows[0].Cells[1].Value);
            //string password = Convert.ToString(kryptonDataGridView1.SelectedRows[0].Cells[2].Value);
            //string pictureurl = Convert.ToString(kryptonDataGridView1.SelectedRows[0].Cells[4].Value);
            //try
            //{
            //    var request = WebRequest.Create("https://" + pictureurl + "/favicon.ico");
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Cannot Get the image From URL",ex.Message);
            //}
            
            //using (var response = request.GetResponse())
            //using (var stream = response.GetResponseStream())
            //{
            //    //pictureBox2.Image = Bitmap.FromStream(stream);
            //}
            //lblUsrname.Text = email;
            //lblPassword.Text = password;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            this.Close();
        }
                
        private void F3_UpdateEventHandler1(object sender, NewPassword.UpdateEventArgs args)
        {
            PasswordService passservice = new PasswordService();
            DataView dv = passservice.PasswordDetails();
            kryptonDataGridView1.DataSource = dv;
        }

        private void kryptonDataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int passwordId = Convert.ToInt32(kryptonDataGridView1.SelectedRows[0].Cells[0].Value);
            if (passwordId != 0)
            {
                if (MessageBox.Show("Are You Sure.. You want to delete this password?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Password password = new Password(passwordId);
                    PasswordService passwordService = new PasswordService();
                    passwordService.DeletePassword(password);
                    MessageBox.Show("Password Deleted ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void kryptonDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kryptonDataGridView1.Rows.Count > 0)
            {
                int passwordId = Convert.ToInt32(kryptonDataGridView1.SelectedRows[0].Cells[0].Value);
                UpdatePassword updatepassword = new UpdatePassword();
                updatepassword.PasswordId = passwordId;
                updatepassword.ShowDialog();
            }
        }

        private void kryptonDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new string('•', e.Value.ToString().Length);
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new string('•', e.Value.ToString().Length);
                e.FormattingApplied = true;
            }
        }

        private void btnaddPass_Click(object sender, EventArgs e)
        {
            NewPassword obj = new NewPassword();
            obj.UpdateEventHandler += F3_UpdateEventHandler1;
            obj.ShowDialog();            
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            this.Close();
        }
    }   
}

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
    public partial class AdminForm : KryptonForm
    {
        public AdminForm()
        {
            InitializeComponent();            
            KryptonDataGridViewButtonColumn edit = (KryptonDataGridViewButtonColumn)kryptonDataGridView1.Columns["Edit"];
            KryptonDataGridViewButtonColumn delete = (KryptonDataGridViewButtonColumn)kryptonDataGridView1.Columns["Delete"];
            edit.ButtonStyle = ButtonStyle.ButtonSpec;
            edit.Text = "Edit";
            edit.CellTemplate.Style.BackColor = Color.Teal;
            edit.CellTemplate.Style.ForeColor = Color.White;
            delete.ButtonStyle = ButtonStyle.ButtonSpec;
            delete.Text = "Delete";
            delete.CellTemplate.Style.BackColor = Color.Teal;
            delete.CellTemplate.Style.ForeColor = Color.White;
            try
            {
                UserService userService = new UserService();
                DataTable dt = userService.UserDetails();
                if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
                {
                    kryptonDataGridView1.DataSource = dt;
                    kryptonDataGridView1.Columns[2].Visible = false;
                    kryptonDataGridView1.AutoGenerateColumns = false;
                    kryptonDataGridView1.Visible = false;
                    if (kryptonDataGridView1.Rows.Count >= 1)
                    {
                        kryptonDataGridView1.Visible = true;
                    }
                }
                else
                {
                    if (MessageBox.Show("Not Enough Data to Show :(", "Warning", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry... This Happened  => "+ex.Message+"\nDATALOADERR", "Sorry");
            }            
        }

        private void GetUserFromDatabase()
        {
            try
            {
                UserService userService = new UserService();
                DataTable dt = userService.UserDetails();
                if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
                {
                    kryptonDataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data Found..! Add Some Passwords","Oops!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry This Occurred => " + ex.Message + "NODATAONDB", "Sorry");
            }
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out will Close this Application","Warning");
            Application.Exit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void F3_UpdateEventHandler1(object sender, AddUser.UpdateEventArgs args)
        {
            UserService userService = new UserService();
            DataTable dt = userService.UserDetails();
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                kryptonDataGridView1.DataSource = dt;
            }
            else
            {
                throw new Exception("No Data Found");
            }
        }

        private void btnBroswerPass_Click(object sender, EventArgs e)
        {
            BrowserChoose browserChoose = new BrowserChoose();
            browserChoose.ShowDialog();
        }

        private void btnLockOpt_Click(object sender, EventArgs e)
        {
            FileLock fileLock = new FileLock();
            fileLock.ShowDialog();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            AdminAccount adminAccount = new AdminAccount();
            adminAccount.ShowDialog();
        }

        private void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    try
                    {
                        if (kryptonDataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete" || e.RowIndex == -1)
                        {
                            int UserId = Convert.ToInt32(kryptonDataGridView1.Rows[e.RowIndex].Cells["UserId"].Value);
                            if (UserId != 0)
                            {
                                if (MessageBox.Show("Are You Sure.. You want to Remove this User?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    User user = new User(UserId);
                                    UserService userService = new UserService();
                                    string result = userService.DeleteUser(user);
                                    if (result.Equals("1"))
                                    {
                                        MessageBox.Show("User Deleted ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Something Went Wrong, Kindly delete all the passwords of the user and try again","Sorry");
                                    }

                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Sorry this Occurred => " + ex.Message + "\nUSRDELERR", "Sorry");
                    }
                    try
                    {
                        if (kryptonDataGridView1.Columns[e.ColumnIndex].HeaderText == "Edit" || e.RowIndex == -1)
                        {
                            int UserId = Convert.ToInt32(kryptonDataGridView1.Rows[e.RowIndex].Cells["UserId"].Value);
                            if (UserId != 0)
                            {
                                if (kryptonDataGridView1.Rows.Count > 0)
                                {
                                    UpdateUser updateUser = new UpdateUser();
                                    updateUser.userId = UserId;
                                    PasswordService passwordService2 = new PasswordService();
                                    DataTable dt = passwordService2.PasswordDetails();
                                    kryptonDataGridView1.DataSource = dt;
                                    updateUser.ShowDialog();
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Sorry this Occurred => " + ex.Message + "\nUSREDTERR","Sorry");
                    }                    
                }
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry... this Occurred => " + ex.Message + "\nOPERATIONDGVERR","Sorry");
            }
            
        }
        
        private void AdminForm_Activated(object sender, EventArgs e)
        {
            GetUserFromDatabase();
        }

        private void kryptonDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.Value != null)
            {
                e.Value = new string('•', e.Value.ToString().Length);
                e.FormattingApplied = true;
            }
        }

        private void btnaddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About___Mona about___Mona = new About___Mona();
            about___Mona.ShowDialog();
        }
    }
}

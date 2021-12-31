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
    public partial class ExportFormats : KryptonForm
    {
        public ExportFormats()
        {
            InitializeComponent();
            try
            {
                PasswordService passwordService = new PasswordService();
                System.Data.DataTable dt = passwordService.PasswordDetails();
                if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Visible = false;
                }
                else
                {
                    if(MessageBox.Show("No Enough Data to Show", "Oops!",MessageBoxButtons.OK)==DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry... this Occurred => " + ex.Message + "\nNODATAFOUND","Sorry");
            }                        
        }        

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";

            sfd.FileName = CurrentUser.Email + ".xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(GetData(), sfd.FileName);
            }
        }

        private System.Data.DataTable GetData()
        {
            PasswordService passwordService = new PasswordService();
            System.Data.DataTable dt = passwordService.PasswordDetails();
            return dt;
        }

        private void ExportToExcel(System.Data.DataTable dt, string FilePath)
        {
            try
            {
                if (dt == null || dt.Columns.Count == 0)
                {
                    if (MessageBox.Show("No Data on Table, Add Some Passwords", "Oops", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    Microsoft.Office.Interop.Excel.Application excelApplication = new Microsoft.Office.Interop.Excel.Application();
                    excelApplication.Workbooks.Add();
                    Microsoft.Office.Interop.Excel.Worksheet worksheet = excelApplication.ActiveSheet;


                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        worksheet.Cells[1, (i + 1)] = dt.Columns[i].ColumnName;
                    }

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 1; j < dt.Columns.Count; j++)
                        {
                            worksheet.Cells[(i + 2), (j + 1)] = dt.Rows[i][j];
                        }
                    }

                    if (FilePath != null && FilePath != "")
                    {
                        try
                        {
                            worksheet.SaveAs(FilePath, Password: txtPassword.Text);
                            excelApplication.Quit();
                            if (MessageBox.Show("Export Successfull!", "Success", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Export Unsuccessful, Check for File Path you chose" + ex.Message);
                        }
                    }
                    else
                    {
                        excelApplication.Visible = true;
                    }
                }                                                    
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected Failure :(" + ex.Message);
            }
        }               
    }
}

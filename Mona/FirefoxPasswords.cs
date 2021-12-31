using BO;
using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mona
{
    public partial class FirefoxPasswords : KryptonForm
    {        
        public FirefoxPasswords()
        {
            InitializeComponent();
        }        
        private void FirefoxPasswords_Load(object sender, EventArgs e)
        {
            FireFox fireFox = new FireFox();
            IEnumerable<CredentialModel> dt = fireFox.ReadPasswords();
            kryptonDataGridView1.DataSource = dt;
        }

        private void ExportToExcel(string filepath)
        {
            Microsoft.Office.Interop.Excel.Application objexcelapp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Worksheet wsheet;
            Microsoft.Office.Interop.Excel.Workbook wbook;

            objexcelapp.Visible = false;

            wbook = objexcelapp.Workbooks.Add(true);
            wsheet = wbook.ActiveSheet;
            objexcelapp.Application.Workbooks.Add(Type.Missing);
            objexcelapp.Columns.ColumnWidth = 25;
            for (int i = 1; i < kryptonDataGridView1.Columns.Count + 1; i++)
            {
                wsheet.Cells[1, i] = kryptonDataGridView1.Columns[i - 1].HeaderText;
            }
            /*For storing Each row and column value to excel sheet*/
            for (int i = 0; i < kryptonDataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < kryptonDataGridView1.Columns.Count; j++)
                {
                    if (kryptonDataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        wsheet.Cells[i + 2, j + 1] = kryptonDataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }            
            wbook.SaveAs(filepath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, txtPassword.Text, Type.Missing,
            false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            wbook.Close();
            if (MessageBox.Show("Passwords Successfully Exported!", "Success!", MessageBoxButtons.OK) == DialogResult.OK)
            {
                txtPassword.Text = "";
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            sfd.FileName = CurrentUser.Email+"_FireFox_Passwords" + ".xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {                
                ExportToExcel(sfd.FileName);
            }

        }
        
    }
    
}


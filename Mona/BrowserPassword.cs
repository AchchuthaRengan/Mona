using BO;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Data.Sqlite;
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
    public partial class BrowserPassword : KryptonForm
    {
        public string BrowserName { get { return "Chrome"; } }

        private const string LOGIN_DATA_PATH = "\\..\\Local\\Google\\Chrome\\User Data\\Default\\Login Data";

        public BrowserPassword()
        {
            InitializeComponent();
        }

        private void BrowserPassword_Load(object sender, EventArgs e)
        {
            try
            {
                var result = new List<CredentialModel>();
                var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);// APPDATA
                var p = Path.GetFullPath(appdata + LOGIN_DATA_PATH);
                DataTable dt = new DataTable();
                if (File.Exists(p))
                {
                    using (var conn = new SQLiteConnection($"Data Source={p};"))
                    {
                        conn.Open();
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT action_url, username_value, password_value FROM logins";
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    var key = GCDecryptor.GetKey();
                                    while (reader.Read())
                                    {

                                        byte[] nonce, ciphertextTag;
                                        var encryptedData = GetBytes(reader, 2);
                                        GCDecryptor.Prepare(encryptedData, out nonce, out ciphertextTag);
                                        var pass = GCDecryptor.Decrypt(ciphertextTag, key, nonce);
                                        result.Add(new CredentialModel()
                                        {
                                            Url = reader.GetString(0),
                                            Username = reader.GetString(1),
                                            Password = pass
                                        });
                                    }
                                }

                            }
                        }
                        conn.Close();
                    }
                }
                else
                {
                    throw new FileNotFoundException("Cannot find chrome logins file");
                }
                byte[] GetBytes(SQLiteDataReader reader, int columnIndex)
                {
                    const int CHUNK_SIZE = 2 * 1024;
                    byte[] buffer = new byte[CHUNK_SIZE];
                    long bytesRead;
                    long fieldOffset = 0;
                    using (MemoryStream stream = new MemoryStream())
                    {
                        while ((bytesRead = reader.GetBytes(columnIndex, fieldOffset, buffer, 0, buffer.Length)) > 0)
                        {
                            stream.Write(buffer, 0, (int)bytesRead);
                            fieldOffset += bytesRead;
                        }
                        return stream.ToArray();
                    }
                }
                kryptonDataGridView1.DataSource = result;
                for (int i = kryptonDataGridView1.Rows.Count - 1; i > -1; i--)
                {
                    DataGridViewRow row = kryptonDataGridView1.Rows[i];
                    if (!row.IsNewRow && row.Cells[0].Value == null)
                    {
                        kryptonDataGridView1.Rows.RemoveAt(i);
                    }
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }

        private void ExportToExcel(string filepath)
        {         
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Exported from gridview";
                for (int i = 1; i < kryptonDataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = kryptonDataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < kryptonDataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < kryptonDataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = kryptonDataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(filepath, Type.Missing, txtPassword.Text, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();
                if(MessageBox.Show("Passwords Successfully Exported!","Success!",MessageBoxButtons.OK)== DialogResult.OK)
                {
                    txtPassword.Text = "";
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    
       private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xlsx)|*.xlsx";
                sfd.FileName = CurrentUser.Email + "_Chrome_Passwords" + ".xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(sfd.FileName);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}

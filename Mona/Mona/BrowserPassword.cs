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

        
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLL
{
    /// <summary>
    /// SQLConnection Module - Connection String    
    /// </summary>
    #region
    public class SQLServerConnection
    {
        public SqlConnection Connect()
        {
            try
            {
                string path = Path.GetFullPath(Environment.CurrentDirectory);
                string databaseName = "MonaDB.mdf";
                string fullpath = path + @"\" + databaseName;
                if (File.Exists(fullpath))
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + "");
                    return con;
                }
                else
                {
                    throw new Exception("Database Not Found :(");
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
#endregion
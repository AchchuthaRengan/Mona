using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLL
{
    public class SQLServerConnection
    {
        public SqlConnection Connect()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Application_Full\Mona\Mona\BO\Mona.mdf;Integrated Security=True");
            
            return con;
        }
    }
}

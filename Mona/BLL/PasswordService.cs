using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DBLL;

namespace BLL
{
    public class PasswordService
    {
        public void InsertPassword(Password password)
        {
            DBService dbService = new DBService();
            dbService.InsertPassword(password);
        }

        public DataView PasswordDetails()
        {
            DBService dBService = new DBService();
            DataView dv = dBService.PasswordDetails();

            return dv;
        }

        public DataTable DisplayForUpdatePassword(int passwordId)
        {
            DBService dbService = new DBService();
            DataTable dt = dbService.DisplayForUpdatePassword(passwordId);
            return dt;
        }

        public void UpdatePassword(Password password, int passwordId)
        {
            DBService dbService = new DBService();
            dbService.UpdatePassword(password, passwordId);
        }

        public void DeletePassword(Password password)
        {
            DBService dbService = new DBService();
            dbService.DeletePassword(password);
        }
    }
}

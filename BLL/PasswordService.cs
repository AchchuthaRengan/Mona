using BO;
using DBLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// Database Password Service Module                
    /// </summary>
    public class PasswordService
    {
        public string InsertPassword(Password password)
        {
            DBService dbService = new DBService();
            string status = dbService.InsertPassword(password);
            return status;
        }
        //Used on Mona DataGridView

        public DataTable PasswordDetails()
        {
            DBService dBService = new DBService();
            DataTable dt = dBService.PasswordDetails();
            return dt;
        }
        //Used on Mona
        public string getPassword(string email, int passwordId)
        {
            DBService dBService = new DBService();
            string decPassword = dBService.getPassword(email, passwordId);
            return decPassword;
        }

            public DataTable DisplayForUpdatePassword(int passwordId)
        {
            DBService dbService = new DBService();
            DataTable dt = dbService.DisplayForUpdatePassword(passwordId);
            return dt;
        }

        public string UpdatePassword(Password password, int passwordId)
        {
            DBService dbService = new DBService();
            string status = dbService.UpdatePassword(password, passwordId);
            return status;
        }

        public string DeletePassword(Password password)
        {
            DBService dbService = new DBService();
            string status = dbService.DeletePassword(password);
            return status;
        }

        //Used on Mona-MyAccount
        public string GetPasswordCount()
        {
            DBService dBService = new DBService();
            string count = dBService.GetPasswordCount();
            return count;
        }

        //Used on ForgetPassword & *
        public string GetKeyWithEmail(string email)
        {
            DBService dbService = new DBService();
            string key = dbService.GetKeyWithEmail(email);
            return key;
        }

        //Used on RecoverPassword
        public string GetKeyFromPassword()
        {
            DBService dBService = new DBService();
            string secretKey = dBService.GetKeyFromPassword();
            return secretKey;
        }
        //Mona - Forget Password
        public string GetKeyForResetPassword(string email)
        {
            DBService dBService = new DBService();
            string secretKey = dBService.GetKeyForResetPassword(email);
            return secretKey;
        }
    }
}

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
    /// <summary>
    /// Database User Service Module    
    /// </summary>
    public class UserService
    {
        public string SignUp(User user)
        {
            DBService dbService = new DBService();
            string status = dbService.SignUp(user);
            return status;
        }

        public bool SignIn(User user)
        {
            DBService dBService = new DBService();
            bool dt = dBService.SignIn(user);
            return dt;
        }
        //Used in SignIn
        public DataTable GetUser(User user)
        {
            DBService dBService = new DBService();
            DataTable dt = dBService.GetUser(user);
            return dt;
        }

        public string DeleteUser(User user)
        {
            DBService dBService = new DBService();
            string status = dBService.DeleteUser(user);
            return status;
        }

        //Used on Mona - My Account
        public string GetUsernameFromEmail()
        {
            DBService dBService = new DBService();
            string name = dBService.GetUsernameFromEmail();
            return name;
        }

        //Used on AdminForm
        public DataTable UserDetails()
        {
            DBService dBService = new DBService();
            DataTable dt = dBService.UserDetails();
            return dt;
        }

        //Used on ResetPassword
        public string GetMasterPassword()
        {
            DBService dBService = new DBService();
            string masterPassword = dBService.GetMasterPassword();
            return masterPassword;
        }
        //Used on AddUser
        public DataTable SignupEmailCheck(string email)
        {
            DBService dBService = new DBService();
            DataTable dt = dBService.SignupEmailCheck(email);
            return dt;
        }
        //Used on ResetPassword
        public string ResetPassword(User user)
        {
            DBService dBService = new DBService();
            string status = dBService.ResetPassword(user);
            return status;
        }
        //Used on AddUser
        public DataTable SignupUsernameCheck(string username)
        {
            DBService dBService = new DBService();
            DataTable dt = dBService.SignupUsernameCheck(username);
            return dt;
        }

        public void InsertUser(User user)
        {
            DBService dBService = new DBService();
            dBService.InsertUser(user);
        }

        public string UpdateUser(User user, int userId)
        {
            DBService dBService = new DBService();
            string status = dBService.UpdateUser(user, userId);
            return status;
        }

        public DataTable DisplayForUpdateUser(int userId)
        {
            DBService dBService = new DBService();
            DataTable dt = dBService.DisplayForUpdateUser(userId);
            return dt;
        }

        //Used on Admin-MyAccount

        public string GetUsersCount()
        {
            DBService dBService = new DBService();
            string count = dBService.GetUsersCount();
            return count;
        }
        //Used on Mona-ForgetPassword
        public string PasswordReset(User user)
        {
            DBService dbService = new DBService();
            string status = dbService.PasswordReset(user);
            return status;
        }

        public string AdminUserUpdate(User user)
        {
            DBService dbService = new DBService();
            string status = dbService.AdminUserUpdate(user);
            return status;
        }
    }
}

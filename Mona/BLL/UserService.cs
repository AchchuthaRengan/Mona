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
    public class UserService
    {
        public void SignUp(User user)
        {
            DBService dbService = new DBService();
            dbService.SignUp(user);
        }

        public DataTable SignIn(User user)
        {
            DBService dBService = new DBService();
            DataTable dt = dBService.SignIn(user);

            return dt;
        }

        public string RecoverPassword(User user)
        {
            DBService dBService = new DBService();
            string dt = dBService.RecoverPassword(user);
            return dt;
        }
    }
}

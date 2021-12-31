using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class User
    {
        private int userId;
        private string username;
        private string email;
        private string password;

        public User()
        {

        }

        public User(string email)
        {            
            this.Email = email;
        }

        public User(string email, string password)
        {
            this.Password = password;
            this.Email = email;
        }

        public User(string username,string email,string password)
        {            
            this.Username = username;
            this.Password = password;
            this.Email = email;
        }

        public int UserId
        {
            get; set;
        }

        public string Username
        {
            get; set;
        }

        public string Email
        {
            get; set;
        }

        public string Password
        {
            get; set;
        }

        public override string ToString()
        {
            return "UserId: " + this.UserId + " Username " + this.Username + "Email: "+this.Email+" Password " + this.Password;
        }
    }
}

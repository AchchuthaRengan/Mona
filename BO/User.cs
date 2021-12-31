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
        private string pash;
        private string key;
        private string secretKey;

        public User()
        {

        }
        
        public User(int userId)
        {
            this.UserId = userId;
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
        
        public User(string username, string email, string password)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;            
        }

        public User(string email,string password,string pash, string key,string secretKey)
        {
            this.Email = email;
            this.Password = password;
            this.Pash = pash;
            this.Key = key;
            this.SecretKey = secretKey;
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

        public string Pash
        {
            get; set;
        }

        public string Key
        {
            get; set;
        }

        public string SecretKey
        {
            get; set;
        }

        public override string ToString()
        {
            return "UserId: " + this.UserId + " Username " + this.Username + "Email: " + this.Email + " Password " + this.Password+" Secret Key"+this.SecretKey;
        }
    }
}

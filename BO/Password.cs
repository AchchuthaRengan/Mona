using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Password
    {
        private int passwordId;
        private string emailorUsername;
        private string pass;
        private string confirmpassword;
        private string url;
        private DateTime timeofregistration;
        

        public Password()
        {

        }

        public Password(int passwordId)
        {
            this.PasswordId = passwordId;
        }

        public Password(string emailorusername, string pass, string confirmpassword, string url, DateTime timeofregistration)
        {
            this.EmailorUsername = emailorusername;
            this.Pass = pass;
            this.Url = url;
            this.ConfirmPassword = confirmpassword;
            this.TimeofReg = timeofregistration;
            //this.UserId = userId;
        }

        public int PasswordId
        {
            get; set;
        }

        public string EmailorUsername
        {
            get; set;
        }

        public string Pass
        {
            get; set;
        }

        public string ConfirmPassword
        {
            get; set;
        }

        public string Url
        {
            get; set;
        }

        public DateTime TimeofReg
        {
            get; set;
        }

        //public int UserId
        //{
        //    get; set;
        //}

        public override string ToString()
        {
            return "\nEmail or Username: " + this.EmailorUsername + " Password " + this.Pass + " ConfirmPassword " + this.ConfirmPassword + " Url " + this.Url + " Date Of Registration " + this.TimeofReg;
            //" UserId: " + this.UserId
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    class masterpassword
    {
        private string masterpasswordId;
        private string masterpass;
        private string confirmmasterpassword;
        private string newmasterpassword;

        public masterpassword()
        {

        }

        public masterpassword(string masterpasswordId,string masterpass, string confirmmasterpassword, string newmasterpassword)
        {
            this.MasterpasswordId = masterpasswordId;
            this.Masterpass = masterpass;
            this.Confirmmasterpassword = confirmmasterpassword;
            this.Newmasterpassword = newmasterpassword;
        }

        public string MasterpasswordId
        {
            get; set;
        }

        public string Masterpass
        {
            get; set;
        }
        public string Confirmmasterpassword
        {
            get; set;
        }
        public string Newmasterpassword
        {
            get; set;
        }

        public override string ToString()
        {
            return "\nMasterPassword: " + this.Masterpass + " ConfirmPassword: " + this.Confirmmasterpassword + " New Password: " + this.Newmasterpassword;
        }
    }
}

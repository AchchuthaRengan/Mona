using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace BLL
{
    /// <summary>
    /// Hashing Module
    /// Using BCrypt to generate RandomSalt, Hashing of Passwords.
    /// </summary>
    public class BEncryption
    {
        public string GetRandomSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt(12);
        }

        public string BCryptHash(string password,string salt)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}

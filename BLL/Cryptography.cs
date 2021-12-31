using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mona
{
    /// <summary>
    /// USB Module
    /// To check the availability of USB to connect which has it hash encrypted in SHA512.
    /// </summary>
    public static class Cryptography
    {
        public static string HashSHA512(this string toEncrypt)
        {
            byte[] toEncryptBytes = Encoding.UTF8.GetBytes(toEncrypt);
            byte[] encryptedBytes;

            using (SHA512 shaManaged = new SHA512Managed())
                encryptedBytes = shaManaged.ComputeHash(toEncryptBytes);

            return Convert.ToBase64String(encryptedBytes);
        }
    }
}

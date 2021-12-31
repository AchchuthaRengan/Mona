using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mona
{
    /// <summary>
    /// File Encryption Module
    /// Encrypt and Decrypt Service using 3DES.
    /// </summary>
    public class EncryptionFileCore
    {
        private TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();

        public EncryptionFileCore(string key)
        {
            des.Key = UTF8Encoding.UTF8.GetBytes(key);
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.PKCS7;
        }

        public void EncryptFile(string filePath)
        {
            byte[] Bytes = File.ReadAllBytes(filePath);
            byte[] eBytes = des.CreateEncryptor().TransformFinalBlock(Bytes, 0, Bytes.Length);
            File.WriteAllBytes(filePath, eBytes);
        }

        public void DecryptFile(string filePath)
        {
            byte[] Bytes = File.ReadAllBytes(filePath);
            byte[] dBytes = des.CreateDecryptor().TransformFinalBlock(Bytes, 0, Bytes.Length);
            File.WriteAllBytes(filePath, dBytes);
        }
    }
}

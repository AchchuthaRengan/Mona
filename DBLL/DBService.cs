 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BO;
using DBLL;

namespace DBLL
{
    /// <summary>
    /// Database Module    
    /// </summary>
    public class DBService
    {
        #region
        public string InsertPassword(Password password)
        {
            try
            {
                EncandDecr encandDecr = new EncandDecr();
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                string pass = password.Pass;
                string confirmPassword = password.ConfirmPassword;
                string encryptedPassword = encandDecr.Encrypt_Other(CurrentUser.Key, pass);
                string encryptedConfirmPassword = encandDecr.Encrypt_Other(CurrentUser.Key, confirmPassword);
                string emailorUser = password.EmailorUsername;
                string url = password.Url;
                DateTime DateofCreation = password.TimeofReg;
                if (emailorUser != "" && encryptedConfirmPassword != "" && encryptedPassword != "" && url != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_addpassword";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmailOrUsername", emailorUser);
                    cmd.Parameters.AddWithValue("@Password", encryptedPassword);
                    cmd.Parameters.AddWithValue("@ConfirmPassword", encryptedConfirmPassword);
                    cmd.Parameters.AddWithValue("@Url", url);
                    cmd.Parameters.AddWithValue("@DateOfRegistration", DateofCreation);
                    cmd.Parameters.AddWithValue("@UserId", CurrentUser.UserId);
                    int i = cmd.ExecuteNonQuery();
                    return i.ToString();
                }
                return "Not All Fields are Filled :(";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

        }
        #endregion

        #region
        public string InsertUser(User user)
        {       
            try
            {
                EncandDecr encandDecr = new EncandDecr();
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                string username = user.Username;
                string email = user.Email;
                string password = user.Password;
                //Initiating BCrypt 
                BEncryption bcrypt = new BEncryption();
                //Generating Salt
                string salt = bcrypt.GetRandomSalt();
                //Converting Salt to String 
                //string pashalt = Convert.ToBase64String(salt).ToString();
                //Sending Plain Text(Password),Salt to Hashing Function 
                string hash = bcrypt.BCryptHash(password, salt);
                //Converting Hashed Password to String 
                //string pashash = Convert.ToBase64String(hash).ToString();
                //Sending Hashed Password String to AES-256 Encryption
                var Encrypt_Function = encandDecr.Encrypt(hash);
                string EncryptionKey = Encrypt_Function.Item1;
                string EncryptedPassword = Encrypt_Function.Item2;
                //Passing Key along with Hashed Password to AES-256 Encrypt Function                      
                if (username != "" && EncryptedPassword != "" && email != "" && salt != "" && EncryptionKey != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_adduser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@MasterPassword", EncryptedPassword);
                    cmd.Parameters.AddWithValue("Pash", salt);
                    cmd.Parameters.AddWithValue("@Key", EncryptionKey);
                    int i = cmd.ExecuteNonQuery();
                    return i.ToString();
                }
                return "Not All Fields are Filled :(";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }                        
        }
        #endregion

        #region
        public string UpdatePassword(Password password,int passwordId)
        {
            try
            {
                EncandDecr encandDecr = new EncandDecr();
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                string pass = password.Pass;
                string confirmPassword = password.ConfirmPassword;
                string encryptedPassword = encandDecr.Encrypt_Other(CurrentUser.Key, pass);
                string encryptedConfirmPassword = encandDecr.Encrypt_Other(CurrentUser.Key, confirmPassword);
                string emailorUser = password.EmailorUsername;
                string url = password.Url;
                DateTime DateofCreation = password.TimeofReg;
                if (passwordId != 0 && emailorUser != "" && encryptedPassword != "" && encryptedConfirmPassword != "" && url != "" && DateofCreation != null)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_fullupdatepassword";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PasswordId", passwordId);
                    cmd.Parameters.AddWithValue("@EmailOrUsername", emailorUser);
                    cmd.Parameters.AddWithValue("@Password", encryptedPassword);
                    cmd.Parameters.AddWithValue("@ConfirmPassword", encryptedConfirmPassword);
                    cmd.Parameters.AddWithValue("@Url", url);
                    cmd.Parameters.AddWithValue("@DateOfRegistration", DateofCreation);
                    int i = cmd.ExecuteNonQuery();
                    return i.ToString();
                }
                return "Not All Fields are Filled :(";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }            
        }

        #endregion

        #region

        public string UpdateUser(User user, int userId)
        { 
            try
            {                
                EncandDecr encandDecr = new EncandDecr();
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                string username = user.Username;
                string email = user.Email;
                string password = user.Password;
                if(CurrentUser.Key != "" && username != "" && email !="" && password != "")
                {
                    string masterpassword = encandDecr.Encrypt_Other(CurrentUser.Key, password);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_fullupdateuser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", masterpassword);
                    int i = cmd.ExecuteNonQuery();
                    return i.ToString();
                }
                return "Not All Fields are Filled :(";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

        #region

        public DataTable DisplayForUpdatePassword(int passwordId)
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("usp_updatepassword", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PasswordId", passwordId);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
        #endregion

        #region
        public DataTable DisplayForUpdateUser(int userId)
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("usp_updateuser", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region
        public bool SignIn(User user)
        {
            try
            {
                EncandDecr encandDecr = new EncandDecr();
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                string email = user.Email;
                string userPassword = user.Password;
                string password = "";
                //string Plainpash = "";
                string userKey = GetKeyWithEmail(email);                
                BEncryption bEncryption = new BEncryption();
                bool IsValid = false;
                if(email != "" && userPassword != "" && userKey != "")
                {
                    SqlCommand cmd = new SqlCommand("usp_signin", sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        password = sdr.GetString(3);
                        //Plainpash = sdr.GetString(4);
                        IsValid = true;
                    }
                    if (IsValid)
                    {
                        string decryptedPassword = encandDecr.Decrypt(userKey, password);
                        bool verifyHash = bEncryption.VerifyPassword(userPassword, decryptedPassword);
                        if (verifyHash == true)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                return false;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }

        #endregion

        #region

        public string SignUp(User user)
        {
            try
            {
                EncandDecr encandDecr = new EncandDecr();
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                string username = user.Username;
                string password = user.Password;
                string email = user.Email;
                //Initiating BCrypt 
                BEncryption bcrypt = new BEncryption();
                //Generating Salt
                string salt = bcrypt.GetRandomSalt();
                //Sending Plain Text(Password),Salt to Hashing Function 
                string hash = bcrypt.BCryptHash(password, salt);
                //Sending Hashed Password String to AES-256 Encryption                        
                //Passing Key along with Hashed Password to AES-256 Encrypt Function
                var Encrypt_Function = encandDecr.Encrypt(hash);
                string EncryptionKey = Encrypt_Function.Item1;
                string EncryptedPassword = Encrypt_Function.Item2;
                if (username != "" && EncryptedPassword != "" && email != "" && EncryptionKey != "" && hash != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_signup";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", EncryptedPassword);
                    cmd.Parameters.AddWithValue("Pash", salt);
                    cmd.Parameters.AddWithValue("@Key", EncryptionKey);
                    cmd.Parameters.AddWithValue("@SecretKey", EncryptSecretKey());
                    int i = cmd.ExecuteNonQuery();
                    return i + "";
                }
                else
                {
                    return "Not All Fields are Filled :(";
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion

        #region

        public DataTable GetUser(User user)
        {
        try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand("usp_signin", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", user.Email);
                DataTable dt = new DataTable();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    dt.Load(sdr);
                    DataRow userRow = dt.Rows[0];
                    //Passing Values From User.dbo to Current User to Use at Mona.Form                
                    CurrentUser.UserId = Convert.ToInt32(userRow["UserId"]);
                    CurrentUser.Email = userRow["Email"].ToString();
                    CurrentUser.Key = userRow["Key"].ToString();
                }
                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        #endregion

        #region
        public DataTable PasswordDetails()
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("Select PasswordId,EmailorUsername,Password,ConfirmPassword,Url,DateofRegistration from Password where UserId='" + CurrentUser.UserId + "'", sqlcon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                sqlcon.Close();
                return dt;
            }            
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region
        public DataTable UserDetails()
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                SqlCommand sqlcmd = new SqlCommand("UserDetails", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dt.Load(sqlcmd.ExecuteReader());
                return dt;
            }            
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region
        public string GetKeyWithEmail(string email)
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                if(email != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_getKey";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader["Key"].ToString();
                    }
                    sqlcon.Close();
                    return " ";
                }
                return " ";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion

        #region
        public string GetPasswordCount()
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                if(CurrentUser.UserId >= 0)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_countrows";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", CurrentUser.UserId);
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader["Count"].ToString();
                    }
                    sqlcon.Close();
                    return " ";
                }
                return " ";
                
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            
        }
        #endregion

        #region
        public string GetUsersCount()
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "usp_countusers";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader["Count"].ToString();
                }
                sqlcon.Close();
                return " ";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            
        }
        #endregion

        #region
        //Check Existing Email on DB
        public DataTable SignupEmailCheck(string email)
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                if(email != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_EmailCheck";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                    return dt;
                }
                return null;                                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        #endregion


        #region
        public DataTable SignupUsernameCheck(string username)
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                if(username != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_UsernameCheck";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                    return dt;
                }
                return null;
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        #endregion

        #region
        //Show on MyAccount
        public string GetUsernameFromEmail()
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                if(CurrentUser.Email != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_AccountEmail";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", CurrentUser.Email);
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader["Username"].ToString();
                    }
                    sqlcon.Close();
                    return " ";
                }
                return "User's Email Not Found :(";               
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            
        }
        #endregion

        #region
        //For PasswordReset
        public string GetMasterPassword()
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                if(CurrentUser.UserId >= 0)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_recoverMasterPassword";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", CurrentUser.UserId);
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader["MasterPassword"].ToString();
                    }
                    sqlcon.Close();
                    return " ";
                }
                return " ";
                
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            
        }
        #endregion


        #region
        public string DeletePassword(Password password)
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "usp_deletepassword";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PasswordId", password.PasswordId);
                int i = cmd.ExecuteNonQuery();
                return i.ToString();
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            
        }
        #endregion


        #region
        public string DeleteUser(User user)
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "usp_deleteuser";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", user.UserId);
                int i = cmd.ExecuteNonQuery();
                return i.ToString();
            }
            catch(Exception ex)
            {
                return ex.Message;
            }            
        }
        #endregion

        #region
        public string getPassword(string email,int passwordId)
        {
            try
            {
                EncandDecr encandDecr = new EncandDecr();
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                if(email!= "" && passwordId > 0)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    string userKey = GetKeyWithEmail(email);
                    cmd.CommandText = "usp_getPassword";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PasswordId", passwordId);
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    string encpassword;
                    string decPassword;
                    if (reader.Read())
                    {
                        encpassword = reader["Password"].ToString();
                        decPassword = encandDecr.Decrypt(userKey, encpassword);
                        return decPassword;
                    }
                    sqlcon.Close();
                    return "";
                }
                else
                {
                    return "Email or Password Id is wrong.";
                }
                
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        #endregion


        #region
        private string EncryptSecretKey()
        {
            try
            {
                ResetKeyFile resetKeyFile = new ResetKeyFile();
                string key = resetKeyFile.GenerateSecretKey();
                return key;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion


        #region
        public string GetKeyFromPassword()
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                if (CurrentUser.Email != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_GetKeyForPassword";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", CurrentUser.Email);
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader["SecretKey"].ToString();
                    }
                    sqlcon.Close();
                    return " ";
                }
                return " ";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion

        #region
        public string GetKeyForResetPassword(string email)
        {
            try
            {
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                if(email != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_GetKeyForPassword";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader["SecretKey"].ToString();
                    }
                    sqlcon.Close();
                    return " ";
                }
                return " ";
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
        #endregion

        #region
        //Password Reset
        public string PasswordReset(User user)
       {
            try
            {
                EncandDecr encandDecr = new EncandDecr();
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                string password = user.Password;
                string email = user.Email;
                //Initiating BCrypt 
                BEncryption bcrypt = new BEncryption();
                //Generating Salt
                string salt = bcrypt.GetRandomSalt();
                //Sending Plain Text(Password),Salt to Hashing Function 
                string hash = bcrypt.BCryptHash(password, salt);
                //Sending Hashed Password String to AES-256 Encryption                        
                //Passing Key along with Hashed Password to AES-256 Encrypt Function
                var Encrypt_Function = encandDecr.Encrypt(hash);
                string EncryptionKey = Encrypt_Function.Item1;
                string EncryptedPassword = Encrypt_Function.Item2;
                if (EncryptedPassword != "" && email != "" && EncryptionKey != "" && hash != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_PasswordReset";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", EncryptedPassword);
                    cmd.Parameters.AddWithValue("Pash", hash);
                    cmd.Parameters.AddWithValue("@Key", EncryptionKey);
                    cmd.Parameters.AddWithValue("@SecretKey", EncryptSecretKey());
                    int i = cmd.ExecuteNonQuery();
                    return i.ToString();
                }
                return "Something Went Wrong";
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        #endregion

        #region
        public string AdminUserUpdate(User user)
        {
            try
            {
                EncandDecr encandDecr = new EncandDecr();
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                string password = user.Password;
                string email = user.Email;
                string username = user.Username;
                //Initiating BCrypt 
                BEncryption bcrypt = new BEncryption();
                //Generating Salt
                string salt = bcrypt.GetRandomSalt();
                //Sending Plain Text(Password),Salt to Hashing Function 
                string hash = bcrypt.BCryptHash(password, salt);
                //Sending Hashed Password String to AES-256 Encryption                        
                //Passing Key along with Hashed Password to AES-256 Encrypt Function
                var Encrypt_Function = encandDecr.Encrypt(hash);
                string EncryptionKey = Encrypt_Function.Item1;
                string EncryptedPassword = Encrypt_Function.Item2;
                if (EncryptedPassword != "" && email != "" && EncryptionKey != "" && hash != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_AdmintoUserUpdate";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", EncryptedPassword);
                    cmd.Parameters.AddWithValue("Pash", hash);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Key", EncryptionKey);
                    cmd.Parameters.AddWithValue("@SecretKey", EncryptSecretKey());
                    int i = cmd.ExecuteNonQuery();
                    return i.ToString();
                }
                return " ";
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        #endregion

        #region
        public string ResetPassword(User user)
        {
            try
            {
                EncandDecr encandDecr = new EncandDecr();
                SqlConnection sqlcon = new SQLServerConnection().Connect();
                sqlcon.Open();
                string password = user.Password;
                string email = user.Email;                
                //Initiating BCrypt 
                BEncryption bcrypt = new BEncryption();
                //Generating Salt
                string salt = bcrypt.GetRandomSalt();
                //Sending Plain Text(Password),Salt to Hashing Function 
                string hash = bcrypt.BCryptHash(password, salt);
                //Sending Hashed Password String to AES-256 Encryption                        
                //Passing Key along with Hashed Password to AES-256 Encrypt Function
                var Encrypt_Function = encandDecr.Encrypt(hash);
                string EncryptionKey = Encrypt_Function.Item1;
                string EncryptedPassword = Encrypt_Function.Item2;
                if (EncryptedPassword != "" && email != "" && EncryptionKey != "" && hash != "")
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlcon;
                    cmd.CommandText = "usp_ResetPassword";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", EncryptedPassword);
                    cmd.Parameters.AddWithValue("Pash", hash);                    
                    cmd.Parameters.AddWithValue("@Key", EncryptionKey);
                    cmd.Parameters.AddWithValue("@SecretKey", EncryptSecretKey());
                    int i = cmd.ExecuteNonQuery();
                    return i.ToString();
                }
                return " ";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion
    }
}

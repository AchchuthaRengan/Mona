using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BO;
using DBLL;

namespace DBLL
{
    public class DBService
    {
        public void InsertPassword(Password password)
        {            
            SqlConnection sqlcon = new SQLServerConnection().Connect();
            sqlcon.Open();
            string pass = password.Pass;
            string confirmPassword = password.ConfirmPassword;
            string encryptedPassword;
            string encryptedConfirmPassword;
            //using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            //{
            //    UTF8Encoding utf8 = new UTF8Encoding();
            //    byte[] password1 = md5.ComputeHash(utf8.GetBytes(pass));
            //    byte[] cnfmPassword = md5.ComputeHash(utf8.GetBytes(confirmPassword));
            //    encryptedPassword = Convert.ToBase64String(password1);
            //    encryptedConfirmPassword = Convert.ToBase64String(cnfmPassword);
            //}
            encryptedPassword = Eramake.eCryptography.Encrypt(pass);
            encryptedConfirmPassword = Eramake.eCryptography.Encrypt(confirmPassword);
            string emailorUser = password.EmailorUsername;                        
            string url = password.Url;
            //int userId = password.UserId;
            DateTime DateofCreation = password.TimeofReg;

            if(emailorUser!= "" & pass != "" && confirmPassword != "" && url != "")
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
                cmd.ExecuteNonQuery();
            }
            else
            {
                Console.WriteLine("Exception!!!!!!");
            }

        }

        public void UpdatePassword(Password password,int passwordId)
        {
            SqlConnection sqlcon = new SQLServerConnection().Connect();
            sqlcon.Open();            
            string pass = password.Pass;
            string confirmPassword = password.ConfirmPassword;
            string encryptedPassword = Eramake.eCryptography.Encrypt(pass);
            string encryptedConfirmPassword = Eramake.eCryptography.Encrypt(confirmPassword);            
            string emailorUser = password.EmailorUsername;
            string url = password.Url;
            DateTime DateofCreation = password.TimeofReg;
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
            cmd.ExecuteNonQuery();
        }

        public DataTable DisplayForUpdatePassword(int passwordId)
        {
            SqlConnection sqlcon = new SQLServerConnection().Connect();
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("usp_updatepassword", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PasswordId", passwordId);
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            return dt;
        }

        public DataTable SignIn(User user)
        {
            SqlConnection sqlcon = new SQLServerConnection().Connect();
            sqlcon.Open();
            string decryptedPassword = Eramake.eCryptography.Encrypt(user.Password);
            SqlCommand cmd = new SqlCommand("usp_signin", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Password", decryptedPassword);
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            if(sdr.HasRows)
            {
                dt.Load(sdr);
                DataRow userRow = dt.Rows[0];
                //Passing Values From User.dbo to Current User to Use at Mona.Form
                CurrentUser.UserId = Convert.ToInt32(userRow["UserId"]);
                CurrentUser.Email = userRow["Email"].ToString();
            }            
            return dt;
        }
        
        public void SignUp(User user)
        {
            SqlConnection sqlcon = new SQLServerConnection().Connect();
            sqlcon.Open();
            string username = user.Username;
            string password = user.Password;
            string encryptedPassword = Eramake.eCryptography.Encrypt(password);
            string email = user.Email;
            if (username != "" && password != "" && email != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "usp_signup";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", encryptedPassword);                
                cmd.ExecuteNonQuery();
            }
            else
            {
                Console.WriteLine("Exception!!!!!!");
            }
        }

        public DataView PasswordDetails()
        {
            SqlConnection sqlcon = new SQLServerConnection().Connect();
            sqlcon.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("Select PasswordId,EmailorUsername,Password,ConfirmPassword,Url,DateofRegistration from Password where UserId='"+CurrentUser.UserId+"'",sqlcon);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            DataView dv = ds.Tables[0].DefaultView;
            sqlcon.Close();
            return dv;
        }

        public void DeletePassword(Password password)
        {
            SqlConnection sqlcon = new SQLServerConnection().Connect();
            sqlcon.Open();                        
             SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "usp_deletepassword";
                cmd.CommandType = CommandType.StoredProcedure;               
                cmd.Parameters.AddWithValue("@PasswordId", password.PasswordId);
                cmd.ExecuteNonQuery();                                       
        }

        public string RecoverPassword(User user)
        {
            SqlConnection sqlcon = new SQLServerConnection().Connect();
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlcon;
            cmd.CommandText = "usp_passwordrecover";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmailorUsername", user.Email);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();            
            if(reader.Read())
            {
                return reader["MasterPassword"].ToString();
            }
            sqlcon.Close();
            return " ";               
        }
    }
}

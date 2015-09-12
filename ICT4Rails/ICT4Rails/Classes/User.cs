using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Security.Cryptography;

namespace ICT4Rails
{
    public class User
    {
        public string UserName { get; set; }
        public string EncryptedPassword { get; set; }
        public string Role { get; set; }

        public User(string username, string password, string role)
        {
            UserName = username;
            EncryptedPassword = password;
            Role = role;
        }

        public bool CreateUser(string username, string password)
        {
            OracleConnection connection = DatabaseManager.Connect();
            Guid userguid = Guid.NewGuid();
            string hashedPassword = CreateHash(password, userguid.ToString());

            OracleTransaction trans = connection.BeginTransaction();
            string insertstring = "insert into USERS(USERNAME, PASSWORD, GUID, USERTYPE) values (:username, :password, :userguid, :usertype)";
            OracleCommand command = new OracleCommand(insertstring, connection);
            OracleParameter[] parameters = new OracleParameter[] {
             new OracleParameter("username",username),
             new OracleParameter("password",hashedPassword),
             new OracleParameter("userguid",userguid.ToString()),
             new OracleParameter("userguid","ADMIN")
            };
            command.Parameters.AddRange(parameters);
            try
            {
                command.ExecuteNonQuery();
                trans.Commit();
            }
            catch
            {
                return false;
            }

            DatabaseManager.Close();
            return true;
        }

        public static User AuthenticateUser(string username, string password)
        {
            OracleConnection connection = DatabaseManager.Connect();

            string readstring = "SELECT PASSWORD,GUID,USERTYPE FROM USERS WHERE USERNAME=:username";

            OracleCommand command = new OracleCommand(readstring, connection);
            OracleParameter parameter = new OracleParameter("username", username);
            command.Parameters.Add(parameter);

            OracleDataReader reader = command.ExecuteReader();

            string correctPassword = "";
            string userguid = "";
            string usertype = "";
            while (reader.Read())
            {
                correctPassword = reader["PASSWORD"].ToString();
                userguid = reader["GUID"].ToString();
                usertype = reader["USERTYPE"].ToString();
            }
            connection.Close();

            password = CreateHash(password, userguid);
            User user = new User(username, password, usertype);

            if (correctPassword == password)
            {
                return user;
            }
            DatabaseManager.Close();
            return null;
        }

        private static string CreateHash(string password, string userguid)
        {
            //var sha = SHA1.Create(); //Create new hash object.
            var sha = SHA512.Create();
            byte[] bytes = Encoding.ASCII.GetBytes(password + userguid); //Creates a byte array of the string.
            byte[] hashedbytes = sha.ComputeHash(bytes); //Creates a hashed byte array.

            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < hashedbytes.Length; i++)
            {
                sb.Append(hashedbytes[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}

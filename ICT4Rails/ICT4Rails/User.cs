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
        string UserName { get; set; }
        string EncryptedPassword { get; set; }
        OracleCommand command;
        OracleConnection connection;
        DatabaseManager DBM;

        public User(string username, string password)
        {
            UserName = username;
            EncryptedPassword = password;
        }

        public bool CreateUser(string username, string password)
        {
            connection = DBM.Connect();
            Guid userguid = Guid.NewGuid();
            string hashedPassword = CreateHash(password, userguid.ToString());

            OracleTransaction trans = connection.BeginTransaction();
            string insertstring = "insert into USERS(USERNAME, PASSWORD, USERGUID) values (:username, :password, :userguid)";
            command = new OracleCommand(insertstring, connection);
            OracleParameter[] parameters = new OracleParameter[] {
             new OracleParameter("username",username),
             new OracleParameter("password",hashedPassword),
             new OracleParameter("userguid",userguid.ToString())
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

            connection.Close();
            return true;
        }

        public User AuthenticateUser(string username, string password)
        {
            connection = DBM.Connect();

            string readstring = "SELECT PASSWORD,USERGUID FROM USERS WHERE USERNAME=:username";

            command = new OracleCommand(readstring, connection);
            OracleParameter parameter = new OracleParameter("username", username);
            command.Parameters.Add(parameter);

            OracleDataReader reader = command.ExecuteReader();

            string correctPassword = "";
            string userguid = "";
            while (reader.Read())
            {
                correctPassword = reader["PASSWORD"].ToString();
                userguid = reader["USERGUID"].ToString();
            }
            connection.Close();

            password = CreateHash(password, userguid);
            User user = new User(username, password);

            if (correctPassword == password)
            {
                return user;
            }
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

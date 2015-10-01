﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Security.Cryptography;

namespace ICT4Rails
{
    public class Login
    {
        public string UserName { get; set; }
        public string EncryptedPassword { get; set; }
        public string Role { get; set; }

        public Login(string username, string password, string role)
        {
            UserName = username;
            EncryptedPassword = password;
            Role = role;
        }

        public static bool CreateUser(string username, string password, string role)
        {
            Guid userguid = Guid.NewGuid();
            string hashedPassword = CreateHash(password, userguid.ToString());
            string insertstring = "insert into USERS(USERNAME, PASSWORD, GUID, USERTYPE) values (:username, :password, :userguid, :usertype)";
            OracleParameter[] parameters = new OracleParameter[] 
            {
                new OracleParameter("username",username),
                new OracleParameter("password",hashedPassword),
                new OracleParameter("userguid",userguid.ToString()),
                new OracleParameter("userguid",role)
            };
            DatabaseManager.ExecuteInsertQuery(insertstring, parameters);

            //DatabaseManager.Close();
            return true;
        }

        public static void RemoveUser(string username)
        {
            string deletestring = "DELETE FROM USERS WHERE USERNAME=:username";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("username", username)
            };
            DatabaseManager.ExecuteDeleteQuery(deletestring, parameters);
        }

        public static Login AuthenticateUser(string username, string password)
        {
            string readstring = "SELECT PASSWORD,GUID,USERTYPE FROM USERS WHERE USERNAME=:username";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("username", username)
            };
            OracleDataReader reader = DatabaseManager.ExecuteReadQuery(readstring, parameters);

            string correctPassword = "";
            string userguid = "";
            string usertype = "";
            while (reader.Read())
            {
                correctPassword = reader["PASSWORD"].ToString();
                userguid = reader["GUID"].ToString();
                usertype = reader["USERTYPE"].ToString();
            }
            DatabaseManager.Close();

            password = CreateHash(password, userguid);
            if (correctPassword == password)
            {
				Login user = new Login(username, password, usertype);
                return user;
            }
            return null;
        }

        private static string CreateHash(string password, string userguid)
        {
            var sha = SHA512.Create(); //Creates a new SHA512 hash
            byte[] bytes = Encoding.ASCII.GetBytes(password + userguid); //Creates a byte array of the string.
            byte[] hashedbytes = sha.ComputeHash(bytes); //Creates a hashed byte array.

            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < hashedbytes.Length; i++)
            {
                sb.Append(hashedbytes[i].ToString("X2"));
            }

            return sb.ToString();
        }

        public static List<Login> GetAllUsers()
        {
            List<Login> users = new List<Login>();
            string readstring = "SELECT USERNAME,PASSWORD,GUID,USERTYPE FROM USERS";
            OracleDataReader reader = DatabaseManager.ExecuteReadQuery(readstring, null);

            string username;
            string password;
            string role;
            while (reader.Read())
            {
                username = reader["USERNAME"].ToString();
                password = reader["PASSWORD"].ToString();
                role = reader["USERTYPE"].ToString();
                users.Add(new Login(username, password, role));
            }

            return users;
        }
    }
}
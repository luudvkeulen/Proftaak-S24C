using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Security.Cryptography;
using System.Data;

namespace ICT4Rails
{
    public class UserManager
    {
		public List<User> Users = new List<User>();

        public static bool CreateUser(string name, string surname, string username,string employeetype, string password, string role)
        {
            Guid userguid = Guid.NewGuid();
            string hashedPassword = CreateHash(password, userguid.ToString());
            OracleParameter[] parameters1 = new OracleParameter[]
            {
                new OracleParameter("name", name),
                new OracleParameter("surname", surname),
                new OracleParameter("employeetype", employeetype),
            };
            DatabaseManager.ExecuteInsertQuery(DatabaseQuerys.query["CreateEmployee"], parameters1);

            DataTable DT = DatabaseManager.ExecuteReadQuery("SELECT EMPLOYEE_SEQ.nextval from dual", null);

            int currentvalue = 0;

            foreach(DataRow DR in DT.Rows)
            {
                currentvalue = Convert.ToInt32(DR["NEXTVAL"]);
            }

            OracleParameter[] parameters2 = new OracleParameter[]
            {
                new OracleParameter("username", username),
                new OracleParameter("password", hashedPassword),
                new OracleParameter("guid", userguid.ToString()),
                new OracleParameter("usertype", role)
                //new OracleParameter("userid", currentvalue)
            };
            DatabaseManager.ExecuteInsertQuery(DatabaseQuerys.query["CreateLogin"], parameters2);
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

        public static Login AuthenticateUser(string Username, string password)
        {
            //string readstring = "SELECT PASSWORD,GUID,USERTYPE FROM USERS WHERE USERNAME=:username";
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("username", Username)
            };
            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetLogin"], parameters);

            string name;
            string surname;
            string employeetype;
            string username;
            string correctpassword = "";
            string role;
            string guid = "";
            Login login = null;
            foreach (DataRow DR in DT.Rows)
            {
                name = DR["NAME"].ToString();
                surname = DR["SURNAME"].ToString();
                employeetype = DR["EMPLOYEETYPE"].ToString();
                username = DR["USERNAME"].ToString();
                correctpassword = DR["PASSWORD"].ToString();
                role = DR["USERTYPE"].ToString();
                guid = DR["GUID"].ToString();
                login = new Login(username, correctpassword, role, name, surname, employeetype);
            }

            password = CreateHash(password, guid);
            if (correctpassword == password)
            {
                return login;
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

        public static List<Login> GetAllLogins()
        {
            List<Login> logins = new List<Login>();
            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetAllLogins"], null);

            string name;
            string surname;
            string employeetype;
            string username;
            string password;
            string role;
            foreach (DataRow DR in DT.Rows)
            {
                name = DR["NAME"].ToString();
                surname = DR["SURNAME"].ToString();
                employeetype = DR["EMPLOYEETYPE"].ToString();
                username = DR["USERNAME"].ToString();
                password = DR["PASSWORD"].ToString();
                role = DR["USERTYPE"].ToString();
                logins.Add(new Login(username, password, role, name, surname, employeetype));
            }

            return logins;
        }

        public static List<Login> GetAllUsers()
        {
            List<Login> logins = new List<Login>();
            string readstring = "SELECT USERNAME,PASSWORD,GUID,USERTYPE FROM LOGINS";
            DataTable DR = DatabaseManager.ExecuteReadQuery(readstring, null);
            return logins;
        }

        public static void CheckAdmin()
        {
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("username", "admin")
            };
            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetLogin"], parameters);

            if(DT.Rows.Count != 0)
            {
                return;
            }

            CreateUser("admin", "admin", "admin", "admin", "admin", "ADMIN");
        }
    }
}

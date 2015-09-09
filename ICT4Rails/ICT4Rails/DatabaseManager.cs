using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;

namespace ICT4Rails
{
    public class DatabaseManager
    {
        OracleConnection Connection;

        //http://stackoverflow.com/questions/12568100/connecting-to-oracle-database-through-c
        //Website used for the Database Manager.
        public void Connect()
        {
            if (Connection.State != ConnectionState.Open)
            {
                Connection = new OracleConnection();
                Connection.ConnectionString = "User Id=<username>;Password=<password>;Data Source=<datasource>";
                Connection.Open();
                Console.WriteLine("Connected to Oracle" + Connection.ServerVersion);
            }
        }

        public void Close()
        {
            if(Connection.State == ConnectionState.Open)
            {
                Connection.Close();
                Connection.Dispose();
            }
        }
    }
}

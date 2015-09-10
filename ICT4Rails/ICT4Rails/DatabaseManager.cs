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
            Connection = new OracleConnection();
            if (Connection.State != ConnectionState.Open)
            {
                Connection.ConnectionString = "Data Source=fhictora01.fhict.local;User Id=dbi318583;Password=PTS18;";
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

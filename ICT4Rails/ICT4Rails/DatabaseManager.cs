using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace ICT4Rails
{
    public static class DatabaseManager
    {
        static OracleConnection Connection;

        //http://stackoverflow.com/questions/12568100/connecting-to-oracle-database-through-c
        //Website used for the Database Manager.
        public static OracleConnection Connect()
        {
            Connection = new OracleConnection();
            if (Connection.State != ConnectionState.Open)
            {
                //Connection.ConnectionString = "Data Source=fhictora01.fhict.local;User Id=dbi318583;Password=PTS18;";
                Connection.ConnectionString = "DATA SOURCE = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = fhictora01.fhict.local)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = fhictora))); PASSWORD = PTS18; USER ID = dbi318583";
                try
                {
                    Connection.Open();
                }
                catch (OracleException OE)
                {
                    Console.WriteLine(OE.Message);
                    return null;
                }
                Console.WriteLine("Connected to Oracle" + Connection.ServerVersion);
            }
            return Connection;
        }

        public static void Close()
        {
            if(Connection.State == ConnectionState.Open)
            {
                try
                {
                    Connection.Close();
                    Connection.Dispose();
                }
                catch (OracleException OE)
                {
                    Console.WriteLine(OE.Message);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace ICT4Rails
{
    public static class DatabaseManager
    {
        private static OracleConnection connection;
        public static OracleConnection Connection
        {
            get
            {
                if ( (connection != null) && (connection.State != ConnectionState.Open) )
                {
                    connection = new OracleConnection(ConfigurationManager.ConnectionStrings["DBC"].ConnectionString);
                    connection.Open();
                }
                return connection;
            }
        }

        //http://stackoverflow.com/questions/12568100/connecting-to-oracle-database-through-c
        //Website used for the Database Manager.
        /*public static OracleConnection Connect()
        {
            Connection = new OracleConnection();
            if (Connection.State != ConnectionState.Open)
            {
                Connection.ConnectionString = ConfigurationManager.ConnectionStrings["DBC"].ConnectionString;
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
        }*/

        public static OracleDataReader ExecuteReadQuery(string sqlquery, OracleParameter[] parameters)
        {
            OracleCommand command = new OracleCommand(sqlquery, Connection);

            if(parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            
            OracleDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static void ExecuteInsertQuery(string sqlquery, OracleParameter[] parameters)
        {
            OracleConnection connection = Connection;
            OracleTransaction transaction = connection.BeginTransaction();
            OracleCommand command = new OracleCommand(sqlquery, connection);

            if(parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            
            try
            {
                command.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (OracleException OE)
            {
                Console.WriteLine(OE.Message);
            }
            connection.Close();
        }

        public static void ExecuteDeleteQuery(string sqlquery, OracleParameter[] parameters)
        {
            using (Connection)
            using (OracleTransaction OT = Connection.BeginTransaction())
            {
                OracleCommand command = new OracleCommand(sqlquery, connection);
                if(parameters.Count() != 0)
                {
                    command.Parameters.AddRange(parameters);
                }

                try
                {
                    command.ExecuteNonQuery();
                    OT.Commit();
                }
                catch (OracleException OE)
                {
                    Console.WriteLine(OE.Message);
                }
            }
        }

        public static bool CheckConnection()
        {
            using (Connection)
            {
                return true;
            }
            return false;
        }
    }
}

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
    public class DatabaseManager
    {

        //http://stackoverflow.com/questions/12568100/connecting-to-oracle-database-through-c
        //Website used for the Database Manager.
        public static OracleConnection Connect()
        {
            OracleConnection Connection = new OracleConnection();
            if (Connection.State != ConnectionState.Open)
            {
                ConfigurationManager.
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
        }

        public static bool Close(OracleConnection Connection)
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
                    return false;
                }
            }
            return true;
        }

        public static OracleDataReader ExecuteReadQuery(string sqlquery, OracleParameter[] parameters)
        {
            OracleConnection connection = Connect();
            //OracleTransaction transaction = connection.BeginTransaction();
            OracleCommand command = new OracleCommand(sqlquery, connection);

            if(parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            
            OracleDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static void ExecuteInsertQuery(string sqlquery, OracleParameter[] parameters)
        {
            OracleConnection connection = Connect();
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
            OracleConnection connection = Connect();
            OracleTransaction transaction = connection.BeginTransaction();
            OracleCommand command = new OracleCommand(sqlquery, connection);

            if (parameters != null)
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
    }
}

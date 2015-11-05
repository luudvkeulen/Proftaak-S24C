using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT4Rails
{
	public class TramManager
	{
		private List<Tram> trams = new List<Tram>();
		private List<Sector> sectors = new List<Sector>();

		public void ClearSector(Sector sector)
		{

		}
		public void AddTramToSector(Tram tram, Sector sector, DateTime beginDate, DateTime endDate)
		{

		}

		public void SetTramDirty(Tram tram, String comment)
		{

		}
		public void SetTramMaintenens(Tram tram, String comment)
		{

		}

		//technieksysteem

		public void SetTramMaintenensFinished(Tram tram, DateTime startDate, DateTime endDate)
		{

		}
		public List<ListViewItem> GetMaintenensCleanListView()
		{
			List<ListViewItem> mList = new List<ListViewItem>();
			DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetTech"], null);
			foreach (DataRow row in DT.Rows)
			{
				ListViewItem item = new ListViewItem(row[0].ToString());
				item.SubItems.Add(row[1].ToString());
				item.SubItems.Add(row[2].ToString());

				if (row[3] == DBNull.Value)
				{
					item.SubItems.Add(row[3].ToString());
					item.SubItems.Add("Nee");
				}
				else
				{
					OracleParameter[] parameter = new OracleParameter[]
					{
						new OracleParameter("USERID", Convert.ToInt32(row[3]))
					};
					DataTable DT2 = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetCleanUser"], parameter);
					foreach (DataRow row2 in DT2.Rows)
					{
						item.SubItems.Add(row2[0].ToString());
					}
					item.SubItems.Add("Ja");
				}
				item.SubItems.Add(row[4].ToString());

				mList.Add(item);
			}
			return mList;
		}
		//Schoonmaaksysteem
		public void ChangeTramDate(string tramID, DateTime date)
		{
			OracleParameter[] parameters = new OracleParameter[]
			{
				new OracleParameter("datefinished", date.ToString()),
                new OracleParameter("tramid", tramID)
			};
			DatabaseManager.ExecuteInsertQuery(DatabaseQuerys.query["UpdateEndDate"], parameters);
		}
		public void SetTramFinished(string tramid, DateTime endDate, string employee, int type)
		{
            OracleParameter[] parameters2 = new OracleParameter[]
            {
                new OracleParameter("employee", employee)
            };

            int employeeid = 0;
            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetEmployee"], parameters2);
            foreach(DataRow DR in DT.Rows)
            {
                employeeid = Convert.ToInt32(DR[0]);
                break;
            }

            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("datefinished", endDate.ToString()),
                new OracleParameter("employeeid", employeeid),
                new OracleParameter("tramid", tramid),
                new OracleParameter("type", type)
            };

            DatabaseManager.ExecuteInsertQuery(DatabaseQuerys.query["maintenancefinished"], parameters);
		}
		public List<ListViewItem> GetTramCleanListView()
		{
			List<ListViewItem> mList = new List<ListViewItem>();
			DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetClean"], null);
			foreach (DataRow row in DT.Rows)
			{
				ListViewItem item = new ListViewItem(row[0].ToString());
				item.SubItems.Add(row[1].ToString());
				item.SubItems.Add(row[2].ToString());

				if (row[3] == DBNull.Value)
				{
					item.SubItems.Add(row[3].ToString());
					item.SubItems.Add("Nee");
				}
				else
				{
					OracleParameter[] parameter = new OracleParameter[]
					{
						new OracleParameter("USERID", Convert.ToInt32(row[3]))
					};
					DataTable DT2 = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetCleanUser"], parameter);
					foreach (DataRow row2 in DT2.Rows)
					{
						item.SubItems.Add(row2[0].ToString());
					}
					item.SubItems.Add("Ja");
				}
				item.SubItems.Add(row[4].ToString());

				mList.Add(item);
			}
			return mList;
		}

        public int[] GetReservedSector(int tramnumber)
        {
            OracleParameter[] OP = new OracleParameter[]
            {
                new OracleParameter("tramid", tramnumber)
            };
            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetReservedSector"], OP);
            int[] info = new int[2];
            foreach(DataRow DR in DT.Rows)
            {
                info[0] = Convert.ToInt32(DR[0]);
                info[1] = Convert.ToInt32(DR[1]);
            }

            return info;
        }

        public List<string> GetAllCleaners()
        {
            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetAllCleaners"], null);
            List<string> cleaners = new List<string>();
            foreach(DataRow DR in DT.Rows)
            {
                cleaners.Add(DR[0].ToString());
            }

            return cleaners;
        }

        public List<string> GetAllEngineers()
        {
            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetAllEngineers"], null);
            List<string> cleaners = new List<string>();
            foreach (DataRow DR in DT.Rows)
            {
                cleaners.Add(DR[0].ToString());
            }

            return cleaners;
        }

        public void AddIncoming(string tramid)
        {
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("tramid", tramid)
            };
            DatabaseManager.ExecuteInsertQuery(DatabaseQuerys.query["addtramtoincoming"], parameters);
        }

        public void CheckInTrain(string tramid)
        {
            OracleParameter[] parameters = new OracleParameter[]
            {
                new OracleParameter("tramid", tramid)
            };
            DatabaseManager.ExecuteInsertQuery(DatabaseQuerys.query["traincheckin"], parameters);
        }
    }
}

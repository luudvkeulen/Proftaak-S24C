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
		public void ChangeTramMaintenensDate(Tram tram, DateTime date)
		{

		}

		public void SetTramMaintenensFinished(Tram tram, DateTime startDate, DateTime endDate)
		{

		}
		public List<ListViewItem> GetMaintenensCleanListView()
		{
			List<ListViewItem> mList = new List<ListViewItem>();
			DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetTech"], null);
			foreach (DataRow row in DT.Rows)
			{
				ListViewItem item = new ListViewItem(row[9].ToString());
				item.SubItems.Add(row[0].ToString());
				item.SubItems.Add(row[1].ToString());
				item.SubItems.Add(row[3].ToString());
				if (row[2].ToString() == "0")
				{
					item.SubItems.Add("Nee");
				}
				else
				{
					item.SubItems.Add("Ja");
				}
				item.SubItems.Add(row[4].ToString());

				mList.Add(item);
			}
			return mList;
		}
		//Schoonmaaksysteem
		public void ChangeTramCleaningDate(string tramID, DateTime date)
		{
			OracleParameter[] parameters = new OracleParameter[]
			{
				new OracleParameter("datefinished", date.ToString("MM/dd/yyyy hh:mm:ss tt")),
                new OracleParameter("tramid", tramID)
			};
			DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["UpdateEndDateClean"], parameters);
		}
		public void SetTramCleaningFinished(Tram tram, DateTime startDate, DateTime endDate)
		{

		}
		public List<ListViewItem> GetTramCleanListView()
		{
			List<ListViewItem> mList = new List<ListViewItem>();
			DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetClean"], null);
			foreach (DataRow row in DT.Rows)
			{
				ListViewItem item = new ListViewItem(row[9].ToString());
				item.SubItems.Add(row[0].ToString());
				item.SubItems.Add(row[1].ToString());
				item.SubItems.Add(row[3].ToString());
				if (row[2].ToString() == "0")
				{
					item.SubItems.Add("Nee");
				}
				else
				{
					item.SubItems.Add("Ja");
				}
				item.SubItems.Add(row[4].ToString());

				mList.Add(item);
			}
			return mList;
		}

        public int GetReservedSector(int tramnumber)
        {
            OracleParameter[] OP = new OracleParameter[]
            {
                new OracleParameter("tramnumber", tramnumber)
            };
            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetReservedSector"], OP);
            int sector = 0;
            foreach(DataRow DR in DT.Rows)
            {
                sector = Convert.ToInt32(DR);
            }

            return sector;
        }
	}
}

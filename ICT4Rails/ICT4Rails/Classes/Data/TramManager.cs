using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		//Schoonmaaksysteem
		public void ChangeTramCleaningDate(Tram tram, DateTime date)
		{

		}
		public void SetTramCleaningFinished(Tram tram, DateTime startDate, DateTime endDate)
		{

		}

		public List<Maintenance> GetTramList()
		{
			List<Maintenance> mList = new List<Maintenance>();
			DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetClean"], null);
			foreach (DataRow row in DT.Rows)
			{

				//mList.Add(new Maintenance())
			}
			return mList;
		} 
	}
}

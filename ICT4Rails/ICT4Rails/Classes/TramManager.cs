using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Rails.Classes
{
	class TramManager
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
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Rails.Classes.Models
{
	public class Maintenance
	{
		public int TramNr { get; set; }
		public DateTime BeginDate { get; set; }
		public DateTime EndDate { get; set; }
		public string Cleaner { get; set; }
		public string Comment { get; set; }

		public Maintenance(int tramNr, DateTime beginDate, DateTime enddate, string cleaner, string comment)
		{
			TramNr = tramNr;
			BeginDate = beginDate;
			EndDate = enddate;
			Cleaner = cleaner;
			Comment = comment;
		}
	}
}

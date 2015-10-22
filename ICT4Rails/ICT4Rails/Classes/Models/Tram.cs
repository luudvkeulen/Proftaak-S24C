using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Rails
{
	public class Tram
	{
		public string Status { get; set; }
		public TramType TramType { get; set;}
		public Sector Sector { get; set; }
		public Tram(TramType tramType, Sector sector, string status)
		{
			TramType = tramType;
			Sector = sector;
			Status = status;
		}
	}
}

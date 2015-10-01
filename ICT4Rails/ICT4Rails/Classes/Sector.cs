using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Rails
{
	public class Sector
	{
		public bool Available { get; set; }
		public Rail Rail { get; set; }
		public int Position { get; set; }

		public Sector(Rail rail, int position, bool available)
		{
			Rail = rail;
			Position = position;
			Available = available;
		}
	}
}

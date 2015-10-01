using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Rails
{
	public class TramType
	{
		public string Name { get; set; }
		public string Specifications { get; set; }

		public TramType(string name, string specifications)
		{
			Name = name;
			Specifications = specifications;
		}
	}
}

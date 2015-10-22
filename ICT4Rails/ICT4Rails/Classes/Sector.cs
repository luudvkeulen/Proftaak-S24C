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

        private string gridLocation { get; set; }

		public Sector(Rail rail, int position, bool available)
		{
			Rail = rail;
			Position = position;
			Available = available;
		}

        public string GridLocation()
        {
            switch (Rail.Id) {
                case 38:
                    gridLocation = string.Format("0 - {0}", Position+1.ToString());
                    break;
                case 37:
                    gridLocation = string.Format("1 - {0}", Position+1.ToString());
                    break;
                case 36:
                    gridLocation = string.Format("2 - {0}", Position+1.ToString());
                    break;
                case 35:
                    gridLocation = string.Format("3 - {0}", Position+1.ToString());
                    break;
                case 34:
                    gridLocation = string.Format("4 - {0}", Position+1.ToString());
                    break;
                case 33:
                    gridLocation = string.Format("5 - {0}", Position+1.ToString());
                    break;
                case 32:
                    gridLocation = string.Format("6 - {0}", Position+1.ToString());
                    break;
                case 31:
                    gridLocation = string.Format("7 - {0}", Position+1.ToString());
                    break;
                case 30:
                    gridLocation = string.Format("8 - {0}", Position+1.ToString());
                    break;
                case 40:
                    gridLocation = string.Format("10 - {0}", Position + 1.ToString());
                    break;
                case 41:
                    gridLocation = string.Format("11 - {0}", Position + 1.ToString());
                    break;
                case 42:
                    gridLocation = string.Format("12 - {0}", Position + 1.ToString());
                    break;
                case 43:
                    gridLocation = string.Format("13 - {0}", Position + 1.ToString());
                    break;
                case 44:
                    gridLocation = string.Format("14 - {0}", Position + 1.ToString());
                    break;
                case 45:
                    gridLocation = string.Format("16 - {0}", Position + 1.ToString());
                    break;
                case 58:
                    gridLocation = string.Format("19 - {0}", Position + 1.ToString());
                    break;
                case 57:
                    gridLocation = string.Format("10 - {0}", Position + 1.ToString());
                    break;

            }
            return "";
        }
	}
}

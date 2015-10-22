using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Rails
{
	public class Sector
	{
		public Rail Rail { get; private set; }
		public int Position { get; private set; }
        public string GridLocation { get; private set; }

        public string TramID { get; set; }
        public bool Available { get; set; }

        public Sector(Rail rail, int position, bool available, string tramID)
		{
			Rail = rail;
			Position = position;
			Available = available;
            TramID = tramID;

            if(!Available)
            {
                TramID = "X";
            }

            GridLocationMethod();
		}

        private void GridLocationMethod()
        {
            switch (Rail.Id) {
                case 38:
                    GridLocation = string.Format("0 {0}", (Position + 1).ToString());
                    break;
                case 37:
                    GridLocation = string.Format("1 {0}", (Position + 1).ToString());
                    break;
                case 36:
                    GridLocation = string.Format("2 {0}", (Position + 1).ToString());
                    break;
                case 35:
                    GridLocation = string.Format("3 {0}", (Position + 1).ToString());
                    break;
                case 34:
                    GridLocation = string.Format("4 {0}", (Position + 1).ToString());
                    break;
                case 33:
                    GridLocation = string.Format("5 {0}", (Position + 1).ToString());
                    break;
                case 32:
                    GridLocation = string.Format("6 {0}", (Position + 1).ToString());
                    break;
                case 31:
                    GridLocation = string.Format("7 {0}", (Position + 1).ToString());
                    break;
                case 30:
                    GridLocation = string.Format("8 {0}", (Position + 1).ToString());
                    break;
                case 40:
                    GridLocation = string.Format("10 {0}", (Position + 1).ToString());
                    break;
                case 41:
                    GridLocation = string.Format("11 {0}", (Position + 1).ToString());
                    break;
                case 42:
                    GridLocation = string.Format("12 {0}", (Position + 1).ToString());
                    break;
                case 43:
                    GridLocation = string.Format("13 {0}", (Position + 1).ToString());
                    break;
                case 44:
                    GridLocation = string.Format("14 {0}", (Position + 1).ToString());
                    break;
                case 45:
                    GridLocation = string.Format("16 {0}", (Position + 1).ToString());
                    break;
                case 58:
                    GridLocation = string.Format("19 {0}", (Position + 1).ToString());
                    break;
                case 57:
                    GridLocation = string.Format("10 {0}", (Position + 1).ToString());
                    break;
            }
        }
	}
}

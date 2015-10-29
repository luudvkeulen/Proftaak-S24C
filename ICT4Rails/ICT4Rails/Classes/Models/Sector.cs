using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Rails
{
	public class Sector : IComparable<Sector>
	{
		public Rail Rail { get; private set; }
		public int Position { get; private set; }
        public string GridLocation { get; private set; }

        public string TramID { get; set; }
        public bool Available { get; set; }

        public bool Reserved { get; set; }

        public Sector(Rail rail, int position, bool available, string tramID, bool reserved)
		{
			Rail = rail;
			Position = position;
			Available = available;
            TramID = tramID;
            Reserved = reserved;

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
                    GridLocation = string.Format("18 {0}", (Position + 1).ToString());
                    break;
                case 57:
                    GridLocation = string.Format("0 {0}", (Position + 14).ToString());
                    break;
                case 56:
                    GridLocation = string.Format("1 {0}", (Position + 14).ToString());
                    break;
                case 55:
                    GridLocation = string.Format("2 {0}", (Position + 14).ToString());
                    break;
                case 54:
                    GridLocation = string.Format("3 {0}", (Position + 14).ToString());
                    break;
                case 53:
                    GridLocation = string.Format("4 {0}", (Position + 14).ToString());
                    break;
                case 52:
                    GridLocation = string.Format("5 {0}", (Position + 14).ToString());
                    break;
                case 51:
                    GridLocation = string.Format("6 {0}", (Position + 14).ToString());
                    break;
                case 64:
                    GridLocation = string.Format("7 {0}", (Position + 14).ToString());
                    break;
                case 63:
                    GridLocation = string.Format("8 {0}", (Position + 14).ToString());
                    break;
                case 62:
                    GridLocation = string.Format("9 {0}", (Position + 14).ToString());
                    break;
                case 61:
                    GridLocation = string.Format("10 {0}", (Position + 14).ToString());
                    break;
                case 74:
                    GridLocation = string.Format("12 {0}", (Position + 13).ToString());
                    break;
                case 75:
                    GridLocation = string.Format("13 {0}", (Position + 13).ToString());
                    break;
                case 76:
                    GridLocation = string.Format("14 {0}", (Position + 13).ToString());
                    break;
                case 77:
                    GridLocation = string.Format("15 {0}", (Position + 13).ToString());
                    break;
                case 12:
                    GridLocation = string.Format("18 {0}", (Position + 12).ToString());
                    break;
                case 13:
                    GridLocation = string.Format("18 {0}", (Position + 13).ToString());
                    break;
                case 14:
                    GridLocation = string.Format("18 {0}", (Position + 14).ToString());
                    break;
                case 15:
                    GridLocation = string.Format("18 {0}", (Position + 15).ToString());
                    break;
                case 16:
                    GridLocation = string.Format("18 {0}", (Position + 16).ToString());
                    break;
                case 17:
                    GridLocation = string.Format("18 {0}", (Position + 17).ToString());
                    break;
                case 18:
                    GridLocation = string.Format("18 {0}", (Position + 18).ToString());
                    break;
                case 19:
                    GridLocation = string.Format("18 {0}", (Position + 19).ToString());
                    break;
                case 20:
                    GridLocation = string.Format("18 {0}", (Position + 20).ToString());
                    break;
                case 21:
                    GridLocation = string.Format("18 {0}", (Position + 21).ToString());
                    break;
            }
        }

        public int CompareTo(Sector s)
        {
            if(Position < s.Position)
            {
                return -1;
            }
            if(Position == s.Position)
            {
                return 0;
            }

            return 1;
        }
	}
}

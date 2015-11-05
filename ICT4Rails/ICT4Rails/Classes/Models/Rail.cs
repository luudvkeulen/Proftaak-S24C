using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT4Rails
{
	public class Rail
	{
        Label RailLabel = new Label();

		public int ID { get; private set; }
        public string GridLocation { get; private set; }

		public Rail(int id)
		{
			ID = id;
            GridLocationMethod();
            
        }

        private void GridLocationMethod()
        {
            switch (ID)
            {
                case 38:
                    GridLocation = "0 0";
                    break;
                case 37:
                    GridLocation = "1 0";
                    break;
                case 36:
                    GridLocation = "2 0";
                    break;
                case 35:
                    GridLocation = "3 0";
                    break;
                case 34:
                    GridLocation = "4 0";
                    break;
                case 33:
                    GridLocation = "5 0";
                    break;
                case 32:
                    GridLocation = "6 0";
                    break;
                case 31:
                    GridLocation = "7 0";
                    break;
                case 30:
                    GridLocation = "8 0";
                    break;
                case 40:
                    GridLocation = "10 0";
                    break;
                case 41:
                    GridLocation = "11 0";
                    break;
                case 42:
                    GridLocation = "12 0";
                    break;
                case 43:
                    GridLocation = "13 0";
                    break;
                case 44:
                    GridLocation = "14 0";
                    break;
                case 45:
                    GridLocation = "16 0";
                    break;
                case 58:
                    GridLocation = "18 0";
                    break;
                case 57:
                    GridLocation = "0 13";
                    break;
                case 56:
                    GridLocation = "1 13";
                    break;
                case 55:
                    GridLocation = "2 13";
                    break;
                case 54:
                    GridLocation = "3 13";
                    break;
                case 53:
                    GridLocation = "4 13";
                    break;
                case 52:
                    GridLocation = "5 13";
                    break;
                case 51:
                    GridLocation = "6 13";
                    break;
                case 64:
                    GridLocation = "7 13";
                    break;
                case 63:
                    GridLocation = "8 13";
                    break;
                case 62:
                    GridLocation = "9 13";
                    break;
                case 61:
                    GridLocation = "10 13";
                    break;
                case 74:
                    GridLocation = "12 13";
                    break;
                case 75:
                    GridLocation = "13 13";
                    break;
                case 76:
                    GridLocation = "14 13";
                    break;
                case 77:
                    GridLocation = "15 13";
                    break;
                case 12:
                    GridLocation = "17 13";
                    break;
                case 13:
                    GridLocation = "17 14";
                    break;
                case 14:
                    GridLocation = "17 15";
                    break;
                case 15:
                    GridLocation = "17 16";
                    break;
                case 16:
                    GridLocation = "17 17";
                    break;
                case 17:
                    GridLocation = "17 18";
                    break;
                case 18:
                    GridLocation = "17 19";
                    break;
                case 19:
                    GridLocation = "17 20";
                    break;
                case 20:
                    GridLocation = "17 21";
                    break;
                case 21:
                    GridLocation = "17 22";
                    break;
            }
        }

        public Label AddRailLabel()
        {
            RailLabel.Dock = DockStyle.Fill;
            RailLabel.Margin = new Padding(1);

            RailLabel.Text = ID.ToString();

            RailLabel.ForeColor = Color.Black;
            RailLabel.TextAlign = ContentAlignment.MiddleCenter;
            RailLabel.Tag = GridLocation;
            RailLabel.BackColor = Color.Gray;

            //RailLabel.Click += new EventHandler(Sector_Click);

            return RailLabel;
        }

        /*
        private void Rail_Click(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            List<Sector> tempSectors = new List<Sector>();

            foreach (Sector s in sectors)
            {
                if (s.Rail.Id.ToString() == l.Text)
                {
                    tempSectors.Add(s);
                }
            }

            tempSectors.Sort();
            Sector tempSector = tempSectors[tempSectors.Count - 1];
            int totalPostitions = tempSector.Position;

            for (int i = 0; i < totalPostitions; i++)
            {
                tempSector = tempSectors[i];
                //de eerste tram weghalen
                if (tempSector.Position == 1)
                {
                    tempSector.TramID = null;
                    getLabel(tempSector);
                    //database update --> eerste sector weghalen
                }

                if ((totalPostitions + 1) == totalPostitions)
                {
                    Sector nextSector = tempSectors[i + 1];
                    tempSector.TramID = nextSector.TramID;

                    //database update
                }
            }

            UpdateGrid();
        }*/
    }
}

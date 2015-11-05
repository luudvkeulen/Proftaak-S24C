using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT4Rails
{
    public partial class BeheerSysteemForm : Form
    {
        List<Rail> rails = new List<Rail>();
        List<Sector> sectors = new List<Sector>();

        /// <summary>
        /// Constructor
        /// </summary>
        public BeheerSysteemForm()
        {
            InitializeComponent();

            //StandardRailLocation();

            GetAllSectors();

            UpdateGrid();
        }

        /// <summary>
        /// Back button to previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
        /// Update the Grid 
        /// </summary>
        private void UpdateGrid()
        {
            tlpGrid.Visible = false;
            tlpGrid.Controls.Clear();

            foreach(Sector s in sectors)
            {
                Label l = s.AddSectorLabel();

                string columnString = l.Tag.ToString();
                string rowString = l.Tag.ToString();

                int spaceIndex = columnString.IndexOf(" ");

                columnString = columnString.Substring(0, spaceIndex);
                rowString = rowString.Substring(spaceIndex);

                int column = Convert.ToInt32(columnString);
                int row = Convert.ToInt32(rowString);

                tlpGrid.Controls.Add(l, column, row);
            }
            tlpGrid.Visible = true;
        }

        /// <summary>
        /// Standard Rails for the grid
        /// </summary>
        private void StandardRailLocation()
        {
            int column = 0;
            int row = 0;

            for (int i = 38; i >= 30; i--)
            {
                AddRail(column + " " + row, i.ToString());
                column++;
            }

            column++;

            for (int i = 40; i <= 44; i++)
            {
                AddRail(column + " " + row, i.ToString());
                column++;
            }

            column++;

            AddRail(column + " " + row, "45");
            column += 2;

            AddRail(column + " " + row, "58");

            column = 0;
            row = 13;

            for (int i = 57; i >= 51; i--)
            {
                AddRail(column + " " + row, i.ToString());
                column++;
            }

            for (int i = 64; i >= 61; i--)
            {
                AddRail(column + " " + row, i.ToString());
                column++;
            }

            column++;

            for (int i = 74; i <= 77; i++)
            {
                AddRail(column + " " + row, i.ToString());
                column++;
            }

            column++;

            for (int i = 12; i <= 21; i++)
            {
                AddRail(column + " " + row, i.ToString());
                row++;
            }
        }
        
        /// <summary>
        /// Add a Rail to the grid
        /// </summary>
        /// <param name="location"></param>
        /// <param name="text"></param>
        private void AddRail(string location, string text)
        {/*
            Label l = AddLabel(location, text);

            l.BackColor = Color.LightGray;

            l.Click += new EventHandler(Rail_Click);

            railsLabel.Add(l);*/
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

        public void GetAllRails()
        {
            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetAllRails"], null);

            int railID;

            foreach(DataRow DR in DT.Rows)
            {
                railID = Convert.ToInt32(DR["RAILID"]);
                rails.Add(new Rail(railID));
            }
        }

        /// <summary>
        /// Get all the sectors from the database and place them in a list of sectors
        /// Then get all the sectors and place them in a label list
        /// </summary>
        public void GetAllSectors()
        {
            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetAllSectors"], null);

            int rail;
            int position;
            string available;
            bool availableSector;
            string reserved;
            bool reservedSector;
            string tramID;

            foreach (DataRow DR in DT.Rows)
            {
                rail = Convert.ToInt32(DR["RAILID"]);
                position = Convert.ToInt32(DR["POSITION"]);
                available = DR["AVAILABLE"].ToString();

                if (available == "1") { availableSector = true; }
                else { availableSector = false; }

                if (DR["TRAMID"].ToString() == "") { tramID = ""; }
                else { tramID = DR["TRAMID"].ToString(); }

                reserved = DR["ISRESERVED"].ToString();

                if (reserved == "1") { reservedSector = true; }
                else { reservedSector = false; }

                sectors.Add(new Sector(new Rail(rail), position, availableSector, tramID, reservedSector));
            }
        }
    }
}

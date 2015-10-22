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
        List<Label> railsLabel = new List<Label>();
        List<Label> sectorsLabel = new List<Label>();
        List<Sector> sectors = new List<Sector>();

        public BeheerSysteemForm()
        {
            InitializeComponent();

            StandardRailLocation();

            GetAllSectors();

            /*
            for (int row = 0; row < tlpGrid.RowCount; row++)
            {
                for (int column = 0; column < tlpGrid.ColumnCount; column++)
                {
                    if (column == 0 && row == 2)
                    {
                        AddSector("0 1", "12");
                    }
                }
            }
            */

            UpdateGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Add a new label
        /// </summary>
        /// <param name="ColumnRow"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private Label AddLabel(string ColumnRow, string text)
        {
            Label l = new Label();

            l.Dock = DockStyle.Fill;
            l.Margin = new Padding(1);
            l.Text = text;
            l.ForeColor = Color.Black;
            l.TextAlign = ContentAlignment.MiddleCenter;

            l.Tag = ColumnRow;

            return l;
        }

        /// <summary>
        /// Update the Grid 
        /// </summary>
        private void UpdateGrid()
        {
            tlpGrid.Controls.Clear();

            foreach (Label l in railsLabel)
            {
                string columnString = l.Tag.ToString();
                string rowString = l.Tag.ToString();

                int spaceIndex = columnString.IndexOf(" ");

                columnString = columnString.Substring(0, spaceIndex);
                rowString = rowString.Substring(spaceIndex);

                int column = Convert.ToInt32(columnString);
                int row = Convert.ToInt32(rowString);

                tlpGrid.Controls.Add(l, column, row);
            }

            foreach (Label l in sectorsLabel)
            {
                string columnString = l.Tag.ToString();
                string rowString = l.Tag.ToString();

                int spaceIndex = columnString.IndexOf(" ");

                columnString = columnString.Substring(0, spaceIndex);
                rowString = rowString.Substring(spaceIndex);

                int column = Convert.ToInt32(columnString);
                int row = Convert.ToInt32(rowString);

                tlpGrid.Controls.Add(l, column, row);
            }
        }

        /// <summary>
        /// Standard Rails for the grid
        /// </summary>
        private void StandardRailLocation()
        {
            int column = 0;
            int row = 0;

            for(int i = 38; i >= 30; i--)
            {
                AddRail(column + " " + row, i.ToString());
                column++;
            }

            column++;

            for(int i = 40; i <= 44; i++)
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
            
            for(int i = 57; i >= 51; i--)
            {
                AddRail(column + " " + row, i.ToString());
                column++;
            }

            for(int i = 64; i >= 61; i--)
            {
                AddRail(column + " " + row, i.ToString());
                column++;
            }

            column++;

            for(int i = 74; i <= 77; i++)
            {
                AddRail(column + " " + row, i.ToString());
                column++;
            }

            column++;

            for(int i = 12; i <= 21; i++)
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
        {
            Label l = AddLabel(location, text);

            l.BackColor = Color.LightGray;

            railsLabel.Add(l);
        }

        /// <summary>
        /// Add a Sector to the grid
        /// </summary>
        /// <param name="location"></param>
        /// <param name="text"></param>
        private void AddSector(string location)
        {
            Label l = AddLabel(location, " ");

            l.BackColor = Color.Red;
            l.Click += new EventHandler(Label_Click);

            sectorsLabel.Add(l);
        }

        /// <summary>
        /// EventHandler for click on label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label_Click(object sender, EventArgs e)
        {
            Label selectedLabel = null;

            foreach (Label l in sectorsLabel)
            {
                if(l == (Label)sender)
                {
                    selectedLabel = l;
                }
            }

            foreach(Sector s in sectors)
            {
                if(s.GridLocation == selectedLabel.Tag.ToString())
                {
                    SectorPropertiesForm spf = new SectorPropertiesForm(s.Available, s.Position, s.Rail.Id, s.TramName);
                    spf.ShowDialog();

                    s.Available = spf.Available;
                    s.TramName = spf.TramName;

                    selectedLabel.Text = spf.TramName.ToString();
                }
            }
        }

        public void GetAllSectors()
        {
            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetAllSectors"], null);

            int rail;
            int position;
            string available;
            bool availableSector;

            foreach (DataRow DR in DT.Rows)
            {
                rail = Convert.ToInt32(DR["RAILID"]);
                position = Convert.ToInt32(DR["POSITION"]);
                available = DR["AVAILABLE"].ToString();
                if(available=="1") { availableSector = true; }
                else { availableSector = false; }
                sectors.Add(new Sector(new Rail(rail), position, availableSector));
            }

            foreach(Sector s in sectors)
            {
                AddSector(s.GridLocation);
            }
        }

        public void GetAllTrams()
        {

        }
    }
}

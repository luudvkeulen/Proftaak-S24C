using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICT4Rails.Classes.Models;

namespace ICT4Rails
{
    public partial class BeheerSysteemForm : Form
    {
        public List<Rail> Rails { get; private set; }
        public List<Sector> Sectors { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public BeheerSysteemForm()
        {
            InitializeComponent();

            Rails = new List<Rail>();
            Sectors = new List<Sector>();

            GetAllRails();

            GetAllSectors();
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
        public void UpdateGrid()
        {
            tlpGrid.Visible = false;
            tlpGrid.Controls.Clear();

            foreach (Sector s in Sectors)
            {
                Label l = s.AddSectorLabel(this);

                string columnString = l.Tag.ToString();
                string rowString = l.Tag.ToString();

                int spaceIndex = columnString.IndexOf(" ");

                columnString = columnString.Substring(0, spaceIndex);
                rowString = rowString.Substring(spaceIndex);

                int column = Convert.ToInt32(columnString);
                int row = Convert.ToInt32(rowString);

                tlpGrid.Controls.Add(l, column, row);
            }

            foreach (Rail r in Rails)
            {
                Label l = r.AddRailLabel();

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
        /// Get all the Rails from the database and place them in a list of Rails
        /// </summary>
        private void GetAllRails()
        {
            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetAllRails"], null);

            int railID;

            foreach (DataRow DR in DT.Rows)
            {
                railID = Convert.ToInt32(DR["RAILID"]);
                Rails.Add(new Rail(railID));
            }
        }

        /// <summary>
        /// Get all the sectors from the database and place them in a list of sectors
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

            Sectors.Clear();

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

                Sectors.Add(new Sector(new Rail(rail), position, availableSector, tramID, reservedSector));
            }

            UpdateGrid();
        }

        private void btnShowIncoming_Click(object sender, EventArgs e)
        {
            AankomendeTrams form = new AankomendeTrams();
            form.Show();
        }

        private void railBlokkerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RailPropertiesForm rpf = new RailPropertiesForm(Rails);
            rpf.ShowDialog();

            GetAllSectors();
        }

        private void deblokkerenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseManager.ExecuteInsertQuery(DatabaseQuerys.query["DeblokkeerAll"], null);

            GetAllSectors();
        }
    }
}

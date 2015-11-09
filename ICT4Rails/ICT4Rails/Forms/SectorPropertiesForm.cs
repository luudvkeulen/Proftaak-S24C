using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ICT4Rails
{
    public partial class SectorPropertiesForm : Form
    {
        public bool Available { get; private set; }
        public string SectorText { get; set; }
        public int Position { get; set; }
        public int RailID { get; set; }
        public string TramID { get; set; }
        public bool IsReserved { get; set; }
        public List<Tram> tramList { get; set; }


        public SectorPropertiesForm(bool available, int position, int railID, string tramID, bool isReserved)
        {
            InitializeComponent();

            Available = available;
            Position = position;
            RailID = railID;
            TramID = tramID;
            IsReserved = isReserved;
            this.Text = SectorText;
            UpdateGui();
        }



        public List<Tram> GetAllTrams()
        {
            List<Tram> trams = new List<Tram>();
            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetAllTramsNotOnSectors"], null);
            string typeName;
            string specifications;
            string status;
            int tramID;
            foreach (DataRow DR in DT.Rows)
            {
                typeName = DR["NAME"].ToString();
                specifications = DR["SPECIFICATIONS"].ToString();
                status = DR["STATUS"].ToString();
                tramID = Convert.ToInt32(DR["TRAMID"]);
                trams.Add(new Tram(new TramType(typeName, specifications), null, status, tramID));
            }

            return trams;
        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            UpdateGui();
            UpdateDataBase();
            this.Close();
        }

        private void UpdateGui()
        {
            tramList = GetAllTrams();
            lbl_curr_train.Text = "Huidige trein op deze sector: " + TramID;

            if (!Available)
            {
                SectorText = "X";
                cbBlocked.Checked = true;
            }
            else
            {
                if (TramID != null)
                {
                    SectorText = TramID.ToString();
                }
                else
                {
                    SectorText = "";
                }
                cbBlocked.Checked = false;
            }
        }
        private void UpdateDataBase()
        {
            int i = 0;
            if(Available)
            {
                i = 1;
            }

            OracleParameter[] available = new OracleParameter[]
            {
                    new OracleParameter("available", i),
                    new OracleParameter("railid", RailID),
                    new OracleParameter("position", Position)
            };

            if (Available)
            {
                OracleParameter[] parameters1 = new OracleParameter[]
                {
                    new OracleParameter("tramid", TramID),
                    new OracleParameter("railid", RailID),
                    new OracleParameter("position", Position)
                };

                if (IsReserved)
                {
                    OracleParameter[] parameters2 = new OracleParameter[]
                    {
                        new OracleParameter("tramid", TramID)
                    };
                    DatabaseManager.ExecuteInsertQuery(DatabaseQuerys.query["UpdateReservedTramSector"], parameters1);
                    DatabaseManager.ExecuteInsertQuery(DatabaseQuerys.query["DeleteIncoming"], parameters2);
                }
                else
                {
                    DatabaseManager.ExecuteInsertQuery(DatabaseQuerys.query["UpdateTramSector"], parameters1);
                }
            }

            DatabaseManager.ExecuteInsertQuery(DatabaseQuerys.query["UpdateBlocked"], available);

        }

        private void cbBlocked_CheckedChanged(object sender, EventArgs e)
        {
            Available = !cbBlocked.Checked;
        }

        private void btn_place_Click(object sender, EventArgs e)
        {
            bool correct = false;

            if (Available)
            {

                foreach (Tram t in tramList)
                {
                    if (txtbox_tram.Text == t.TramID.ToString())
                    {
                        TramID = t.TramID.ToString();
                        correct = true;
                        IsReserved = false;
                        UpdateGui();
                    }
                }
                if (txtbox_tram.Text == "")
                {
                    TramID = "";
                    correct = true;
                }
            }
            else
            {
                MessageBox.Show("Deze sector is geblokeerd");
                correct = true;
            }
            if (!correct)
            {
                MessageBox.Show("Incorrect TramID");
            }
        }

        private void btn_reservation_Click(object sender, EventArgs e)
        {
            bool correct = false;

            if (Available)
            {

                foreach (Tram t in tramList)
                {
                    if (txtbox_tram.Text == t.TramID.ToString())
                    {
                        TramID = t.TramID.ToString();
                        correct = true;
                        IsReserved = true;
                        UpdateGui();
                    }
                }
                if (txtbox_tram.Text == "")
                {
                    TramID = "";
                    correct = true;
                }
            }
            else
            {
                MessageBox.Show("Deze sector is geblokeerd");
                correct = true;
            }
            if (!correct)
            {
                MessageBox.Show("Incorrect TramID");
            }
        }
    }
}

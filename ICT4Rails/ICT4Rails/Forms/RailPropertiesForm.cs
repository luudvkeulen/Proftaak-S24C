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

namespace ICT4Rails.Classes.Models
{
    public partial class RailPropertiesForm : Form
    {
        public int RailID { get; set; }
        public int Blocked { get; set; }

        public RailPropertiesForm(List<Rail> rails)
        {         
            CheckBlocked();            
            InitializeComponent();
            UpdateInterface();
            foreach(Rail r in rails)
            {
                cbox_tramid.Items.Add(r.ID);
            }
            cbox_tramid.SelectedIndex = 1;
        }



        public void CheckBlocked()
        {
            Blocked = 1;
            OracleParameter[] parameter = new OracleParameter[]
           {
                new OracleParameter("RAILID", RailID)
           };

            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["CheckRailBlocked"], parameter);

            foreach (DataRow DR in DT.Rows)
            {
               if(Convert.ToInt32(DR["RAILID"].ToString())==RailID)
                {
                    Blocked = 0;
                }              
            }
        }

        public void UpdateInterface()
        {
            if(Blocked==0)
            {
                lbl_rail.Text = "Spoor "+RailID+" is geblokeerd";
                btn_block.Text = "Verwijder blokering";
            }
            else
            {
                lbl_rail.Text = "Spoor "+RailID+" is niet geblokeerd";
                btn_block.Text = "Blokeer spoor";
            }
        }

        private void btn_block_Click(object sender, EventArgs e)
        {
            List<int> notAllowedSectorID = new List<int>();
            if (Blocked == 0)
            {
                Blocked = 1;
            }
            else
            {
                OracleParameter[] parameter = new OracleParameter[]
          {
                new OracleParameter("RAILID", RailID)
          };
                DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["CheckRailSectorBlocked"], parameter);

                foreach (DataRow DR in DT.Rows)
                {
                    notAllowedSectorID.Add(Convert.ToInt32(DR["SECTORID"].ToString()));
                }
                if(notAllowedSectorID.Count==0)
                {
                    Blocked = 0;
                }
                else
                {
                    MessageBox.Show("Er zijn sectoren op deze rail waar nog trams op staan.");
                }
            }
            UpdateDataBase();
            UpdateInterface();          
        }

        private void UpdateDataBase()
        {

            OracleParameter[] parameter = new OracleParameter[]
           {
                new OracleParameter("available",Blocked),
                new OracleParameter("railid", RailID)
           };
            DatabaseManager.ExecuteInsertQuery(DatabaseQuerys.query["TrackStatusChange"], parameter);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            UpdateInterface();
            UpdateDataBase();
            this.Close();
        }

        private void cbox_tramid_SelectedIndexChanged(object sender, EventArgs e)
        {
            RailID = (int)cbox_tramid.SelectedItem;          
            CheckBlocked();
            UpdateInterface();
        }
    }
}

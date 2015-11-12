using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT4Rails.Forms
{
    public partial class TramIDInputForm : Form
    {
        public TramIDInputForm()
        {
            InitializeComponent();
        }

        public string TramID { get { return txtb_tramID.Text; } }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            bool correct = false;
            DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetAllTramsNotOnSectors"], null);
            foreach (DataRow DR in DT.Rows)
            {
                if(DR["TRAMID"].ToString()==txtb_tramID.Text)
                {
                    correct = true;
                }
            }

            if(correct)
            {
                this.Close();
            }
        }
    }
}

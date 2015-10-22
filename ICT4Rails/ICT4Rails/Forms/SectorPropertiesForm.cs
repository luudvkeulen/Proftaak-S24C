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
    public partial class SectorPropertiesForm : Form
    {
        public bool Available { get; private set; }
        public string SectorText { get; set; }
        public int Position { get; set; }
        public int RailID { get; set; }
        public int TramName { get; set; }

        public SectorPropertiesForm(bool available, int position, int railID, int tramName)
        {
            InitializeComponent();

            Available = available;
            Position = position;
            RailID = railID;
            TramName = tramName;

            UpdateGui();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UpdateDataBase();
            this.Hide();
        }

        private void UpdateGui()
        {
            if(!Available)
            {
                SectorText = "X";
                cbBlocked.Checked = true;
            }
            else
            {
                SectorText = TramName.ToString();
                cbBlocked.Checked = false;
            }
        }

        private void UpdateDataBase()
        {

        }
    }
}

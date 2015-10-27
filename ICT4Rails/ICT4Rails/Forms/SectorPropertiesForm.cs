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
        public string TramID { get; set; }

        public SectorPropertiesForm(bool available, int position, int railID, string tramID)
        {
            InitializeComponent();

            Available = available;
            Position = position;
            RailID = railID;
            TramID = tramID;

            this.Text = SectorText;

            UpdateGui();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UpdateGui();
            UpdateDataBase();
            this.Hide();
        }

        private void UpdateGui()
        {
            if (!Available)
            {
                SectorText = "X";
                cbBlocked.Checked = true;
            }
            else
            {
                SectorText = TramID.ToString();
                cbBlocked.Checked = false;
            }
        }
        private void UpdateDataBase()
        {

        }

        private void cbBlocked_CheckedChanged(object sender, EventArgs e)
        {
            Available = !cbBlocked.Checked;
        }
    }
}

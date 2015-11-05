using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;
using System.Threading;

namespace ICT4Rails
{
    public partial class InUitRijSyteemForm : Form
    {
        private RFID rfid;
        private TramManager trammanager = new TramManager();

        private Button[] buttons;
        public InUitRijSyteemForm()
        {
            InitializeComponent();
            buttons = new Button[] { btnNumber0, btnNumber1, btnNumber2, btnNumber3, btnNumber4, btnNumber5, btnNumber6, btnNumber7, btnNumber8, btnNumber9, btnNumber0, btnBackspace, btnConfirm };
        }


        void rfid_Tag(object sender, TagEventArgs e)
        {
            if (e.Tag == "1a008cceb6")
            {
                txtTramNumber.Text = "2203";
            }
            else if (e.Tag == "1c00fcb1eb")
            {
                txtTramNumber.Text = "818";
            }

            else if (e.Tag == "160052adc4")
            {
                txtTramNumber.Text = "809";
            }

            DisableButtons();
            TrainScanned(txtTramNumber.Text);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            rfid.Tag -= rfid_Tag;
            rfid.close();
        }

        private void TouchPad_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtTramNumber.Text.Count() < txtTramNumber.MaxLength)
            {
                txtTramNumber.Text = txtTramNumber.Text + btn.Text;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtTramNumber.Text.Count() > 0)
            {
                DisableButtons();
                TrainScanned(txtTramNumber.Text);
            }
            else
            {
                MessageBox.Show("Voer eerst een tramnummer in");
            }
        }

        private void TrainScanned(string tram)
        {
            int tramid = Convert.ToInt32(tram);
            int[] info = trammanager.GetReservedSector(tramid);
            if (info[0] == 0 || info[1] == 0)
            {
                trammanager.AddIncoming(txtTramNumber.Text);
                MessageBox.Show("Er is nog geen reservering voor uw tram. Er is een bericht naar de trambeheerder gestuurd.");
                EnableButtons();
            }
            else
            {
                txtDesiredRail.Text = info[0].ToString();
                txtDesiredSector.Text = info[1].ToString();
                trammanager.CheckInTrain(txtTramNumber.Text);
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtTramNumber.Text.Count() > 0)
            {
                txtTramNumber.Text = txtTramNumber.Text.Remove(txtTramNumber.TextLength - 1, 1);
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void InUitRijSyteemForm_Shown(object sender, EventArgs e)
        {
            rfid = new RFID();
            try
            {
                rfid.open();
                Thread.Sleep(500);
                rfid.Tag += new TagEventHandler(rfid_Tag);
                rfid.Antenna = true;
                rfid.LED = true;
            }
            catch
            {
                MessageBox.Show("Controleer de verbinding van de RFID-lezer");
            }
        }
        
        private void DisableButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = false;
            }
            btnRecover.Enabled = true;
            checkCleaning.Enabled = false;
            checkRepair.Enabled = false;
        }

        private void EnableButtons()
        {
            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }
            txtTramNumber.Text = "";
            txtDesiredRail.Text = "";
            txtDesiredSector.Text = "";
            btnRecover.Enabled = false;
            checkRepair.Enabled = true;
            checkCleaning.Enabled = true;
        }
    }
}

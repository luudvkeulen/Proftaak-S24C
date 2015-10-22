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
    public partial class InUitRijSyteemForm : Form
    {
        private Button[] buttons;
        public InUitRijSyteemForm()
        {
            InitializeComponent();
            buttons = new Button[] { btnNumber0, btnNumber1, btnNumber2, btnNumber3, btnNumber4, btnNumber5, btnNumber6, btnNumber7, btnNumber8, btnNumber9, btnNumber0, btnBackspace, btnConfirm };
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TouchPad_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnBackspace)
            {
                if(txtTramNumber.Text.Count() > 0)
                {
                    txtTramNumber.Text = txtTramNumber.Text.Remove(txtTramNumber.TextLength - 1, 1);
                }
            }
            else if(btn == btnConfirm)
            {
                foreach(Button button in buttons)
                {
                    button.Enabled = false;
                }
                btnRecover.Enabled = true;
                checkCleaning.Enabled = false;
                checkRepair.Enabled = false;
            }
            else
            {
                if (txtTramNumber.Text.Count() < txtTramNumber.MaxLength)
                {
                    txtTramNumber.Text = txtTramNumber.Text + btn.Text;
                }
            }
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            foreach(Button button in buttons)
            {
                button.Enabled = true;
            }
            txtTramNumber.Text = "";
            txtDesiredRail.Text = "";
            btnRecover.Enabled = false;
            checkRepair.Enabled = true;
            checkCleaning.Enabled = true;
        }
    }
}

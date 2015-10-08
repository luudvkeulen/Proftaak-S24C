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
        public BeheerSysteemForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbComment_Enter(object sender, EventArgs e)
        {
            tbComment.Text = "";
        }

        private void tbComment_Leave(object sender, EventArgs e)
        {
            if(tbComment.Text == "")
            {
                tbComment.Text = "Enter comment here...";
            }
        }
    }
}

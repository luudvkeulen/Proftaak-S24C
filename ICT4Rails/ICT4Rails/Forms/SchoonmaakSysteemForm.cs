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
    public partial class SchoonmaakSysteemForm : Form
    {
        public SchoonmaakSysteemForm()
        {
			RefreshListview();
            InitializeComponent();
        }

		private void RefreshListview()
		{
			
		}

		private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void btFinished_Click(object sender, EventArgs e)
		{
			//SetTramCleaningFinished();
			RefreshListview();
        }

		private void btChangeDate_Click(object sender, EventArgs e)
		{
			//ChangeTramCleaningDate();
			RefreshListview();
        }
	}
}

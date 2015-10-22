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
    public partial class TechniekSysteemForm : Form
	{
		TramManager tm = new TramManager();
		public TechniekSysteemForm()
        {
            InitializeComponent();
		}

		private void RefreshListview()
		{
			lvTrams.Items.Clear();
			foreach (var item in tm.GetMaintenensCleanListView())
			{
				lvTrams.Items.Add(item);
			}
		}

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void btFinished_Click(object sender, EventArgs e)
		{
			//SetTramMaintenensFinished();
			RefreshListview();
		}

		private void btChangeDate_Click(object sender, EventArgs e)
		{
			//ChangeTramMaintenensDate();
			RefreshListview();
        }

		private void TechniekSysteemForm_Shown(object sender, EventArgs e)
		{
			RefreshListview();
		}
	}
}

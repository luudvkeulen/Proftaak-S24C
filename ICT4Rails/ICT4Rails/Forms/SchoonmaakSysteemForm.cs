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
		TramManager tm = new TramManager();
        public SchoonmaakSysteemForm()
        {
            InitializeComponent();
		}

		private void RefreshListview()
		{
			lvTrams.Items.Clear();
			foreach (var item in tm.GetTramCleanListView())
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
			//SetTramCleaningFinished();
			RefreshListview();
        }

		private void btChangeDate_Click(object sender, EventArgs e)
		{
			tm.ChangeTramCleaningDate(lvTrams.SelectedItems[0].Text, dtpEndDate.Value);
			RefreshListview();
        }

		private void SchoonmaakSysteemForm_Shown(object sender, EventArgs e)
		{
			RefreshListview();
		}
	}
}

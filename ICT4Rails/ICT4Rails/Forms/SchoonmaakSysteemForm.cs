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
			DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetClean"], null);
			foreach (DataRow row in DT.Rows)
			{
				ListViewItem item = new ListViewItem(row[0].ToString());
				for (int i = 1; i < DT.Columns.Count; i++)
				{
					item.SubItems.Add(row[i].ToString());
				}
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
			//ChangeTramCleaningDate();
			RefreshListview();
        }
	}
}

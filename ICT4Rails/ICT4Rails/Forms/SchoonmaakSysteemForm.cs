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

        private void PopulateEmployees()
        {
            string[] employees = tm.GetAllCleaners().ToArray();
            cbUsers.Items.AddRange(employees);
            if(cbUsers.Items.Count > 0)
            {
                cbUsers.SelectedIndex = 0;
            }
        }

		private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void btFinished_Click(object sender, EventArgs e)
        {
            if(cbUsers.SelectedItem.ToString() != "" && lvTrams.SelectedItems[0] != null)
            {
                tm.SetTramFinished(lvTrams.SelectedItems[0].Text, DateTime.Now, cbUsers.SelectedItem.ToString(), 0);
                RefreshListview();
            }
        }

		private void btChangeDate_Click(object sender, EventArgs e)
		{
            if (lvTrams.SelectedItems[0] != null)
            {
                tm.ChangeTramDate(lvTrams.SelectedItems[0].Text, dtpEndDate.Value);
                RefreshListview();
            }
        }

		private void SchoonmaakSysteemForm_Shown(object sender, EventArgs e)
		{
			RefreshListview();
            PopulateEmployees();
		}

        private void lvTrams_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
	}
}

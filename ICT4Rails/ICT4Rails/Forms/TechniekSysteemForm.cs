﻿using System;
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
        public TechniekSysteemForm()
        {
            InitializeComponent();
        }

		private void RefreshListview()
		{
			lvTrams.Clear();
			DataTable DT = DatabaseManager.ExecuteReadQuery(DatabaseQuerys.query["GetTech"], null);
			foreach (DataRow DR in DT.Rows)
			{
				//lvTrams.it
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
	}
}

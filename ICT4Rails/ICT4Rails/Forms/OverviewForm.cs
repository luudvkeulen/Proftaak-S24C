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
    public partial class OverviewForm : Form
    {
        public OverviewForm()
        {
            InitializeComponent();
            ShowSystems();
        }

        private void ShowSystems()
        {
            switch (Program.ActiveUser.Role)
            {
                case "ADMIN":
                    
                    break;
                case "BEHEERDER":
                    break;
                case "TECHNICUS":
                    break;
                case "SCHOONMAKER":
                    break;
                case "BESTUURDER":
                    break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.ActiveUser = null;
            Close();
        }
    }
}

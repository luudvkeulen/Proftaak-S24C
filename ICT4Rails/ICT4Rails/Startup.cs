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
    public partial class Startup : Form
    {
        DatabaseManager DBM;
        public Startup()
        {
            InitializeComponent();
            DBM = new DatabaseManager();
            progressConnect.Value = 25;
            if (DBM.Connect() != null)
            {
                progressConnect.Value = 50;
                DBM.Close();
                progressConnect.Value = 100;
                Application.Run(new LoginForm());
                Close();
                Dispose();
            }
            else
            {
                MessageBox.Show("De applicatie kan geen verbinding maken met de database. Neem contact op met een systeembeheerder.");
                Environment.Exit(1);
            }

        }
    }
}

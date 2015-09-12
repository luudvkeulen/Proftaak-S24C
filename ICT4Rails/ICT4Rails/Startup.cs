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
        public Startup()
        {
            InitializeComponent();
            progressConnect.Value = 10;
            if (DatabaseManager.Connect() != null)
            {
                progressConnect.Value = 50;
                if (DatabaseManager.Close())
                {
                    progressConnect.Value = 100;
                    Application.Run(new LoginForm());
                    Close();
                }
            }
            else
            {
                MessageBox.Show("De applicatie kan geen verbinding maken met de database. Neem contact op met een systeembeheerder.");
                Environment.Exit(1);
            }

        }
    }
}

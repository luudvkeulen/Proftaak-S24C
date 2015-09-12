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
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
            progressConnect.Value = 10;
            //Checks if the database can make a connection
            if (DatabaseManager.Connect() != null)
            {
                progressConnect.Value = 50;
                //Checks if the database can close the connection
                if (DatabaseManager.Close())
                {
                    progressConnect.Value = 100;

                    //Check is complete, Application wil open the login form and closes this one.
                    Hide();
                    LoginForm login = new LoginForm();
                    login.ShowDialog();
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

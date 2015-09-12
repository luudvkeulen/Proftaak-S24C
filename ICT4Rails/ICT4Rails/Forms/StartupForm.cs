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
            //Checks if the database can make a connection
            if (DatabaseManager.Connect() != null)
            {
                DatabaseManager.Close();
                //Check is complete, Application wil open the login form and closes this one.
                //Application.Run(new LoginForm());
                this.Visible = false;
                LoginForm form = new LoginForm();
                form.FormClosed += new FormClosedEventHandler(form_Closed);
                form.Show();
            }
            else
            {
                MessageBox.Show("De applicatie kan geen verbinding maken met de database. Neem contact op met een systeembeheerder.");
                Environment.Exit(1);
            }
        }

        void form_Closed(Object sender, EventArgs e)
        {
            this.Show();
        }
    }
}

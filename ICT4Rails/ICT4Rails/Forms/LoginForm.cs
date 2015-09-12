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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            AcceptButton = btnLogin; //Hiermee kun je ervoor zorgen dat je met enter op de btnLogin knop drukt
        }

        void CheckDBConnection()
        {
            //Checks if the database can make a connection
            if (DatabaseManager.Connect() != null)
            {
                DatabaseManager.Close();
            }
            else
            {
                MessageBox.Show("De applicatie kan geen verbinding maken met de database. Neem contact op met een systeembeheerder.");
                Environment.Exit(1);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = User.AuthenticateUser(txtLoginName.Text, txtLoginPassword.Text);
            if (user != null)
            {
                Program.ActiveUser = user;
                Hide();
                OverviewForm form = new OverviewForm();
                form.FormClosed += new FormClosedEventHandler(form_Closed);
                form.Show();
            }
            else
            {
                MessageBox.Show("De ingevulde naam of het wachtwoord is niet correct, probeer het nog een keer.");
            }
        }

        void form_Closed(Object sender, EventArgs e)
        {
            this.Show();
            ClearControls();
        }

        void ClearControls()
        {
            var tbs = this.Controls.OfType<TextBox>();
            foreach(TextBox tb in tbs)
            {
                tb.ResetText();
            }
        }
    }
}

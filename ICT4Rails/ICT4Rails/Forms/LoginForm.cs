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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = User.AuthenticateUser(txtLoginName.Text, txtLoginPassword.Text); //Kijkt of de user bestaat en of het wacthwoord goed is.
            if (user != null) //Als de autheticatie geen null teruggeeft wordt hij goedgekeurd.
            {
                Program.ActiveUser = user; //Omdat je in een windows form applicatie geen sessies hebt is er een statische variable die de user opslaat.
                Hide(); //Verbegt het login form.
                OverviewForm form = new OverviewForm();
                form.FormClosed += new FormClosedEventHandler(form_Closed); //Nieuwe event handler zodat als het nieuwe form gesloten wordt hij het login form weer opent.
                form.Show(); //Opent het nieuwe form.
            }
            else
            {
                MessageBox.Show("De ingevulde naam of het wachtwoord is niet correct.");
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

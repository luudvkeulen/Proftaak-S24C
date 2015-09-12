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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(User.AuthenticateUser(txtLoginName.Text, txtLoginPassword.Text) != null)
            {
                OverviewForm form = new OverviewForm();
                Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("De ingevulde naam of het wachtwoord is niet correct, probeer het nog een keer.");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

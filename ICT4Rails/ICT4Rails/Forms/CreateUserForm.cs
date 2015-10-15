using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT4Rails
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
            comboRole.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string emptype = txtEmpType.Text;
            string role;

            if(username.Length > 128)
            {
                MessageBox.Show("Gebruikersnaam mag niet langer dan 128 karakters zijn.");
            }
            else if (password.Length > 20)
            {
                MessageBox.Show("Wachtwoord mag niet langer dan 20 characters zijn");
            }

            /*-------------------------------
            0 - Beheerder
            1 - Wagenparkbeheerder
            2 - Bestuurder
            3 - Technicus
            4 - Schoonmaker
            -------------------------------*/
            switch (comboRole.SelectedIndex)
            {
                case 0:
                    role = "ADMIN";
                    break;
                case 1:
                    role = "BEHEERDER";
                    break;
                case 2:
                    role = "BESTUURDER";
                    break;
                case 3:
                    role = "TECHNICUS";
                    break;
                case 4:
                    role = "SCHOONMAKER";
                    break;
                default:
                    role = "BESTUURDER";
                    break;
            }

            if(UserManager.CreateUser(name, surname, username, emptype, password, role))
            {
                MessageBox.Show("Account voor '" + name + " " + surname + "' met '" + username + "' als gebruikersnaam aangemaakt.");
                Close();
            }
        }
    }
}

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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void AdminPanelForm_Shown(object sender, EventArgs e)
        {
            FillList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUserForm form = new CreateUserForm();
            form.FormClosing += new FormClosingEventHandler(form_Closing);
            form.Show();
            form.Update();
        }

        void form_Closing(Object sender, EventArgs e)
        {
            Show();
            Update();
        }

        void FillList()
        {
			listUsers.Items.Clear();

			//listUsers.Items.Clear();
   //         List<Login> logins = UserManager.GetAllLogins();
   //         foreach (Login login in logins)
   //         {
   //             ListViewItem lvi = new ListViewItem(login.UserName);
   //             lvi.SubItems.Add(login.Role);
   //             listUsers.Items.Add(lvi);
   //         }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if(listUsers.SelectedItems.Count > 0)
            {
                string naam = listUsers.SelectedItems[0].Text;
                UserManager.RemoveUser(naam);
                FillList();
            }
            else
            {
                MessageBox.Show("Selecteer eerst een gebruiker");
            }
        }
    }
}

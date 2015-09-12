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
        Button[] btns;
        public OverviewForm()
        {
            InitializeComponent();
            btns = new Button[] { btnBeheerSysteem, btninuitrijsysteem, btnSchoonmaakSysteem, btnTechniekSysteem };
            ShowSystems();
        }

        private void ShowSystems()
        {
            int i = 99;
            switch (Program.ActiveUser.Role)
            {
                case "ADMIN":
                    i = 99;
                    break;
                case "BEHEERDER":
                    i = 0;
                    break;
                case "TECHNICUS":
                    i = 3;
                    break;
                case "SCHOONMAKER":
                    i = 2;
                    break;
                case "BESTUURDER":
                    i = 1;
                    break;
            }
            EnableButtons(i);
        }

        void EnableButtons (int i)
        {
            if (i != 99)
            {
                btns[i].Enabled = true;
            }
            else
            {
                for (i = 0; i < btns.Count(); i++)
                {
                    btns[i].Enabled = true;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.ActiveUser = null;
            Close();
        }

        private void btnBeheerSysteem_Click(object sender, EventArgs e)
        {
            form.FormClosed += new FormClosedEventHandler(form_Closed);
        }

        private void btnSchoonmaakSysteem_Click(object sender, EventArgs e)
        {
            form.FormClosed += new FormClosedEventHandler(form_Closed);
        }

        private void btninuitrijsysteem_Click(object sender, EventArgs e)
        {
            form.FormClosed += new FormClosedEventHandler(form_Closed);
        }

        private void btnTechniekSysteem_Click(object sender, EventArgs e)
        {
            form.FormClosed += new FormClosedEventHandler(form_Closed);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            form.FormClosed += new FormClosedEventHandler(form_Closed);
        }

        void form_Closed(Object sender, EventArgs e)
        {
            this.Show();
        }
    }
}

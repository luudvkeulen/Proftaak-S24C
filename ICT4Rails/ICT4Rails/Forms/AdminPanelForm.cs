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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        private void AdminPanelForm_Shown(object sender, EventArgs e)
        {
            List<User> users = User.GetAllUsers();
            foreach(User user in users)
            {
                ListViewItem lvi = new ListViewItem(user.UserName);
                lvi.SubItems.Add(user.Role);
                listUsers.Items.Add(lvi);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close();
        }
    }
}

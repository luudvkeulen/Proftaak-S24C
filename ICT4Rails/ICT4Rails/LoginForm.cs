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
            User user = new User("admin", "none");
            user.CreateUser("admin", "admin");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseManager.Connect();
        }
    }
}

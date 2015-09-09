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
    public partial class Startup : Form
    {
        DatabaseManager DBM;
        public Startup()
        {
            InitializeComponent();
            DBM = new DatabaseManager();
            progressConnect.Value = 25;
            DBM.Connect();
            progressConnect.Value = 50;
            DBM.Close();
            progressConnect.Value = 100;
            LoginForm login = new LoginForm();
            login.Show();
            Close();
            Dispose();
        }
    }
}

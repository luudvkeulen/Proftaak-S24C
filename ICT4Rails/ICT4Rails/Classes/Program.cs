using ICT4Rails.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT4Rails
{
    static class Program
    {
        public static Login ActiveUser;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!DatabaseManager.CheckConnection())
            {
                MessageBox.Show("De applicatie kan geen verbinding maken met de database. Neem contact op met een systeembeheerder.");
                Application.Exit();
            }
            else
            {
                Application.Run(new LoginForm());
            }
        }
    }
}

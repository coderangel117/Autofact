using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AutofactApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

           // string cs = "server=localhost;user=root;password=;database=autofact";
            //MySqlConnection connection = new MySqlConnection(cs);
            //connection.Open();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accueil());
        }
    }
}

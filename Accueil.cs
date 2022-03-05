using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutofactApp
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmLog_Click(object sender, EventArgs e)
        {
            string username, user_password;
            username = Logintext.Text;
            user_password = Passtext.Text;


            try
            {
                string cs = "server=localhost;user=root;password=;database=autofact";
                MySqlConnection connection = new MySqlConnection(cs);
                connection.Open();
                string query = "select * from utilisateur where login = '" + Logintext.Text + "'AND password = '" + Passtext.Text + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, connection);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count == 1)
                {
                    username = Logintext.Text;
                    user_password = Passtext.Text;
                    Form Menu = new Menu();
                    Menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details !! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Passtext.Clear();
                    Logintext.Clear();
                    Logintext.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error !! ");
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you woant to exit ", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
            Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            Passtext.Clear();
            Logintext.Clear();
            Logintext.Focus();
        }
    }
}

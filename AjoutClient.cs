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
    public partial class AjoutClient : Form
    {
        public AjoutClient()
        {
            InitializeComponent();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            NewNomText.Clear();
            NewPrenomText.Clear();
            NewTelText.Clear();
            NewMailText.Clear();
            NewNomText.Focus();
        }

        private void AddConfirm_Click(object sender, EventArgs e)
        {
            string nom, prenom, telephone, mail;
            nom = NewNomText.Text;
            prenom = NewPrenomText.Text;
            telephone = NewTelText.Text;
            mail = NewMailText.Text;
            if (NewNomText.Text != "" && NewPrenomText.Text != "" && NewTelText.Text != "" && NewMailText.Text != "")
            {
                string cs = "server=localhost;user=root;password=;database=autofact";
                MySqlConnection connection = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand("insert into client(nom, prenom, telephone, mail) values(@nom, @prenom,@telephone, @mail )", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@nom", NewNomText.Text);
                cmd.Parameters.AddWithValue("@prenom", NewPrenomText.Text);
                cmd.Parameters.AddWithValue("@telephone", NewTelText.Text);
                cmd.Parameters.AddWithValue("@mail", NewMailText.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Les informations du client ont bien été ajoutées");
            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void AjoutClient_Load(object sender, EventArgs e)
        {

        }
    }
}

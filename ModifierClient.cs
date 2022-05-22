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
    public partial class ModifierClient : Form
    {
        public ModifierClient(List<string> parametres) : this()
        {
            idCustomer.Text= parametres[0];
            NewNomText.Text = parametres[1];
            NewPrenomText.Text = parametres[2];
            NewTelText.Text = parametres[3];
            NewMailText.Text = parametres[4];
            
        }
        public ModifierClient()
        {
            InitializeComponent();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }
        private void AddConfirm_Click(object sender, EventArgs e)
        {

            if (idCustomer.Text != "" && NewNomText.Text != "" && NewPrenomText.Text != "" && NewTelText.Text != "" && NewMailText.Text != "")
            {
                string cs = "server=localhost;user=root;password=;database=autofact";
                MySqlConnection connection = new MySqlConnection(cs);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("update client set nom=@nom,prenom=@prenom,telephone=@telephone, mail=@mail where idC=@id", connection);
                cmd.Parameters.AddWithValue("@id", idCustomer.Text);
                cmd.Parameters.AddWithValue("@nom", NewNomText.Text);
                cmd.Parameters.AddWithValue("@prenom", NewPrenomText.Text);
                cmd.Parameters.AddWithValue("@telephone", NewTelText.Text);
                cmd.Parameters.AddWithValue("@mail", NewMailText.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                this.Hide();
                new clients().Show();
                MessageBox.Show("Les changements ont bien été enregistrées");
            }
            else
            {
                MessageBox.Show("Veuillez saisir les informations !");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new clients().Show();
            this.Hide();
        }
    }
}

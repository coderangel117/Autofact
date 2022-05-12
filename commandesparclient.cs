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
    public partial class commandesparclient : Form
    {
        public commandesparclient()
        {
            InitializeComponent();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void SelectClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void commandesparclient_Load(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            SelectClient.Rows.Clear();
            MySqlCommand requete = new MySqlCommand("select * from client where idC IN (select IdClient from commande)");
            requete.Connection = connection;
            MySqlDataReader reader = requete.ExecuteReader();

            while (reader.Read())
            {
                Object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                SelectClient.Rows.Add(values);
            }
        }

        private void SelectClient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            name.Text = SelectClient.Rows[e.RowIndex].Cells[1].Value.ToString();
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            selectCmd.Rows.Clear();
            MySqlCommand requete = new MySqlCommand(@"select prestation.LibellePrestation as libelle,
prestation.Description as description, 
categorie.LibelleCateg as categorie, 
commande.DateCreation,
commande.Paye, 
prestation.PrixHt,
contenir.Quantite,
prestation.Tva,
prestation.PrixHt * contenir.Quantite * (1 + prestation.Tva / 100) as prixTotalTTC
from commande
Inner join contenir ON commande.IdCommande = contenir.IdCommande
inner join prestation on prestation.Idp = contenir.IdPrestation
inner join categorie ON categorie.Id = prestation.IdCateg
where commande.IdClient = (SELECT idC from client where nom =@name);");
            requete.Parameters.AddWithValue("@name", name.Text);
            requete.Connection = connection;
            MySqlDataReader reader = requete.ExecuteReader();

            while (reader.Read())
            {
                Object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                selectCmd.Rows.Add(values);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

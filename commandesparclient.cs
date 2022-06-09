using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AutofactApp
{
    public partial class commandesparclient : Form
    {
        public commandesparclient(int parametre) : this()
        {
            name.Text = parametre.ToString();
        }
        public commandesparclient() 
        {
            InitializeComponent();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void commandesparclient_Load(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            selectCmd.Rows.Clear();
            MySqlCommand requete = new MySqlCommand(@"select commande.IdCommande, prestation.LibellePrestation as libelle,
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
where commande.IdClient =(select idC from client where idC=@id);");
            requete.Parameters.AddWithValue("@id", name.Text);
            requete.Connection = connection;
            MySqlDataReader reader = requete.ExecuteReader();

            while (reader.Read())
            {
                Object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                selectCmd.Rows.Add(values);
            }
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void BackMenu_Click_1(object sender, EventArgs e)
        {
            new clients().Show();
            this.Hide();
        }

        private void selectCmd_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            checkBox1.Visible = true;

            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            MySqlCommand paye = new("select Paye from commande where IdCommande=@id", connection);
            paye.Parameters.AddWithValue("@id", name.Text);
            paye.ExecuteNonQuery();
            string test = paye.ExecuteScalar().ToString();
            label2.Text = test;

            /*  if (checkBox1.Checked)
              {
                  string cs = "server=localhost;user=root;password=;database=autofact";
                  MySqlConnection connection = new MySqlConnection(cs);
                  connection.Open();
                  MySqlCommand cmd = new MySqlCommand("update commande set Paye=@paye", connection);
                  cmd.Parameters.AddWithValue("@paye", 1);
                  cmd.ExecuteNonQuery();
                  connection.Close();
              }
              else
              {
                  string cs = "server=localhost;user=root;password=;database=autofact";
                  MySqlConnection connection = new MySqlConnection(cs);
                  connection.Open();
                  MySqlCommand cmd = new MySqlCommand("update commande set Paye=@paye ", connection);
                  cmd.Parameters.AddWithValue("@paye", 0);
                  cmd.ExecuteNonQuery();
                  connection.Close();
              }*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(label2.Text != "")
            {
                if (checkBox1.Checked)
                {
                    string cs = "server=localhost;user=root;password=;database=autofact";
                    MySqlConnection connection = new MySqlConnection(cs);
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("update commande set Paye=@paye", connection);
                    cmd.Parameters.AddWithValue("@paye", 1);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    string cs = "server=localhost;user=root;password=;database=autofact";
                    MySqlConnection connection = new MySqlConnection(cs);
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("update commande set Paye=@paye ", connection);
                    cmd.Parameters.AddWithValue("@paye", 0);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show(" veuillez selectionner une commande !!", "Erreur de selection de commande");
            }
        }
    }
}

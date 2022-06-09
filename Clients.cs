using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutofactApp
{
    public partial class clients : Form
    {
        public clients()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            SelectClient.Rows.Clear();
            MySqlCommand requete = new MySqlCommand("select * from client");
            requete.Connection = connection;
            MySqlDataReader reader = requete.ExecuteReader();

            while (reader.Read())
            {
                Object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                SelectClient.Rows.Add(values);
            }
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void AjoutClient_Click(object sender, EventArgs e)
        {
            new AjoutClient().Show();
            this.Hide();
        }

        private void SelectClient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AddCmd.Visible = true;
            idCustomer.Text = SelectClient.Rows[e.RowIndex].Cells[0].Value.ToString();
            NewNomText.Text = SelectClient.Rows[e.RowIndex].Cells[1].Value.ToString();
            NewPrenomText.Text = SelectClient.Rows[e.RowIndex].Cells[2].Value.ToString();
            NewTelText.Text = SelectClient.Rows[e.RowIndex].Cells[3].Value.ToString();
            NewMailText.Text = SelectClient.Rows[e.RowIndex].Cells[4].Value.ToString();

            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            MySqlCommand requete = new MySqlCommand("select * from client where idC =@id and idC IN (select IdClient from commande)");
            requete.Parameters.AddWithValue("@id", idCustomer.Text);
            requete.Connection = connection;
            int nb = requete.ExecuteNonQuery();
            if (nb <10)
            {
                label1.Text = "true";
                DisplayCmd.Visible = true;
            }
            connection.Close();
        }
        public void ModifClient()
        {
            string id = idCustomer.Text;
            string nom = NewNomText.Text;
            string prenom = NewPrenomText.Text;
            string telephone = NewTelText.Text;
            string mail = NewMailText.Text;
            List<string> Variable = new List<string>() { id, nom, prenom, telephone, mail };
            new ModifierClient(Variable).Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (NewNomText.Text != "" && NewPrenomText.Text != "" && NewTelText.Text != "" && NewMailText.Text != "")
            {
                ModifClient();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un client");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Voulez-vous vraiment supprimer ce client ?", "Supprimer un client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (NewNomText.Text != "" && NewPrenomText.Text != "" && NewTelText.Text != "" && NewMailText.Text != "")
                {
                    string cs = "server=localhost;user=root;password=;database=autofact";
                    MySqlConnection connection = new MySqlConnection(cs);
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("delete from client where idC=@id", connection);
                    cmd.Parameters.AddWithValue("@id", idCustomer.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Le client a bien été supprimé ! ");
                    new Menu().Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Veuillez selectionner un client");
                }
            }
            else
            {
                this.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AjoutClient().Show();
            this.Hide();
        }

        private void SearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            SelectClient.Rows.Clear();
            MySqlCommand requete = new MySqlCommand("select * from client where nom like concat('%',@nom,'%')");
            requete.Parameters.AddWithValue("@nom", SearchCustomer.Text);
            requete.Connection = connection;
            MySqlDataReader reader = requete.ExecuteReader();
            while (reader.Read())
            {
                Object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                SelectClient.Rows.Add(values);
            }
        }

        private void DisplayCmd_Click(object sender, EventArgs e)
        {
            new commandesparclient(int.Parse(idCustomer.Text)).Show();
            this.Hide();
        }

        private void AddCmd_Click(object sender, EventArgs e)
        {
            new AjoutCommande(int.Parse(idCustomer.Text)).Show();
            this.Hide();
        }

        private void SelectClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class utilisateurs : Form
    {
        public utilisateurs()
        {
            InitializeComponent();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void utilisateurs_Load(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            SelectUtilisateur.Rows.Clear();
            MySqlCommand requete = new MySqlCommand("select idU, login from autofact.utilisateur");
            requete.Connection = connection;
            MySqlDataReader reader = requete.ExecuteReader();

            while (reader.Read())
            {
                Object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                SelectUtilisateur.Rows.Add(values);
            }
        }

        private void AjouterUtilisateur_Click(object sender, EventArgs e)
        {
            Form AjoutUtilisateur = new AjoutUtilisateur();
            AjoutUtilisateur.Show();
            this.Hide();
        }

        private void SupprimerUtilisateur_Click(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("delete from autofact.utilisateur where id=@id", connection);
            cmd.Parameters.AddWithValue("@id", IdUtilisateur.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Utilisateur correctement supprimé !! ");
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void BoutonEffacer_Click(object sender, EventArgs e)
        {
            IdUtilisateur.Clear();
        }

        private void ModifierUtilisateur_Click(object sender, EventArgs e)
        {
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void SelectUtilisateur_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IdUtilisateur.Text = SelectUtilisateur.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}

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

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
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
            idCustomer.Text = SelectClient.Rows[e.RowIndex].Cells[0].Value.ToString();
            NewNomText.Text = SelectClient.Rows[e.RowIndex].Cells[1].Value.ToString();
            NewPrenomText.Text = SelectClient.Rows[e.RowIndex].Cells[2].Value.ToString();
            NewTelText.Text = SelectClient.Rows[e.RowIndex].Cells[3].Value.ToString();
            NewMailText.Text = SelectClient.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NewNomText.Text != "" && NewPrenomText.Text != "" && NewTelText.Text != "" && NewMailText.Text != "")
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
                new Menu().Show();
                this.Hide();
            MessageBox.Show("Customer informations Updated Successfully");
            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("delete from client where idC=@id", connection);
            cmd.Parameters.AddWithValue("@id", idCustomer.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Car Deleted Successfully!");
            new Menu().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AjoutClient().Show();
            this.Hide();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            idCustomer.Clear();
            NewNomText.Clear();
            NewPrenomText.Clear();
            NewTelText.Clear();
            NewMailText.Clear();
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
    }
}

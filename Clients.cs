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
    public partial class Customers : Form
    {
        public Customers()
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
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
        private void SelectClient_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idUser.Text = SelectClient.Rows[e.RowIndex].Cells[0].Value.ToString();
            NewLastnameText.Text = SelectClient.Rows[e.RowIndex].Cells[1].Value.ToString();
            NewFirstnameText.Text = SelectClient.Rows[e.RowIndex].Cells[2].Value.ToString();
            NewTelText.Text = SelectClient.Rows[e.RowIndex].Cells[3].Value.ToString();
            NewMailText.Text = SelectClient.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void UpdateCustomersBtn_Click(object sender, EventArgs e)
        {
            if (NewLastnameText.Text != "" && NewFirstnameText.Text != "" && NewTelText.Text != "" && NewMailText.Text != "")
            {
                string cs = "server=localhost;user=root;password=;database=autofact";
                MySqlConnection connection = new MySqlConnection(cs);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("update client set nom=@nom,prenom=@prenom,telephone=@telephone, mail=@mail where idC=@id", connection);
                cmd.Parameters.AddWithValue("@id", idUser.Text);
                cmd.Parameters.AddWithValue("@nom", NewLastnameText.Text);
                cmd.Parameters.AddWithValue("@prenom", NewFirstnameText.Text);
                cmd.Parameters.AddWithValue("@telephone", NewTelText.Text);
                cmd.Parameters.AddWithValue("@mail", NewMailText.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                Form Menu = new Menu();
                Menu.Show();
                this.Hide();
            MessageBox.Show("Customer informations Updated Successfully");
            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");

            }

        }
        private void DeleteCustomersBtn_Click(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("delete from client where idC=@id", connection);
            cmd.Parameters.AddWithValue("@id", idUser.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Car Deleted Successfully!");
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void AddCustomersBtn_Click(object sender, EventArgs e)
        {
            Form ajoutClient = new AjoutClient();
            ajoutClient.Show();
            this.Hide();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            idUser.Clear();
            NewLastnameText.Clear();
            NewFirstnameText.Clear();
            NewTelText.Clear();
            NewMailText.Clear();
        }
    }
}

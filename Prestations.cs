﻿using MySql.Data.MySqlClient;
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
    public partial class Prestations : Form
    {
        public object MessageBoxDefaultButtons { get; private set; }

        public Prestations()
        {
            InitializeComponent();
        }
        private void Prestations_Load(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            SelectServices.Rows.Clear();
            MySqlCommand requete = new MySqlCommand("select * from prestation order by idcateg");
            requete.Connection = connection;
            MySqlDataReader reader = requete.ExecuteReader();

            while (reader.Read())
            {
                Object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                SelectServices.Rows.Add(values);
            }

        }
        private void BackMenu_Click(object sender, EventArgs e)
        {
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void AddService_Click(object sender, EventArgs e)
        {
            new AjoutPrestation().Show();
            this.Hide();
        }

        private void UpdateService_Click(object sender, EventArgs e)
        {

        }

        private void DeleteService_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Voulez-vous vraiment supprimer cette prestation ? ", "Attention cette suppression est définitive !! ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("delete from prestation where idP= @id", connection);
            cmd.Parameters.AddWithValue("@id", IdPrestationText.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
                MessageBox.Show(" La prestation a bien été supprimée");
                Form Menu = new Menu();
                Menu.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }
        private void SelectServices_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                IdPrestationText.Text = SelectServices.Rows[e.RowIndex].Cells[0].Value.ToString();
                CategoryText.Text = SelectServices.Rows[e.RowIndex].Cells[1].Value.ToString();
                LabelText.Text = SelectServices.Rows[e.RowIndex].Cells[2].Value.ToString();
                DetailsText.Text = SelectServices.Rows[e.RowIndex].Cells[3].Value.ToString();
                PriceText.Text = SelectServices.Rows[e.RowIndex].Cells[4].Value.ToString();
                TvaText.Text = SelectServices.Rows[e.RowIndex].Cells[5].Value.ToString();

            }
        }

        public void ModifPrestation()
        {
            string id = IdPrestationText.Text;
            string label = LabelText.Text;
            string details = DetailsText.Text;
            string price = PriceText.Text;
            string tva = TvaText.Text;
            List<string> Variable = new List<string>() { id, label, details, price, tva};
            new ModifierPrestation(Variable).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdPrestationText.Text != "" && LabelText.Text != "" && DetailsText.Text != "" && PriceText.Text != "" && TvaText.Text != "")
            {
                ModifPrestation();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une prestation");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            SelectServices.Rows.Clear();
            MySqlCommand requete = new MySqlCommand("select * from prestation where LibellePrestation like concat('%',@libelle,'%')");
            requete.Parameters.AddWithValue("@libelle", SearchServices.Text);
            requete.Connection = connection;
            MySqlDataReader reader = requete.ExecuteReader();
            while (reader.Read())
            {
                Object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                SelectServices.Rows.Add(values);
            }
        }
    }
}
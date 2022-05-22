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
    public partial class ModifierPrestation : Form
    {
        public ModifierPrestation(List<string> parametres) : this()
        {
            idCustomer.Text = parametres[0];
            LabelText.Text = parametres[1];
            DetailsText.Text = parametres[2];
            PriceText.Text = parametres[3];
            TvaText.Text = parametres[4];


        }
        public ModifierPrestation()
        {
            InitializeComponent();
        }

        private void ModifierPrestation_Load(object sender, EventArgs e)
        {

        }

        private void AddConfirm_Click(object sender, EventArgs e)
        {
            if (idCustomer.Text != "" && LabelText.Text != "" && DetailsText.Text != "" && PriceText.Text != "" && TvaText.Text != "")
            {
                string cs = "server=localhost;user=root;password=;database=autofact";
                MySqlConnection connection = new MySqlConnection(cs);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("update prestation set LibellePrestation=@label,Description=@details,PrixHt=@price, Tva=@tva where Idp=@id", connection);
                cmd.Parameters.AddWithValue("@id", idCustomer.Text);
                cmd.Parameters.AddWithValue("@label", LabelText.Text);
                cmd.Parameters.AddWithValue("@details", DetailsText.Text);
                cmd.Parameters.AddWithValue("@price", PriceText.Text);
                cmd.Parameters.AddWithValue("@tva", TvaText.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                new Prestations().Show();
                this.Hide();
                MessageBox.Show("Les changements ont bien été enregistrées");
            }
            else
            {
                MessageBox.Show("Veuillez saisir les informations !");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Prestations().Show();
            this.Hide();
        }
    }
}

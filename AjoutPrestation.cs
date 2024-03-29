﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AutofactApp
{
    public partial class AjoutPrestation : Form
    {
        public AjoutPrestation()
        {
            InitializeComponent();
        }

        private void AjoutPrestations_Load(object sender, EventArgs e)
        {

            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            /*
            DataTable categ = new DataTable();
            MySqlDataAdapter adapt = new MySqlDataAdapter("select libelle from categorie", connection);
            adapt.Fill(categ);
            comboBox1.DataSource = categ;
            */
            MySqlCommand requete = new("select libelleCateg from categorie");
            requete.Connection = connection;
            MySqlDataReader reader = requete.ExecuteReader();

            while (reader.Read())
            {
                int i = 0;
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                CategoryText.Items.Add(values[i]);
                i++;
            }
        }
        private void Confirm_Click(object sender, EventArgs e)
        {
            string category = CategoryText.SelectedItem.ToString();
            string label= LabelText.Text;
            string details = DetailsText.Text;
            string price = PriceText.Text;
            string tva = TvaText.Text;



            int lenlabel = label.Length;
            int lendetails = details.Length;
            int lenprice = price.Length;
            if (category!= "" && label != "" && details != "" && price != "" && tva != "")
            {
                if (lendetails <32 && lenprice <32 && lenlabel <32 )
                {
                    string cs = "server=localhost;user=root;password=;database=autofact";
                    MySqlConnection connection = new MySqlConnection(cs);
                    connection.Open();
                    MySqlCommand idcategcmd = new MySqlCommand("select Id from categorie where LibelleCateg =@category", connection);
                    idcategcmd.Parameters.AddWithValue("@category", category);
                    var nbcateg = idcategcmd.ExecuteNonQuery();
                    if (nbcateg == 0)
                    {
                        MessageBox.Show("Nous n'avons pas trouvé de catégorie correspondante...");

                    }
                    else
                    {
                        object idcateg = idcategcmd.ExecuteScalar();
                        MySqlCommand cmd = new MySqlCommand("insert into prestation(IdCateg, LibellePrestation, Description, PrixHt, Tva) values(@category, @label,@details, @price, @tva)", connection);
                        cmd.Parameters.AddWithValue("@category", idcateg);
                        cmd.Parameters.AddWithValue("@label", label);
                        cmd.Parameters.AddWithValue("@details", details);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@tva", tva);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("La nouvelle prestation a bien été enregistrée");
                        new Prestations().Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Vous avez dépassé le nombre de caractère autorisé");
                }
            }
            else
            {
                MessageBox.Show(" Veuillez entrer les informations avant de valider ! ");
                LabelText.Clear();
                DetailsText.Clear();
                PriceText.Clear();
                CategoryText.Focus();
            }

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            LabelText.Clear();
            DetailsText.Clear();
            PriceText.Clear();
            CategoryText.Focus();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}

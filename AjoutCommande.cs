using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AutofactApp
{
    public partial class AjoutCommande : Form
    {
        public AjoutCommande()
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

        private void SearchCustomerText_TextChanged(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            SearchCustomerGrid.Rows.Clear();
            MySqlCommand requete = new MySqlCommand("select * from client where nom like concat('%',@nom,'%')");
            requete.Parameters.AddWithValue("@nom", SearchCustomerText.Text);
            requete.Connection = connection;
            MySqlDataReader reader = requete.ExecuteReader();
            while (reader.Read())
            {
                Object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                SearchCustomerGrid.Rows.Add(values);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            idCustomer.Clear();
            NewNomText.Clear();
            NewPrenomText.Clear();
            NewTelText.Clear();
            NewMailText.Clear();

        }

        private void AddConfirm_Click(object sender, EventArgs e)
        {
            if (NewPrenomText.Text != "" && NewNomText.Text != "" && NewMailText.Text != "" && NewTelText.Text != "" && NewLabelText.Text != "" && NewDetailsText.Text != "" && NewQuantityText.Text != "" && NewPriceText.Text != "" && selectService.Text != "")
            {
                string DateActu = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string cs = "server=localhost;user=root;password=;database=autofact";
                MySqlConnection connection = new MySqlConnection(cs);
                MySqlCommand insertcmd = new MySqlCommand("insert into commande(IdClient,DateCreation, Paye) values(@idCustomer, @date, 0)", connection);
                connection.Open();
                insertcmd.Parameters.AddWithValue("@idcustomer", idCustomer.Text);
                insertcmd.Parameters.AddWithValue("@date", DateActu);
                insertcmd.ExecuteNonQuery();
                connection.Close();
                connection.Open();
                MySqlCommand maxidcmd = new MySqlCommand("select max(IdCommande) from commande", connection);
                int LastIdCmd = int.Parse(maxidcmd.ExecuteScalar().ToString());
                MySqlCommand cmd = new MySqlCommand("insert into contenir(IdCommande,IdPrestation, Quantite) values(@cmd, @service, @quantity)", connection);
                cmd.Parameters.AddWithValue("@cmd", LastIdCmd);
                cmd.Parameters.AddWithValue("@service", IdService.Text);
                cmd.Parameters.AddWithValue("@quantity", NewQuantityText.Text);
                int nb = cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("La commande a bien été executée", "commande enregistrée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AjoutCommande_Load(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            SearchCustomerGrid.Rows.Clear();
            MySqlCommand requete = new MySqlCommand("select * from client");
            requete.Connection = connection;
            MySqlDataReader reader = requete.ExecuteReader();

            while (reader.Read())
            {
                Object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                SearchCustomerGrid.Rows.Add(values);
            }
            connection.Close();
        }

        private void SearchCustomerGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idCustomer.Text = SearchCustomerGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            NewNomText.Text = SearchCustomerGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            NewPrenomText.Text = SearchCustomerGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            NewTelText.Text = SearchCustomerGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            NewMailText.Text = SearchCustomerGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void ChoiceService_Click(object sender, EventArgs e)
        {
            NewQuantityText.Enabled = true;
            string service = selectService.Text;
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            MySqlCommand idcmd = new MySqlCommand("select Idp from prestation where LibellePrestation=@Category", connection);
            idcmd.Parameters.AddWithValue("@Category", service);
            string idp = idcmd.ExecuteScalar().ToString();
            IdService.Text = idp;

            MySqlCommand cmd = new MySqlCommand("select Description from prestation where LibellePrestation=@Category", connection);
            cmd.Parameters.AddWithValue("@Category", service);
            string DetailsCmd = cmd.ExecuteScalar().ToString();
            NewDetailsText.Text = DetailsCmd;

            MySqlCommand Prixcmd = new MySqlCommand("select PrixHt from prestation where LibellePrestation=@Category", connection);
            Prixcmd.Parameters.AddWithValue("@Category", service);
            string Pricecmd = Prixcmd.ExecuteScalar().ToString();
            NewPriceText.Text = Pricecmd;
            connection.Close();
            NewLabelText.Text = service;
        }

        private void NewQuantityText_TextChanged(object sender, EventArgs e)
        {

            if (NewQuantityText.Text != "")
            {
                if (NewQuantityText.Text != "0")
                {
                    float Quantity = float.Parse(NewQuantityText.Text);
                    float Price = float.Parse(NewPriceText.Text);


                    TotalPriceText.Text = CalculTotalPriceCmd(Quantity, Price).ToString();

                }
                else
                {
                    TotalPriceText.Text = "";
                }
            }
            else
            {
                TotalPriceText.Text = "";
            }
        }
        public static float CalculTotalPriceCmd(float Quantity, float Price)
        {
            return (float)(Quantity * Price * 1.2);
        }
        private void Radioservice_CheckedChanged(object sender, EventArgs e)
        {
            selectService.Items.Clear();
            selectService.Text = "";
            NewQuantityText.Text = "";
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            MySqlCommand selectLibelle = new("select distinct LibellePrestation from prestation where IdCateg = (select Id from categorie where LibelleCateg=@LibelleCateg)");
            selectLibelle.Parameters.AddWithValue("@LibelleCateg", Radioservice.Text);
            selectLibelle.Connection = connection;
            MySqlDataReader readerlibelle = selectLibelle.ExecuteReader();
            while (readerlibelle.Read())
            {
                int i = 0;
                object[] values = new object[readerlibelle.FieldCount];
                readerlibelle.GetValues(values);
                selectService.Items.Add(values[i]);
                i++;
            }
            connection.Close();

        }

        private void Radioproduit_CheckedChanged(object sender, EventArgs e)
        {
            selectService.Items.Clear();
            selectService.Text = "";
            NewQuantityText.Text = "";
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            MySqlCommand selectLibelle = new("select distinct LibellePrestation from prestation where IdCateg = (select Id from categorie where LibelleCateg=@LibelleCateg)");
            selectLibelle.Parameters.AddWithValue("@LibelleCateg", Radioproduit.Text);
            selectLibelle.Connection = connection;
            MySqlDataReader readerlibelle = selectLibelle.ExecuteReader();
            while (readerlibelle.Read())
            {
                int i = 0;
                object[] values = new object[readerlibelle.FieldCount];
                readerlibelle.GetValues(values);
                selectService.Items.Add(values[i]);
                i++;
            }
            connection.Close();
        }
    }
}
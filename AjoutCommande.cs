using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace AutofactApp
{
    public partial class AjoutCommande : Form
    {
        public AjoutCommande(int parametre) : this()
        {
            idCustomer.Text = parametre.ToString();
        }
        public AjoutCommande()
        {
            InitializeComponent();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            new clients().Show();
            this.Hide();
        }

        private void SelectClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void AddConfirm_Click(object sender, EventArgs e)
        {
            if (idCustomer.Text!="" && NewLabelText.Text != "" && NewDetailsText.Text != "" && NewQuantityText.Text != "" && NewPriceText.Text != "" && selectService.Text != "")
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
                this.Hide();
                new clients().Show();
            }
        }

        private void AjoutCommande_Load(object sender, EventArgs e)
        {

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
        ///<summary>This a function to calculate the totalprice of a customer's command </summary>
        /// <param name="Quantity"> Represents the object's Quantity in the command</param>
        /// <param name="Price"> Represents the object's Price in the command</param>
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
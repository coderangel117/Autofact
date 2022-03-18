using MySql.Data.MySqlClient;
using System;
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
        }

        private void Confirm_Click(object sender, EventArgs e)
        {

            string category = CategoryText.Text;
            string label= LabelText.Text;
            string details = DetailsText.Text;
            string price = PriceText.Text;
            if (category!= "" && label != "" && details != "" && price != "")
            {
                string cs = "server=localhost;user=root;password=;database=autofact";
                MySqlConnection connection = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand("insert into prestation(IdCateg, Libelle, Description, PrixHt) values(@category, @label,@details, @price )", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@label", label);
                cmd.Parameters.AddWithValue("@details",details );
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Les informations du client ont bien été ajoutées");
            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");
            }
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    

        private void Clear_Click(object sender, EventArgs e)
        {
            CategoryText.Clear();
            LabelText.Clear();
            DetailsText.Clear();
            PriceText.Clear();
            CategoryText.Focus();
        }
    }
}

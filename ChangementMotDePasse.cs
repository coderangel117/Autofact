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
    public partial class ChangementMotDePasse : Form
    {
        public ChangementMotDePasse()
        {
            InitializeComponent();
        }

        private void ChangementMotDePasse_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmerChangementMdp_Click(object sender, EventArgs e)
        {
            if (NouveauMdpBox.Text != "" && ConfirmationNouveauMdpBox.Text != "" && AncienMdpBox.Text != "")
            {
                if (NouveauMdpBox.Text == ConfirmationNouveauMdpBox.Text) {
                    string cs = "server=localhost;user=root;password=;database=autofact";
                    MySqlConnection connection = new MySqlConnection(cs);
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("update utilisateur set password=@ConfirmMdp where password=@AncienMdp", connection);
                    cmd.Parameters.AddWithValue("@AncienMdp", AncienMdpBox.Text);
                    cmd.Parameters.AddWithValue("@ConfirmMdp", NouveauMdpBox.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Form Menu = new Menu();
                    Menu.Show();
                    this.Hide();
                    MessageBox.Show("Customer informations Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Les deux mdp doivent être identiques !! ");
                }
            }
            else
            {
                MessageBox.Show("Please enter mandatory details!");

            }
        }

        private void EffacerChamps_Click(object sender, EventArgs e)
        {

        }
    }
}

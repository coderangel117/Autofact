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
    public partial class ChangeFormMdp : Form
    {
        public ChangeFormMdp()
        {
            InitializeComponent();
        }
        private void ConfirmerChangementMdp_Click(object sender, EventArgs e)
        {
            if (NewMdpBox.Text != "" && ConfirmNewMdpBox.Text != "" && OldMdpBox.Text != "")
            {
                if (NewMdpBox.Text == ConfirmNewMdpBox.Text) {
                    string cs = "server=localhost;user=root;password=;database=autofact";
                    MySqlConnection connection = new MySqlConnection(cs);
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("update utilisateur set password=@NewMdp where password=@OldMdp", connection);
                    cmd.Parameters.AddWithValue("@OldMdp", OldMdpBox.Text);
                    cmd.Parameters.AddWithValue("@NewMdp", NewMdpBox.Text);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Form Menu = new Menu();
                    Menu.Show();
                    this.Hide();
                    MessageBox.Show("Les informations du clients ont bien été modifiés !! ");
                }
                else
                {
                    MessageBox.Show("Les deux mdp doivent être identiques !! ");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis");

            }
        }

        private void EffacerChamps_Click(object sender, EventArgs e)
        {

        }
    }
}

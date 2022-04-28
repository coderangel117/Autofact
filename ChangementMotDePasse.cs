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
            LoginBox.Focus();
        }
        private void ConfirmerChangementMdp_Click(object sender, EventArgs e)
        {
            string Login = LoginBox.Text;
            string Oldmdp = AncienMdpBox.Text;
            string Newpwd = NouveauMdpBox.Text;
            string ConfirmMdp = ConfirmationNouveauMdpBox.Text;

            if (Login!= "" && Newpwd!= "" && ConfirmMdp!= "" && Oldmdp!= "")
            {
                if (Newpwd == ConfirmMdp) {

                    string cs = "server=localhost;user=root;password=;database=autofact";
                    MySqlConnection connection = new MySqlConnection(cs);
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("select password from utilisateur where login = '" + Login+ "'", connection);

                    string mdpbdd = cmd.ExecuteScalar().ToString();

                    if (BCrypt.Net.BCrypt.Verify(Oldmdp, mdpbdd) == false)
                    {
                        MessageBox.Show("l'ancien mot de passe est incorrect !! ", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                     MySqlCommand update = new MySqlCommand("update utilisateur set password=@ConfirmMdp where password=@AncienMdp", connection);
                     update.Parameters.AddWithValue("@AncienMdp", mdpbdd);
                     string NewPasswordHashed = BCrypt.Net.BCrypt.HashPassword(Newpwd);
                     update.Parameters.AddWithValue("@ConfirmMdp", NewPasswordHashed);
                     update.ExecuteNonQuery();
                     connection.Close();
                     new Menu().Show();
                     this.Hide();
                     MessageBox.Show("Le mot de passe a bien été changé");
                }
                else
                {
                    MessageBox.Show("Les deux mdp doivent être identiques !! ");
                }
            }else
            {
                MessageBox.Show("Tous les champs doivent être remplis !! ");

            }
        }


        private void EffacerChamps_Click(object sender, EventArgs e)
        {
            AncienMdpBox.Clear();
            NouveauMdpBox.Clear();
            ConfirmationNouveauMdpBox.Clear();
        }

        private void RetourMenu_Click(object sender, EventArgs e)
        {
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();

        }
    }
}

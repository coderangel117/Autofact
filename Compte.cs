using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace AutofactApp
{
    public partial class Compte : Form
    {
        public Compte()
        {
            InitializeComponent();
        }

        private void ConfirmLog_Click(object sender, EventArgs e)
        {
            if(Logintext.Text!="" && Passtext.Text !="" && ConfirmPassText.Text != "")
            {
                if (Passtext.Text == ConfirmPassText.Text)
                {
                    string NewPasswordHashed = BCrypt.Net.BCrypt.HashPassword(Passtext.Text);
                    string cs = "server=localhost;user=root;password=;database=autofact";
                    MySqlConnection connection = new MySqlConnection(cs);
                    connection.Open();
                    MySqlCommand cmd = new("insert into utilisateur (login, password) values (@login, @password)", connection);
                    cmd.Parameters.AddWithValue("@login", Logintext.Text);
                    cmd.Parameters.AddWithValue("@password", NewPasswordHashed);
                    connection.Close();
                    new Accueil().Show();
                    this.Hide();
                    MessageBox.Show("Votre compte a bien été créé. Vous pouvez maintenant vous connecter.");
                }
                else
                {
                    MessageBox.Show("Les mots de passe doivent être les mêmes!!", " Vous n'avez pas rentré le même mot de passe  !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logintext.Text = "";
                    Logintext.Focus();
                    Passtext.Text = "";
                    ConfirmPassText.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Les champs doivent être remplis !!", "Les champs sont vides !!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Logintext.Text = "";
                Logintext.Focus();
                Passtext.Text = "";
                ConfirmPassText.Text = "";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Logintext.Text = "";
            Logintext.Focus();
            Passtext.Text = "";
            ConfirmPassText.Text = "";
        }
    }
}

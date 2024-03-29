﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AutofactApp
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmLog_Click(object sender, EventArgs e)
        {
            string username = Logintext.Text;
            string user_password = Passtext.Text;
            string passwordHashed = BCrypt.Net.BCrypt.HashPassword(user_password);

            if (username != "" && user_password !="" ) {
                string cs = "server=localhost;user=root;password=;database=autofact";
                MySqlConnection connection = new MySqlConnection(cs);
                connection.Open();
                MySqlCommand cmd = new("select password from utilisateur where login=@username", connection);
                cmd.Parameters.AddWithValue("@username", username);
                string mdpbdd = cmd.ExecuteScalar().ToString();

                    if (BCrypt.Net.BCrypt.Verify(user_password, mdpbdd))
                    {
                    new Menu().Show();
                    this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("le mot de passe est incorrect !! ", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Logintext.Clear();
                        Passtext.Clear();
                        Logintext.Focus();
                    }
            }
            else
            {
                MessageBox.Show("Les champs doivent être remplis !! ", "Erreur d'authentification !! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logintext.Clear();
                Passtext.Clear();
                Logintext.Focus();
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            Passtext.Clear();
            Logintext.Clear();
            Logintext.Focus();
        }

        private void newUser_Click(object sender, EventArgs e)
        {
            new Compte().Show();
        }

        private void Logintext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

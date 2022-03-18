using System;
using MySql.Data.MySqlClient;
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
    public partial class AjoutUtilisateur : Form
    {
        public AjoutUtilisateur()
        {
            InitializeComponent();
        }
        private void ConfirmAdd_Click(object sender, EventArgs e)
        {
            string username, user_password;
            username = NewLoginText.Text;
            user_password = NewPassText.Text;
            if (NewLoginText.Text != "" && NewPassText.Text != "" )
            {
                string passwordHashed = BCrypt.Net.BCrypt.HashPassword(user_password);

                string cs = "server=localhost;user=root;password=;database=autofact";
                MySqlConnection connection = new MySqlConnection(cs);
                MySqlCommand cmd = new MySqlCommand("insert into utilisateur(login,password) values(@login, @password)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@login", user_password);
                cmd.Parameters.AddWithValue("@password", passwordHashed);
                cmd.ExecuteNonQuery();
                connection.Close();
                DialogResult res;
                res = MessageBox.Show("Voulez vous vous connecter avec ce nouvel utilisateur ? ", "Vos informations d'utilisateur ont bien été ajoutées !!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Form Accueil = new Accueil();
                    Accueil.Show();
                    this.Hide();
                }
            }
            else{
                MessageBox.Show("Please enter mandatory details!");
            }
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            NewPassText.Clear();
            NewLoginText.Clear();
            NewLoginText.Focus();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    }
}

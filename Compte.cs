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
using System.Text.RegularExpressions;

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
            if(Logintext.Text!="" && ConfirmPassText.Text != "")
            {
                if (Passtext.Text == ConfirmPassText.Text)
                {
                    string password = Passtext.Text;
                    if(ValidatePassword(password) == true)
                    {

                        string NewPasswordHashed = BCrypt.Net.BCrypt.HashPassword(Passtext.Text);
                        string cs = "server=localhost;user=root;password=;database=autofact";
                        MySqlConnection connection = new MySqlConnection(cs);
                        connection.Open();
                        MySqlCommand cmd = new("insert into utilisateur (login, password) values (@login, @password)", connection);
                        cmd.Parameters.AddWithValue("@login", Logintext.Text);
                        cmd.Parameters.AddWithValue("@password", NewPasswordHashed);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        this.Hide();
                        MessageBox.Show("Votre compte a bien été créé. Vous pouvez maintenant vous connecter.");
                    }
                    else
                    {
                        MessageBox.Show("Votre mot de passe ne convient pas !! .");
                    }
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

        private void Compte_Load(object sender, EventArgs e)
        {
            Passtext.UseSystemPasswordChar = true;
            ConfirmPassText.UseSystemPasswordChar = true;
        }
        public bool ValidatePassword(string password)
        {
            int pointTotal = 10;
            int length = password.Length;
            int pointLong = 0;
            int pointCompl = 0;
            if (length < 12 ){return false; }else { pointLong = 1; }
            if(Regex.IsMatch(password, "[a-z]+")) { pointCompl += 1; }
            if (Regex.IsMatch(password, "[A-Z]+")) { pointCompl += 2; }
            if (Regex.IsMatch(password, "\\d+")) { pointCompl += 3; }
            if (Regex.IsMatch(password, "[\\-_&~*.@[{()}*+?^$|]+")) { pointCompl += 4; }
            int resultat = pointLong * pointCompl;
            return (pointTotal == resultat);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Passtext.UseSystemPasswordChar = false;
                ConfirmPassText.UseSystemPasswordChar = false;
            }
            else
            {
                Passtext.UseSystemPasswordChar = true;
                ConfirmPassText.UseSystemPasswordChar = true;
            }
        }

        private void ConfirmPassText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

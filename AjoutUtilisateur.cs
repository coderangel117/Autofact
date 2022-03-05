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

        private void NouveauUtilisateur_Load(object sender, EventArgs e)
        {

        }
        private void ConfirmAdd_Click(object sender, EventArgs e)
        {
            string username, user_password;
            username = NewLoginText.Text;
            user_password = NewPassText.Text;
            try
            {
                string cs = "server=localhost;user=root;password=;database=autofact";
                MySqlConnection connection = new MySqlConnection(cs);
                connection.Open();
                string AddQuery = "INSERT INTO utilisateur ('login', 'password')  VALUES(" + NewLoginText.Text + "," + NewPassText.Text + ")";
                MySqlCommand cmd = new MySqlCommand(AddQuery, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@login", NewLoginText.Text);
                cmd.Parameters.AddWithValue("@password", NewPassText.Text);
                int i = cmd.ExecuteNonQuery();
                connection.Close();
                    if (i != 0){
                    MessageBox.Show(i + "Data Saved");
                    }
           
                else{
                    MessageBox.Show("Invalid login details !! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NewPassText.Clear();
                    NewLoginText.Clear();
                    NewLoginText.Focus();
                }
            }catch{
                MessageBox.Show("Error !! ");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            NewPassText.Clear();
            NewLoginText.Clear();
            NewLoginText.Focus();
        }
    }
}

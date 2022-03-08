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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            Form Clients = new Customers();
            Clients.Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            Form ListeUtilisateurs = new utilisateurs();
            ListeUtilisateurs.Show();
            this.Hide();
        }

        private void ChangementMdpButton_Click(object sender, EventArgs e)
        {

            Form ChangeMdp = new ChangeFormMdp();
            ChangeMdp.Show();
            this.Hide();
        }
    }
}

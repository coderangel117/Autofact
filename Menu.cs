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

        private void Customers_Click(object sender, EventArgs e)
        {
            Form Customers = new clients();
            Customers.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
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

        private void ChangeMdp_Click(object sender, EventArgs e)
        {
            new ChangementMotDePasse().Show();
            this.Hide();
        }

        private void Services_Click(object sender, EventArgs e)
        {
            new Prestations().Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Commandes().Show();
        }
    }
}

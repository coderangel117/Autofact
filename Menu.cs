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
            res = MessageBox.Show("Do you want to exit ", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void Users_Click(object sender, EventArgs e)
        {
            Form Users = new utilisateurs();
            Users.Show();
            this.Hide();
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
    }
}

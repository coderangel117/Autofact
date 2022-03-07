﻿using System;
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

        private void Clients_Click(object sender, EventArgs e)
        {
            Form Clients = new clients();
            Clients.Show();
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

        private void utilisateurs_Click(object sender, EventArgs e)
        {
            Form ListeUtilisateurs = new utilisateurs();
            ListeUtilisateurs.Show();
            this.Hide();
        }

        private void ChangementMdp_Click(object sender, EventArgs e)
        {

            Form ChangeMdp = new ChangementMotDePasse();
            ChangeMdp.Show();
            this.Hide();
        }
    }
}

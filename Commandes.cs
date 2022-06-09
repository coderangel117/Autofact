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
    public partial class Commandes : Form
    {
        public Commandes()
        {
            InitializeComponent();
        }

        private void Commandes_Load(object sender, EventArgs e)
        {
            string cs = "server=localhost;user=root;password=;database=autofact";
            MySqlConnection connection = new MySqlConnection(cs);
            connection.Open();
            selectCmd.Rows.Clear();
            MySqlCommand requete = new MySqlCommand(@"select prestation.LibellePrestation as libelle,
prestation.Description as description, 
categorie.LibelleCateg as categorie, 
commande.DateCreation,
commande.Paye, 
prestation.PrixHt,
contenir.Quantite,
prestation.Tva,
prestation.PrixHt * contenir.Quantite * (1 + prestation.Tva / 100) as prixTotalTTC
from commande
Inner join contenir ON commande.IdCommande = contenir.IdCommande
inner join prestation on prestation.Idp = contenir.IdPrestation
inner join categorie ON categorie.Id = prestation.IdCateg;");
            requete.Connection = connection;
            MySqlDataReader reader = requete.ExecuteReader();

            while (reader.Read())
            {
                Object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                selectCmd.Rows.Add(values);
            }
        }
    }
}

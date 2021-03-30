using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Ventes
{
    public partial class HistoriqueVentes : Form
    {
        SQLiteConnection DB;
        Panier panier;
        public HistoriqueVentes(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initListVentes();
        }

        private void HistoriqueVentes_Load(object sender, EventArgs e)
        {
            listViewVentesPassees.View = View.Details;
            listViewVentesPassees.GridLines = true;
            listViewVentesPassees.FullRowSelect = true;
        }

        public void initListVentes()
        {
            decimal prixTotal = 0;
            listViewVentesPassees.Items.Clear();
            foreach (Panier p in DB.GetAllWithChildren<Panier>())
            {
                string[] arr = new string[3];
                ListViewItem lst;
                arr[0] = p.id_panier.ToString();
                arr[1] = p.client.nom.ToString();
                foreach (ProduitCommande prod in p.produits)
                {
                    prixTotal = prixTotal + (prod.produit.prix_vente_TTC * prod.quantite);
                }
                arr[2] = prixTotal.ToString();
                lst = new ListViewItem(arr);
                listViewVentesPassees.Items.Add(lst);
            }  
        }
    }
}

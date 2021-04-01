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
            initItemsColors();
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
            List<Panier> paniers = DB.GetAllWithChildren<Panier>();

            foreach (Panier p in paniers)
            {
                string[] arr = new string[3];
                ListViewItem lst;
                arr[0] = p.id_panier.ToString();
                arr[1] = p.client.nom;
                foreach (ProduitCommande prod in p.produits)
                {
                    Produit produit = DB.GetWithChildren<Produit>(prod.id_produit);
                    prixTotal = prixTotal + (produit.prix_vente_TTC * prod.quantite);
                }
                arr[2] = prixTotal.ToString()+ "€";
                lst = new ListViewItem(arr);
                listViewVentesPassees.Items.Add(lst);
            }  
        }

        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(80, 12, 12, 12);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

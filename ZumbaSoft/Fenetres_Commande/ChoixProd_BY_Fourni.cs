using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Commande
{
    public partial class ChoixProd_BY_Fourni : Form
    {
        private SQLiteConnection DB;
        private Fournisseur fournisseur;
        public ProduitToCommande pTc;
        public ChoixProd_BY_Fourni(SQLiteConnection db, Fournisseur f)
        {
            InitializeComponent();
            DB = db;
            fournisseur = f;
            labelProduit.Text += fournisseur.nom + " :";
            initListProd();
        }

        private void initListProd()
        {
            List<Produit> produits = DB.GetAllWithChildren<Produit>().FindAll(p => p.fournisseur.nom == fournisseur.nom);
            foreach (Produit produit in produits)
            {
                listBoxProduits.Items.Add(produit);
            }
        }

        private void barreQuantite_ValueChanged(object sender, EventArgs e)
        {
            if (labelErreurBarreQtt.Visible)
            {
                labelErreurBarreQtt.Visible = false;
            }
        }
        private void textBoxRecherchePrd_TextChanged(object sender, EventArgs e)
        {
            string searche = textBoxRecherchePrd.Text.ToUpper();
            List<Produit> produitsSearched = DB.GetAllWithChildren<Produit>().FindAll(p => p.nom.ToUpper().Contains(searche) && p.fournisseur.nom == fournisseur.nom);
            listBoxProduits.Items.Clear();
            foreach (Produit p in produitsSearched)
            {
                listBoxProduits.Items.Add(p);
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (barreQuantite.Value != 0)
            {
                pTc = new ProduitToCommande() { produit = (Produit)listBoxProduits.SelectedItem, quantite = (int)barreQuantite.Value };
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                labelErreurBarreQtt.Visible = true;
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

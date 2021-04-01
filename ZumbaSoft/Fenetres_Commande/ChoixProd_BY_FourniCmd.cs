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
    public partial class ChoixProd_BY_FourniCmd : Form
    {
        private SQLiteConnection DB;
        private Fournisseur fournisseur;
        private List<Produit> produits;
        public ProduitToCommande pTc;
        public ChoixProd_BY_FourniCmd(SQLiteConnection db, Fournisseur f,List<Produit> p)
        {
            InitializeComponent();
            DB = db;
            fournisseur = f;
            produits = p;
            labelProduit.Text += fournisseur.nom + " :";
            initListProd();
            initItemsColors();
        }

        private void initListProd()
        {
            if(produits.Count > 0)
            {
                foreach (Produit produit in produits)
                {
                    listBoxProduits.Items.Add(produit);
                }
            }
            else
            {
                listBoxProduits.Items.Add("Aucun autre produit.");
                buttonAjouter.Enabled = false;
            }
        }

        /// <summary>
        /// Initialise tranparent effects.
        /// </summary>
        public void initItemsColors()
        {
            panel1.BackColor = Color.FromArgb(50, 12, 12, 12);

            backgroundBlock1.BackColor = Color.FromArgb(50, 12, 12, 12);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAjouter.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
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
            List<Produit> produitsSearched = produits.FindAll(p => p.nom.ToUpper().Contains(searche));
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

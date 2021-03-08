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

namespace ZumbaSoft.Fenetres_Commande
{
    public partial class ChoixProd_Fourni : Form
    {
        SQLiteConnection DB;
        Produit produit;
        int quantite;

        public ChoixProd_Fourni(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
        }
        /// <summary>
        /// Permet de charger tous les produits dans la listes des produits.
        /// </summary>
        private void initListStock()
        {
            List<Produit> listProd = DB.GetAllWithChildren<Produit>(); //Et non pas Table<T>().ToList() car sinon on obtient pas le fournisseur
            if (listProd.Count > 0)
            {
                foreach (Produit p in listProd)
                {
                    listBoxProduits.Items.Add(p);
                }
            }
            else
            {
                listBoxProduits.Items.Add("Aucun produit en stock.");
            }
        }

        private void listBoxProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSelectionner.Enabled = true;
        }

        private void listBoxFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonAjouterStock_Click(object sender, EventArgs e)
        {

        }

        private void buttonAjouterStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRecherchePrd_TextChanged(object sender, EventArgs e)
        {
            string searche = textBoxRecherchePrd.Text.ToUpper();
            List<Produit> produitsSearched = DB.GetAllWithChildren<Produit>().FindAll(p => p.nom.ToUpper().Contains(searche));
            listBoxProduits.Items.Clear();
            foreach (Produit p in produitsSearched)
            {
                listBoxProduits.Items.Add(p);
            }
        }

        private void buttonSelectionner_Click(object sender, EventArgs e)
        {
            if(barreQuantite.Value != 0)
            {
                produit = (Produit)listBoxProduits.SelectedItem;
                quantite = (int)barreQuantite.Value;
                swithToFourni();
            }
            else
            {
                labelErreurBarreQtt.Visible = true;
            }
        }
        /// <summary>
        /// Permet de rendre les champs de produit innaccessible et ceux de fournisseur accessible.
        /// </summary>
        private void swithToFourni()
        {
            buttonSelectionner.Enabled = false;
            listBoxProduits.Enabled = false;
            textBoxRecherchePrd.Enabled = false;
            barreQuantite.Enabled = false;

            textBoxRechercheFourni.Enabled = true;
            listBoxFournisseur.Enabled = true;
        }

        private void barreQuantite_ValueChanged(object sender, EventArgs e)
        {
            if (labelErreurBarreQtt.Visible)
            {
                labelErreurBarreQtt.Visible = false;
            }
        }
    }
}

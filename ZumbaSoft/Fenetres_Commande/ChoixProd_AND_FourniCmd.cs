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
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace ZumbaSoft.Fenetres_Commande
{
    public partial class ChoixProd_AND_FourniCmd : Form
    {
        SQLiteConnection DB;
        public ProduitToCommande pTc;
        public Fournisseur fournisseur;

        public ChoixProd_AND_FourniCmd(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initListProduit();
        }

        /// <summary>
        /// Permet de charger tous les produits dans la listes des produits.
        /// </summary>
        private void initListProduit()
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
                listBoxProduits.Items.Add("Aucun produit.");
            }
        }

        /// <summary>
        /// Pour modifier la méthode de comparaison entre deux Produits.
        /// </summary>
        public class ProduitComparer : IEqualityComparer<Produit>
        {
            public bool Equals([AllowNull] Produit x, [AllowNull] Produit y)
            {
                return x.nom == y.nom;
            }

            public int GetHashCode([DisallowNull] Produit obj)
            {
                return obj.GetHashCode();
            }
        }

        /// <summary>
        /// Permet de charger tous les fournisseur possible en fonction du produit choisit.
        /// </summary>
        private void initListFournisseur()
        {
            List<Fournisseur> listFourni = DB.GetAllWithChildren<Fournisseur>().FindAll(f => f.produits.Contains(pTc.produit, new ProduitComparer()));

            if(listFourni.Count > 0)
            {
                foreach(Fournisseur f in listFourni)
                {
                    listBoxFournisseur.Items.Add(f);
                }
            }
            else
            {
                listBoxFournisseur.Items.Add("Aucun Fournisseur ne propose le produit choisi.");
            }
        }

        /// <summary>
        /// Rend le boutton Selectionner clicable lorsqu'un produit est sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSelectionner.Enabled = true;
        }

        /// <summary>
        /// Annule la saisit en cour.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonAjouterStock_Click(object sender, EventArgs e)
        {
            fournisseur = (Fournisseur)listBoxFournisseur.SelectedItem;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Gestion de la barre de recherche des produits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Permet de verrouiller un produit ainsi qu'une quantité avant de choisir le fournisseur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSelectionner_Click(object sender, EventArgs e)
        {
            if(barreQuantite.Value != 0)
            {
                pTc = new ProduitToCommande() { produit = (Produit)listBoxProduits.SelectedItem, quantite = (int)barreQuantite.Value };
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
            initListFournisseur();
        }

        /// <summary>
        /// Gestion du label d'erreur si l'utilisateur change la quantité.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barreQuantite_ValueChanged(object sender, EventArgs e)
        {
            if (labelErreurBarreQtt.Visible)
            {
                labelErreurBarreQtt.Visible = false;
            }
        }

        private void textBoxRechercheFourni_TextChanged(object sender, EventArgs e)
        {
            string searche = textBoxRechercheFourni.Text.ToUpper();
            List<Fournisseur> fourniSearched = DB.GetAllWithChildren<Fournisseur>().FindAll(f => f.nom.ToUpper().Contains(searche) && f.produits.Contains<Produit>(pTc.produit));
            listBoxProduits.Items.Clear();
            foreach (Fournisseur f in fourniSearched)
            {
                listBoxFournisseur.Items.Add(f);
            }
        }
    }
}

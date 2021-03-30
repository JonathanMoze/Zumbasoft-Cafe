﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;
using ZumbaSoft.Fenetres_Commande;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ZumbaSoft.Fenetres_Stock
{
    public partial class AccueilStock : Form
    {
        Magasin magasin;
        SQLiteConnection DB;

        public AccueilStock(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;

            labelDate.Text = DateTime.Today.ToString("d");
            //labelMagasin.Text = magasin.ToString();

            initTableauAndFieldsStock();
            initTableauCommandes();
        }
        /// <summary>
        /// Fill the grid of all product in stock using the DataBase.
        /// </summary>
        private void initTableauAndFieldsStock()
        {
            //Init Tableau
            int nbArticle = 0;
            decimal valStock = 0;
            List<ProduitEnStock> stock = DB.GetAllWithChildren<ProduitEnStock>(); //.FindAll(p => p.magasin.id_magasin == magasin.id_magasin);
            foreach (ProduitEnStock pEs in stock)
            {
                nbArticle += pEs.quantite;
                valStock += pEs.quantite * pEs.produit.prix_vente_TTC;
                Fournisseur f = DB.Get<Fournisseur>(pEs.produit.id_fournisseur);
                object[] row = { pEs.id_produit, pEs.produit.nom, f, pEs.quantite, pEs.produit.prix_vente_TTC, pEs.produit.etat };
                tableauStock.Rows.Add(row);
            }
            //Init Fields
            textBoxNbArticle.Text = nbArticle.ToString();
            textBoxValeurStk.Text = valStock.ToString() + " €";
        }
        /// <summary>
        /// Fill the grid of all command using the DataBase.
        /// </summary>
        private void initTableauCommandes()
        {
            List<Commande> commandes = DB.GetAllWithChildren<Commande>();
            foreach (Commande commande in commandes)
            {
                commande.PTC = DB.GetAllWithChildren<ProduitToCommande>().FindAll(ptc => ptc.id_commande == commande.id_commande);
                decimal totalTTC = 0;
                foreach(ProduitToCommande pTc in commande.PTC)
                {
                    totalTTC += pTc.produit.prix_achat_TTC * pTc.quantite;
                }
                object[] row = { commande.reference, commande.dateCommande, commande.fournisseur, commande.etat, totalTTC };
                tableauCommandes.Rows.Add(row);
            }
        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonNouvelleCmd_Click(object sender, EventArgs e)
        {
            GestionDeLaCommande gc = new GestionDeLaCommande(DB,magasin);
            if(gc.ShowDialog() == DialogResult.OK)
            {
                decimal totalTTC = 0;
                foreach (ProduitToCommande pTc in gc.commande.PTC)
                {
                    totalTTC += pTc.produit.prix_achat_TTC * pTc.quantite;
                }
                object[] row = { gc.commande.reference, gc.commande.dateCommande, gc.commande.fournisseur, gc.commande.etat, totalTTC };
                tableauCommandes.Rows.Add(row);
            }
        }

        private void buttonModifierCmd_Click(object sender, EventArgs e)
        {
            List<Commande> commandes = DB.GetAllWithChildren<Commande>();
            Commande commande;
            DataGridViewRow row;
            if (tableauCommandes.SelectedRows.Count != 0)
            {
                row = tableauCommandes.SelectedRows[0];
                commande = commandes.Find(c => c.reference == row.Cells[0].Value.ToString());
            }
            else
            {
                if (tableauCommandes.SelectedCells.Count != 0 && tableauCommandes.SelectedCells[0].OwningRow.Cells[0].Value != null)
                {
                    row = tableauCommandes.SelectedCells[0].OwningRow;
                    commande = commandes.Find(c => c.reference == row.Cells[0].Value.ToString());
                }
                else
                {
                    commande = null;
                    row = null;
                    
                }
            }
            if(commande != null && row != null)
            {
                commande.PTC = DB.GetAllWithChildren<ProduitToCommande>().FindAll(ptc => ptc.id_commande == commande.id_commande);

                GestionDeLaCommande gc = new GestionDeLaCommande(DB, commande);
                if (gc.ShowDialog() == DialogResult.OK)
                {
                    decimal totalTTC;
                    switch (gc.commande.etat)
                    {
                        case Commande.EnumEtatCmd.Commande:
                            tableauCommandes.Rows.Remove(row);
                            totalTTC = 0;
                            foreach (ProduitToCommande pTc in gc.commande.PTC)
                            {
                                totalTTC += pTc.produit.prix_achat_TTC * pTc.quantite;
                            }
                            object[] newRow1 = { gc.commande.reference, gc.commande.dateCommande, gc.commande.fournisseur, gc.commande.etat, totalTTC };
                            tableauCommandes.Rows.Add(newRow1);
                            break;

                        case Commande.EnumEtatCmd.Livre:
                            tableauCommandes.Rows.Remove(row);
                            totalTTC = 0;
                            foreach (ProduitToCommande pTc in gc.commande.PTC)
                            {
                                totalTTC += pTc.produit.prix_achat_TTC * pTc.quantite;
                            }
                            object[] newRow2 = { gc.commande.reference, gc.commande.dateCommande, gc.commande.fournisseur, gc.commande.etat, totalTTC };
                            tableauCommandes.Rows.Add(newRow2);
                            transferToStock(commande);
                            break;

                        case Commande.EnumEtatCmd.Receptionne:
                            tableauCommandes.Rows.Remove(row);
                            totalTTC = 0;
                            foreach (ProduitToCommande pTc in gc.commande.PTC)
                            {
                                totalTTC += pTc.produit.prix_achat_TTC * pTc.quantite;
                            }
                            object[] newRow3 = { gc.commande.reference, gc.commande.dateCommande, gc.commande.fournisseur, gc.commande.etat, totalTTC };
                            tableauCommandes.Rows.Add(newRow3);
                            transferToStock(commande);
                            break;
                    }
                }
                else if (gc.DialogResult == DialogResult.No)
                {
                    foreach (ProduitToCommande ptc in commande.PTC)
                    {
                        DB.Delete(ptc);
                    }
                    DB.Delete(commande);
                    tableauCommandes.Rows.Remove(row);
                }
            }
        }

        private void transferToStock(Commande commande)
        {
            List<ProduitEnStock> allPes = DB.GetAllWithChildren<ProduitEnStock>();//.FindAll(pes => pes.id_magasin == commande.id_magasin);
            List<Produit> stock = new List<Produit>();
            foreach (ProduitEnStock pes in allPes)
            {
                stock.Add(pes.produit);
            }

            foreach (ProduitToCommande ptc in commande.PTC)
            {
                Produit produit = DB.GetWithChildren<Produit>(ptc.id_produit);

                if (stock.Contains(produit, new ProduitComparer()))
                {
                    ProduitEnStock pes = allPes.Find(pes => pes.id_produit == produit.id_produit);
                    switch (commande.etat)
                    {
                        case Commande.EnumEtatCmd.Livre:
                            if(pes.produit.etat == EtatEnum.Rupture)
                            {
                                produit.etat = EtatEnum.AttenteLivraison;
                                DB.UpdateWithChildren(produit);
                                pes.quantite += ptc.quantite;
                                DB.UpdateWithChildren(pes);
                            }
                            else if(pes.produit.etat == EtatEnum.AttenteLivraison)
                            {
                                pes.quantite += ptc.quantite;
                                DB.UpdateWithChildren(pes);
                            }
                            break;

                        case Commande.EnumEtatCmd.Receptionne:
                            if (pes.produit.etat == EtatEnum.EnStock)
                            {
                                pes.quantite += ptc.quantite;
                                DB.UpdateWithChildren(pes);
                            }

                            else if(pes.produit.etat == EtatEnum.AttenteLivraison)
                            {
                                produit.etat = EtatEnum.EnStock;
                                DB.UpdateWithChildren(produit);
                            }
                            else
                            {
                                produit.etat = EtatEnum.EnStock;
                                DB.UpdateWithChildren(produit);
                                pes.quantite += ptc.quantite;
                                DB.UpdateWithChildren(pes);
                            }
                            break;
                    }
                }
                else
                {
                    if(commande.etat == Commande.EnumEtatCmd.Livre)
                    {
                        produit.etat = EtatEnum.AttenteLivraison;
                        DB.UpdateWithChildren(produit);

                        ProduitEnStock pes = new ProduitEnStock() { magasin = commande.magasin, produit = produit, quantite = ptc.quantite };
                        DB.InsertWithChildren(pes);
                    }
                    else
                    {
                        produit.etat = EtatEnum.EnStock;
                        DB.UpdateWithChildren(produit);

                        ProduitEnStock pes = new ProduitEnStock() { magasin = commande.magasin, produit = produit, quantite = ptc.quantite };
                        DB.InsertWithChildren(pes);
                    }
                }
            }
            tableauStock.Rows.Clear();
            initTableauAndFieldsStock();
        }

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

        private void buttonSuppCmd_Click(object sender, EventArgs e)
        {
            List<Commande> commandes = DB.GetAllWithChildren<Commande>();
            Commande commande;
            DataGridViewRow row;
            if (tableauCommandes.SelectedRows.Count != 0)
            {
                row = tableauCommandes.SelectedRows[0];
                commande = commandes.Find(c => c.reference == row.Cells[0].Value.ToString());
            }
            else
            {
                if(tableauCommandes.SelectedCells.Count != 0 && tableauCommandes.SelectedCells[0].OwningRow.Cells[0].Value != null)
                {
                    row = tableauCommandes.SelectedCells[0].OwningRow;
                    commande = commandes.Find(c => c.reference == row.Cells[0].Value.ToString());
                }
                else
                {
                    commande = null;
                    row = null;
                }
            }

            if(commande != null)
            {
                ConfirmationSupressionCommande csc = new ConfirmationSupressionCommande();
                if (csc.ShowDialog() == DialogResult.OK)
                {
                    foreach (ProduitToCommande ptc in commande.PTC)
                    {
                        if(ptc.commande.etat == Commande.EnumEtatCmd.Livre)
                        {
                            Produit produit = DB.Get<Produit>(ptc.id_produit);
                            ProduitEnStock pes = DB.GetAllWithChildren<ProduitEnStock>().Find(pes => pes.produit.nom == produit.nom);
                            DB.Delete(pes);
                            tableauStock.Rows.Clear();
                            initTableauAndFieldsStock();
                        }
                        DB.Delete(ptc);
                    }
                    DB.Delete(commande);
                    tableauCommandes.Rows.Remove(row);
                }
            }
        }

        private void buttonAjouterStk_Click(object sender, EventArgs e)
        {
            List<ProduitEnStock> allPes = DB.GetAllWithChildren<ProduitEnStock>();
            List<Produit> produits = new List<Produit>();
            foreach(ProduitEnStock pes in allPes)
            {
                produits.Add(pes.produit);
            }

            ChoixProd_AND_FourniStock newprod = new ChoixProd_AND_FourniStock(DB, magasin);
            if(newprod.ShowDialog() == DialogResult.OK)
            {
                if(produits.Contains(newprod.pes.produit, new ProduitComparer()))
                {
                    ProduitEnStock newPes = allPes.Find(pes => pes.produit.nom == newprod.pes.produit.nom);
                    newPes.quantite += newprod.pes.quantite;
                    DB.UpdateWithChildren(newPes);
                }
                else
                {
                    ProduitEnStock newPes = newprod.pes;
                    Produit p = DB.GetWithChildren<Produit>(newPes.produit.id_produit);
                    p.etat = EtatEnum.EnStock;
                    DB.UpdateWithChildren(p);
                    DB.InsertOrReplaceWithChildren(newPes);
                }
                tableauStock.Rows.Clear();
                initTableauAndFieldsStock();
            }
        }

        private void buttonSupprimerStk_Click(object sender, EventArgs e)
        {
            List<ProduitEnStock> allPes = DB.GetAllWithChildren<ProduitEnStock>();
            ProduitEnStock pes;
            DataGridViewRow row;
            if (tableauStock.SelectedRows.Count != 0)
            {
                row = tableauStock.SelectedRows[0];
                pes = allPes.Find(pes => pes.id_produit.ToString() == row.Cells[0].Value.ToString());
            }
            else
            {
                if(tableauStock.SelectedCells.Count != 0 && tableauStock.SelectedCells[0].OwningRow.Cells[0].Value != null)
                {
                    row = tableauStock.SelectedCells[0].OwningRow;
                    pes = allPes.Find(pes => pes.id_produit.ToString() == row.Cells[0].Value.ToString());
                }
                else
                {
                    pes = null;
                }
            }

            if(pes != null)
            {
                SupprimerStock ss = new SupprimerStock(pes, DB);
                if (ss.ShowDialog() == DialogResult.OK)
                {
                    tableauStock.Rows.Clear();
                    initTableauAndFieldsStock();
                }
            }
            
        }
    }

}

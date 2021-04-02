using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using System.IO;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;
using ZumbaSoft.Fenetres_Commande;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Diagnostics;

namespace ZumbaSoft.Fenetres_Stock
{
    public partial class AccueilStock : Form
    {
        Magasin magasin;
        Utilisateur user;
        SQLiteConnection DB;

        public AccueilStock(SQLiteConnection db, Magasin mag, Utilisateur uConnected)
        {
            InitializeComponent();
            DB = db;
            user = uConnected;
            magasin = mag;
            labelDate.Text = DateTime.Today.ToString("d");
            //labelMagasin.Text = magasin.ToString();

            initTableauAndFieldsStock();
            initTableauCommandes();
            initItemsColors();
            checkDB();
            checkMagasinAndUser();
        }
        /// <summary>
        /// Fill the grid of all product in stock using the DataBase.
        /// </summary>
        public void initTableauAndFieldsStock()
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

        public void checkDB()
        {
            var database = new FileInfo("../../../DataBase.db");
            if (!database.Exists)
            {
                msgBDstatusERROR.Visible = true;
                msgBDstatusOK.Visible = false;

                dbERROR.Visible = true;
                dbOK.Visible = false;

                var t = new Timer();
                t.Interval = 2000; // Durée de l'attente avant l'affichage du message
                t.Tick += (s, e) =>
                {
                    panelERROR.Visible = true;
                    t.Stop();
                };
                t.Start();

                var t2 = new Timer();
                t2.Interval = 8000; // Durée de l'affichage du message
                t2.Tick += (s, e) =>
                {
                    panelERROR.Visible = false;
                    t2.Stop();
                };
                t2.Start();

            }
            else
            {
                msgBDstatusERROR.Visible = false;
                msgBDstatusOK.Visible = true;

                dbERROR.Visible = false;
                dbOK.Visible = true;
            }
        }

        public void checkMagasinAndUser()
        {
            if (magasin != null)
            {
                magasinSelectionne.Text = Convert.ToString(magasin);
            }

            if (user != null)
            {
                userSelectionne.Text = Convert.ToString(user);
                anonymousIcon.Visible = false;
                userIcon.Visible = true;
            }
            else
            {
                anonymousIcon.Visible = true;
                userIcon.Visible = false;
            }
        }

        /// <summary>
        /// Set all tranpasrent elements effects.
        /// </summary>
        public void initItemsColors()
        {
            
            panel4.BackColor = Color.FromArgb(80, 12, 12, 12);
            panel5.BackColor = Color.FromArgb(80, 12, 12, 12);

            panel1.BackColor = Color.FromArgb(80, 12, 12, 12);
            panel2.BackColor = Color.FromArgb(80, 12, 12, 12);


            buttonAjouterStk.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonModifierCmd.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonNouvelleCmd.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonSupprimerStk.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonSuppStock.BackColor = Color.FromArgb(80, 12, 12, 12);

            


        }

        /// <summary>
        /// Fill the grid of all command using the DataBase.
        /// </summary>
        public void initTableauCommandes()
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

        public void transferToStock(Commande commande)
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

        private void goBackButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonContactAdmin_Click(object sender, EventArgs e)
        {
            Process OpenMailClient = new Process();
            DateTime date = DateTime.Now;
            String emailAddress = "mrkafeine@gmail.com";
            String subject = "Rapport d'erreur - BD introuvable";
            String body = "---------------------------------%0a%0aRapport d'erreur  OUATELSE : le " + date.ToString("MM/dd/yyyy") + " à " + date.ToString("HH:mm") + " : ERREUR 01 - Impossible d'accéder à la base de données : le fichier correspondant à la base de données (Database.db) est introuvable.%0a%0aRépondez directement à ce mail pour échanger avec le magasin concerné.%0a%0a---------------------------------%0a%0aEntrez des détails ici (que s'est-il passé avant l'apparition de ce problème, d'éventuelles remarques...) :";

            string filename = "mailto:" + emailAddress + "?subject=" + subject + "&body=" + body;
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = filename;
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.RedirectStandardOutput = false;
            myProcess.Start();
        }

        private void buttonBackHome_Click(object sender, EventArgs e)
        {
            panelERROR.Visible = false;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void msgBDstatusERROR_Click(object sender, EventArgs e)
        {
            if (!panelERROR.Visible)
            {
                panelERROR.Visible = true;
                var t = new Timer();
                t.Interval = 8000; // Durée de l'affichage du message
                t.Tick += (s, e) =>
                {
                    panelERROR.Visible = false;
                    t.Stop();
                };
                t.Start();
            }
        }

        private void AccueilStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            panelERROR.Visible = false;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}

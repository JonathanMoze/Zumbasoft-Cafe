using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using ZumbaSoft.Model;
using System.Linq;

namespace ZumbaSoft.Fenetres_Commande
{
    public partial class GestionDeLaCommande : Form
    {
        SQLiteConnection DB;
        public Commande commande;

        /// <summary>
        /// Create the window to manage a command if it doesn't already exist.
        /// </summary>
        /// <param name="db">DATA BASE</param>
        /// <param name="magasin">The market where the command is order</param>
        public GestionDeLaCommande(SQLiteConnection db, Magasin magasin)
        {
            InitializeComponent();
            DB = db;
            initButtons();
            commande = new Commande();
            commande.PTC = new List<ProduitToCommande>();
            commande.magasin = magasin;
            commande.reference = newReference();
            commande.dateCommande = DateTime.Today;
            textBoxCmdLe.Text = DateTime.Today.ToString("d");
        }

        private void initButtons()
        {
            int size = (flowLayoutPanelButtons.Width / 4) - 3 * 4; 
            buttonAnnuler.Width = size;
            buttonAjouterProd.Width = size;
            buttonAnnulerCmd.Width = size;
            buttonEnregisterCmd.Width = size;
        }

        /// <summary>
        /// Create a new refrence for a command without verifing if it already asigned to a previous command.
        /// </summary>
        /// <returns>a non unique reference</returns>
        public string createReference()
        {
            string reference = "";
            Random random = new Random();
            string charactères = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int max = charactères.Length;
            for (int i = 0; i < 9; i++)
            {
                reference += charactères[random.Next()%max];
            }
            return reference;
        }

        /// <summary>
        /// Verify if the reference created by createReference already exist.
        /// </summary>
        /// <returns>a unique reference for a command</returns>
        public string newReference()
        {
            bool valideRef = false;
            string reference = "";
            List<Commande> oldCmd = DB.GetAllWithChildren<Commande>();
            List<string> oldRef = new List<string>();
            foreach(Commande cmd in oldCmd)
            {
                oldRef.Add(cmd.reference);
            }
            while (!valideRef)
            {
                reference = createReference();
                if (!oldRef.Contains(reference))
                {
                    valideRef = true;
                }
            }
            textBoxRef.Text = reference;
            return reference;
        }

        /// <summary>
        /// Create the window to manage a command if it already exist.
        /// </summary>
        /// <param name="db">DATA BASE</param>
        /// <param name="cmd">The command that the user want to manage/modify</param>
        public GestionDeLaCommande(SQLiteConnection db, Commande cmd)
        {
            InitializeComponent();
            DB = db;
            commande = cmd;
            chekTheRightBox();
            initFieldCommande();
        }

        public void chekTheRightBox()
        {
            switch (commande.etat)
            {
                case Commande.EnumEtatCmd.Commande:
                    checkBoxCommande.Checked = true;
                    break;
                case Commande.EnumEtatCmd.Livre:
                    checkBoxLivre.Checked = true;
                    break;
                case Commande.EnumEtatCmd.Receptionne:
                    checkBoxRecept.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Only use if the command already exist, it fill out the grid off products.
        /// </summary>
        private void initFieldCommande()
        {
            textBoxRef.Text = commande.reference;
            textBoxFournisseur.Text = commande.fournisseur.ToString();
            textBoxCmdLe.Text = commande.dateCommande.ToString("d");

            buttonEnregisterCmd.Enabled = true;
            enabledMoreLessDeleteButton();

            float totalTTC = 0;
            foreach(ProduitToCommande assos in commande.PTC)
            {
                Produit prod = DB.Get<Produit>(assos.id_produit);
                int q = assos.quantite;
                totalTTC += q * prod.prix_achat_TTC;
                object[] row = { prod.reference, prod.nom, q, prod.prix_achat_TTC, q * prod.prix_achat_TTC };
                tableauProd.Rows.Add(row);
            }
            textBoxTotalTTC.Text = totalTTC.ToString() + " €";

            if(commande.etat == Commande.EnumEtatCmd.Receptionne)
            {
                buttonAnnuler.Text = "Retour";
                buttonEnregisterCmd.Enabled = false;
                checkBoxCommande.Enabled = false;
                checkBoxLivre.Enabled = false;
                checkBoxRecept.Enabled = false;
                buttonAnnulerCmd.Enabled = false;
                buttonSupprimerPrd.Enabled = false;
                buttonPlusPrd.Enabled = false;
                buttonAjouterProd.Enabled = false;
                buttonMoinsPrd.Enabled = false;
            }
            else
            {
                checkBoxCommande.Enabled = true;
                checkBoxLivre.Enabled = true;
                checkBoxRecept.Enabled = true;
            }
        }

        /// <summary>
        /// Permet d'ajouter un produit à la commande, et le fournisseur si il n'est pas encore défini. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouterProd_Click(object sender, System.EventArgs e)
        {
            if(commande.fournisseur == null)
            {
                ChoixProd_AND_FourniCmd choixProd_AND_Fourni = new ChoixProd_AND_FourniCmd(DB);
                if (choixProd_AND_Fourni.ShowDialog() == DialogResult.OK)
                {
                    ProduitToCommande newProd = choixProd_AND_Fourni.pTc;
                    newProd.commande = commande;
                    DB.InsertWithChildren(newProd);
                    commande.PTC.Add(newProd);

                    commande.fournisseur = choixProd_AND_Fourni.fournisseur;
                    textBoxFournisseur.Text = choixProd_AND_Fourni.fournisseur.nom;

                    addNewRow(newProd.produit, newProd.quantite);
                    enabledMoreLessDeleteButton();
                    buttonEnregisterCmd.Enabled = true;

                    updateTotalTTC();
                }
            }
            else
            {
                List<Produit> currentProduct = new List<Produit>();
                foreach(ProduitToCommande ptc in commande.PTC)
                {
                    currentProduct.Add(ptc.produit);
                }
                List<Produit> otherProduct = DB.GetWithChildren<Fournisseur>(commande.fournisseur.id_fournisseur).produits.FindAll(p => !currentProduct.Contains(p,new ProduitComparer()));

                ChoixProd_BY_FourniCmd choixProd_BY_Fourni = new ChoixProd_BY_FourniCmd(DB, commande.fournisseur, otherProduct);
                if(choixProd_BY_Fourni.ShowDialog()== DialogResult.OK)
                {
                    ProduitToCommande newProd = choixProd_BY_Fourni.pTc;
                    newProd.commande = commande;
                    DB.InsertWithChildren(newProd);
                    commande.PTC.Add(newProd);

                    addNewRow(newProd.produit, newProd.quantite);
                    buttonEnregisterCmd.Enabled = true;

                    updateTotalTTC();
                }
            }
        }

        /// <summary>
        /// MAJ du total de la commande
        /// </summary>
        private void updateTotalTTC()
        {
            float total = 0F;
            DataGridViewRowCollection dataGridView = tableauProd.Rows;
            foreach(DataGridViewRow row in dataGridView)
            {
                total += (float)row.Cells[4].Value;
            }
            textBoxTotalTTC.Text = total.ToString() + " €";
        }

        /// <summary>
        /// Enabled the buttons to add or delete quantite off one selected product.
        /// </summary>
        private void enabledMoreLessDeleteButton()
        {
            buttonPlusPrd.Enabled = true;
            buttonSupprimerPrd.Enabled = true;
            buttonMoinsPrd.Enabled = true;
        }

        private void addNewRow(Produit prod, int quantite)
        {
            object[] row = { prod.reference, prod.nom, quantite, prod.prix_achat_TTC, quantite * prod.prix_achat_TTC };
            tableauProd.Rows.Add(row);
        }

        private void buttonEnregisterCmd_Click(object sender, EventArgs e)
        {
            DB.InsertOrReplaceWithChildren(commande);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonAnnulerCmd_Click(object sender, EventArgs e)
        {
            ConfirmationAnnulationCmd cac = new ConfirmationAnnulationCmd();
            if(cac.ShowDialog() == DialogResult.OK)
            {
                foreach(ProduitToCommande ptc in commande.PTC)
                {
                    DB.Delete(ptc);
                }
                DB.Delete(commande);
                DialogResult = DialogResult.No;
                this.Close();
            }
            
        }

        private void buttonMoinsPrd_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRowCollection = tableauProd.SelectedRows;
            foreach(DataGridViewRow dataGridView in selectedRowCollection)
            {
                ProduitToCommande prod = commande.PTC.Find(ptc => ptc.produit.nom == dataGridView.Cells[1].Value.ToString());
                int newquantite = prod.quantite - 1;
                if (newquantite > 0)
                {
                    commande.PTC.Remove(prod);
                    tableauProd.Rows[dataGridView.Index].Cells[2].Value = newquantite;
                    tableauProd.Rows[dataGridView.Index].Cells[4].Value = newquantite * prod.produit.prix_achat_TTC;
                    prod.quantite = newquantite;
                    DB.UpdateWithChildren(prod);
                    commande.PTC.Add(prod);
                }
                else
                {
                    tableauProd.Rows.Remove(dataGridView);
                    commande.PTC.Remove(prod);
                    DB.Delete(prod);
                }

            }
            if (commande.PTC.Count == 0)
            {
                buttonEnregisterCmd.Enabled = false;
                textBoxTotalTTC.Text = "O.OO €";
            }
            else
            {
                updateTotalTTC();
            }
            tableauProd.Refresh();
        }

        private void buttonPlusPrd_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRowCollection = tableauProd.SelectedRows;
            foreach(DataGridViewRow dataGridView in selectedRowCollection)
            {
                ProduitToCommande prod = commande.PTC.Find(ptc => ptc.produit.nom == dataGridView.Cells[1].Value.ToString());
                commande.PTC.Remove(prod);
                int newquantite = prod.quantite +1;
                tableauProd.Rows[dataGridView.Index].Cells[2].Value = newquantite;
                tableauProd.Rows[dataGridView.Index].Cells[4].Value = newquantite * prod.produit.prix_achat_TTC;
                prod.quantite = newquantite;
                DB.UpdateWithChildren(prod);
                commande.PTC.Add(prod);
            }
            updateTotalTTC();
            tableauProd.Refresh();
        }

        private void buttonSupprimerPrd_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRowCollection = tableauProd.SelectedRows;
            foreach(DataGridViewRow dataGridView in selectedRowCollection) {
                tableauProd.Rows.Remove(dataGridView);
                ProduitToCommande prod = commande.PTC.Find(ptc => ptc.produit.nom == dataGridView.Cells[1].Value.ToString());
                commande.PTC.Remove(prod);
                DB.Delete(prod);
            }
            if (commande.PTC.Count == 0)
            {
                buttonEnregisterCmd.Enabled = false;
            }
            tableauProd.Refresh();
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

        private void checkBoxCommande_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCommande.CheckState == CheckState.Checked)
            {
                checkBoxLivre.Checked = false;
                checkBoxRecept.Checked = false;
                commande.etat = Commande.EnumEtatCmd.Commande;
            } 
        }

        private void checkBoxLivre_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxLivre.CheckState == CheckState.Checked)
            {
                checkBoxCommande.Checked = false;
                checkBoxRecept.Checked = false;
                commande.etat = Commande.EnumEtatCmd.Livre;
            }
        }

        private void checkBoxRecept_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxRecept.CheckState == CheckState.Checked)
            {
                checkBoxCommande.Checked = false;
                checkBoxLivre.Checked = false;
                commande.etat = Commande.EnumEtatCmd.Receptionne;
                textBoxRecep.Text = DateTime.Today.ToString("d");
                textBoxRegl.Enabled = true;
            }
            else
            {
                textBoxRecep.Text = "";
                textBoxRegl.Enabled = false;
            }
            
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

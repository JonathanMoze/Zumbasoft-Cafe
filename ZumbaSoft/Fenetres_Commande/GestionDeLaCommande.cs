using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZumbaSoft.Model;

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
            initializeGrid();
            commande = new Commande();
            commande.PTC = new List<ProduitToCommande>();
            commande.magasin = magasin;
            commande.reference = newReference();
            commande.dateCommande = DateTime.Today;
            textBoxCmdLe.Text = DateTime.Today.ToString();
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
            List<Commande> oldCmd = DB.Table<Commande>().ToList();
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
            initializeGrid();
            initFieldCommande();
        }

        /// <summary>
        /// Only use if the command already exist, it fill out the grid off products.
        /// </summary>
        private void initFieldCommande()
        {
            foreach(ProduitToCommande assos in commande.PTC)
            {
                Produit prod = assos.produit;
                int q = assos.quantite;
                object[] row = { prod.reference, prod.nom, q, prod.prix_achat_TTC, q * prod.prix_achat_TTC };
                tableauProd.Rows.Add(row);
            }
        }

        /// <summary>
        /// Init the grid off products, naming each colums.
        /// </summary>
        private void initializeGrid()
        {
            tableauProd.ColumnCount = 5;
            tableauProd.Columns[0].Name = "Ref. Produit";
            tableauProd.Columns[1].Name = "Nom Produit";
            tableauProd.Columns[2].Name = "Quantité";
            tableauProd.Columns[3].Name = "Prix unitaire TTC";
            tableauProd.Columns[4].Name = "Prix totale TTC";
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
                ChoixProd_AND_Fourni choixProd_AND_Fourni = new ChoixProd_AND_Fourni(DB);
                if (choixProd_AND_Fourni.ShowDialog() == DialogResult.OK)
                {
                    ProduitToCommande newProd = choixProd_AND_Fourni.pTc;
                    newProd.commande = commande;
                    commande.PTC.Add(newProd);

                    commande.fournisseur = choixProd_AND_Fourni.fournisseur;
                    textBoxFournisseur.Text = choixProd_AND_Fourni.fournisseur.nom;

                    updateGrid(newProd.produit, newProd.quantite);
                    enabledMoreLessDeleteButton();
                    buttonEnregisterCmd.Enabled = true;

                    updateTotalTTC();
                }
            }
            else
            {
                ChoixProd_BY_Fourni choixProd_BY_Fourni = new ChoixProd_BY_Fourni(DB, commande.fournisseur);
                if(choixProd_BY_Fourni.ShowDialog()== DialogResult.OK)
                {
                    ProduitToCommande newProd = choixProd_BY_Fourni.pTc;
                    newProd.commande = commande;
                    commande.PTC.Add(newProd);

                    updateGrid(newProd.produit, newProd.quantite);
                    buttonEnregisterCmd.Enabled = true;

                    updateTotalTTC();
                }
            }
        }

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

        private void updateGrid(Produit prod, int quantite)
        {
            object[] row = { prod.reference, prod.nom, quantite, prod.prix_achat_TTC, quantite * prod.prix_achat_TTC };
            tableauProd.Rows.Add(row);
        }

        private void buttonEnregisterCmd_Click(object sender, EventArgs e)
        {
            DB.InsertOrReplaceAllWithChildren(commande.PTC);
            DB.InsertOrReplaceWithChildren(commande);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonAnnulerCmd_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
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
                    commande.PTC.Add(prod);
                }
                else
                {
                    tableauProd.Rows.Remove(dataGridView);
                    commande.PTC.Remove(prod);
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
            }
            if (commande.PTC.Count == 0)
            {
                buttonEnregisterCmd.Enabled = false;
            }
            tableauProd.Refresh();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;
using SQLite;

namespace ZumbaSoft.Fenetres_Produit
{
    public partial class ModifierFournisseur : Form
    {
        Fournisseur fournisseur;
        SQLiteConnection DB;
        AccueilFournisseur af;

        /// <summary>
        /// Constructeur du panel de modification d'un fournisseur.
        /// </summary>
        /// <param name="af">La fenêtre d'accueil de gestion des fournisseurs à partir de laquelle ce formulaire a été appelé.</param>
        /// <param name="f">Le fournisseur à modifier.</param>
        /// <param name="db">La connection actuelle à la base de données.</param>
        public ModifierFournisseur(AccueilFournisseur af, Fournisseur f, SQLiteConnection db)
        {
            InitializeComponent();
            this.fournisseur = f;
            this.DB = db;
            this.af = af;
            InitInfoField();
        }

        /// <summary>
        /// Méthode pour pré-remplir les champs avec les valeurs actuelles du fournisseur.
        /// </summary>
        public void InitInfoField()
        {
            textBoxNom.PlaceholderText = fournisseur.nom;
            textBoxNewTel.PlaceholderText = fournisseur.telephone;
            textBoxEmail.PlaceholderText = fournisseur.mail;
            textBoxContrat.PlaceholderText = fournisseur.etat_contrat;

            

            if (fournisseur.produits.Count != 0)
            {
                foreach (Produit p in fournisseur.produits)
                {
                    listViewProduits.Items.Add(p.ToString());
                }
            }
            else { 
                listViewProduits.Items.Add("Aucun");
            }

            if (fournisseur.commandes.Count != 0)
            {
                foreach (Commande c in fournisseur.commandes)
                {
                    listViewCommandes.Items.Add(c.ToString());
                }
            }
            else {
                listViewCommandes.Items.Add("Aucun");
            }
        }

        /// <summary>
        /// Méthode pour valider les modifications du fournisseur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOKParamMag_Click(object sender, EventArgs e)
        {
            fournisseur.telephone = textBoxNewTel.PlaceholderText;
            fournisseur.nom = textBoxNom.PlaceholderText;
            fournisseur.etat_contrat = textBoxContrat.PlaceholderText;
            fournisseur.mail = textBoxEmail.PlaceholderText;
            DB.Update(fournisseur);
            af.initListFournisseur();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Méthode pour annuler toute la procédure de modification d'un fournisseur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnulParamMag_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Méthode pour enregistrer les modifications d'un fournisseur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifs_Click(object sender, EventArgs e)
        {
            if(textBoxNom.Text != "")
            {
                textBoxNom.PlaceholderText = textBoxNom.Text;
                textBoxNom.Text = "";
            }

            if (textBoxNewTel.Text != "")
            {
                textBoxNewTel.PlaceholderText = textBoxNewTel.Text;
                textBoxNewTel.Text = "";
            }

            if (textBoxEmail.Text != "")
            {
                textBoxEmail.PlaceholderText = textBoxEmail.Text;
                textBoxEmail.Text = "";
            }

            if (textBoxContrat.Text != "")
            {
                textBoxContrat.PlaceholderText = textBoxContrat.Text;
                textBoxContrat.Text = "";
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Produit
{
    public partial class AjouterProduit: Form, FormProduit
    {
        SQLiteConnection DB;
        public Produit produit;

        /// <summary>
        /// Constructeur d'un formulaire d'ajout de produit.
        /// </summary>
        /// <param name="db">La connection actuelle à la base de données.</param>
        public AjouterProduit(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initComboBoxes();
            initItemsColors();
        }

        /// <summary>
        /// Méthode d'initialisation de l'accession des enfants des objets.
        /// </summary>
        public void initComboBoxes()
        {
            comboBoxFournisseur.Items.Clear();
            comboBoxGenre.Items.Clear();

            foreach(Fournisseur f in DB.GetAllWithChildren<Fournisseur>())
            {
                comboBoxFournisseur.Items.Add(f);
            }

            foreach(Genre g in DB.GetAllWithChildren<Genre>())
            {
                comboBoxGenre.Items.Add(g);
            }

        }

        /// <summary>
        /// Méthode pour initialiser un nouveau produit correctement.
        /// </summary>
        /// <returns>Le produit initialisé via cette méthode.</returns>
        public Produit initObjetProduit(){
            produit = new Produit();
            produit.nom = textBoxNom.Text;
            produit.reference = textBoxRef.Text;
            int i;
            if (Int32.TryParse(textBoxCodeB.Text, out i))
            {
                produit.code_barre = Int32.Parse(textBoxCodeB.Text);
            }
            else
            {
                produit.code_barre = 0000;
            }


            produit.prix_achat_HT = numericUpDownAHT.Value;
            produit.prix_achat_TTC = numericUpDownATTC.Value;
            produit.prix_vente_HT = numericUpDownVHT.Value;
            produit.prix_vente_TTC = numericUpDownVTTC.Value;


            produit.type = textBoxType.Text;
            produit.marque = textBoxMarque.Text;
            produit.couleur = textBoxCouleur.Text;
            produit.etat = EtatEnum.Rupture;
            produit.genre = (Genre)comboBoxGenre.SelectedItem;
            produit.fournisseur = (Fournisseur)comboBoxFournisseur.SelectedItem;

            return produit;
            

        }

        /// <summary>
        /// Méthode pour initialiser les couleurs du formulaire.
        /// Cette méthode n'est destinée à être appelée qu'une seule fois.
        /// </summary>
        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(50, 12, 12, 12);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            backgroundBlock3.BackColor = Color.FromArgb(30, 12, 12, 12);
            backgroundBlock4.BackColor = Color.FromArgb(30, 12, 12, 12);
            backgroundBlock5.BackColor = Color.FromArgb(30, 12, 12, 12);
            
            buttonOK.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonCancel.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonGenre.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonFournisseurs.BackColor = Color.FromArgb(50, 12, 12, 12);
        }

        /// <summary>
        /// Méthode pour gérer le clic sur le bouton d'accès aux genres.
        /// Attention, celle-ci déploie le formulaire correspondant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGenre_Click(object sender, EventArgs e)
        {
            AccueilGenre accGenre = new AccueilGenre(DB, this);
            accGenre.Show();
            initComboBoxes();
        }

        /// <summary>
        /// Méthode pour accéder à la gestion des fournisseurs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFournisseurs_Click(object sender, EventArgs e)
        {
            AccueilFournisseur accFourni = new AccueilFournisseur(DB, this);
            accFourni.Show();
            initComboBoxes();
        }

        /// <summary>
        /// Méthode pour insérer un nouveau produit dans la BD.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            produit = initObjetProduit();
            DB.InsertWithChildren(produit);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Méthode pour annuler la procédure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

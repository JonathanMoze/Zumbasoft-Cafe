using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using SQLiteNetExtensions;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;
using ZumbaSoft.Fenetres_Magasin;

namespace ZumbaSoft.Fenetres_Produit
{
    
    public partial class AjouterFournisseur : Form
    {
        private SQLiteConnection DB;
        public Adresse adresse;
        public Fournisseur fournisseur;

        /// <summary>
        /// Constructeur du formulaire.
        /// </summary>
        /// <param name="db">La connection actuelle à la BD.</param>
        public AjouterFournisseur(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initItemsColors();
        }

        /// <summary>
        /// Méthode pour initialiser les objets de type Fournisseur en RAM.
        /// </summary>
        /// <returns>Le fournisseur instancié.</returns>
        public Fournisseur initObjectFournisseur()
        {
            fournisseur = new Fournisseur();
            fournisseur.nom = textBoxNom.Text;
            fournisseur.mail = textBoxMailFourni.Text;
            fournisseur.etat_contrat = textBoxEtatFourni.Text;
            fournisseur.telephone = textBoxTelFourni.Text;
            fournisseur.adresse = adresse;
            fournisseur.commandes = new List<Commande>();
            fournisseur.produits = new List<Produit>();
            return fournisseur;
        }

        /// <summary>
        /// Méthode d'initialisation des couleurs du formulaire.
        /// Cette méthode n'est destinée à être appelée qu'une seule fois.
        /// </summary>
        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(50, 12, 12, 12);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonAdr.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonOK.BackColor = Color.FromArgb(50, 12, 12, 12);
        }

        /// <summary>
        /// Méthode pour vérifier si le champ "addresse" est bien rempli.
        /// En cas de problèmes avec le champ, un message d'erreur est affiché.
        /// </summary>
        /// <returns>True si le champ est correctement rempli, false sinon.</returns>
        public bool fieldsIsValid()
        {
            if (textBoxAdr.Text == "")
            {
                labelErreurAdr.Visible = true;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Méthode pour créer une nouvelle addresse.
        /// Elle est utilisée dans le formulaire pour créer une nouvelle addresse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdr_Click(object sender, EventArgs e)
        {
            NouvelleAdresse newAdr = new NouvelleAdresse(DB);
            if (newAdr.ShowDialog() == DialogResult.OK)
            {
                adresse = newAdr.adr;
                textBoxAdr.Text = newAdr.adr.adresse;
            }
        }

        /// <summary>
        /// Méthode pour gérer le chhangement d'adresse dans le champ adresse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAdr_TextChanged(object sender, EventArgs e)
        {
            if (labelErreurAdr.Visible == true)
            {
                labelErreurAdr.Visible = false;
            }
        }

        /// <summary>
        /// Méthode pour confirmer le formulaire.
        /// Elle procède cependant à une vérification des données en paramètre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (fieldsIsValid())
            {
                fournisseur = initObjectFournisseur();
                DB.InsertWithChildren(fournisseur);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// Méthode pour annuler tout le formulaire et revenir au formulaire précédent.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}

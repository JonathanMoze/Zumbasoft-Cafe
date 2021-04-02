using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using ZumbaSoft.Model;
using SQLiteNetExtensions;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Produit
{
    public partial class AccueilFournisseur : Form
    {
        SQLiteConnection DB;
        FormProduit formPrecedent;

        /// <summary>
        /// Constructeur de l'accueil de l'écran de gestion des fournisseurs.
        /// </summary>
        /// <param name="db">La connection actuelle à la base de données.</param>
        /// <param name="f">Le formulaire de produits à partir duquel celui-ci est appelé.</param>
        public AccueilFournisseur(SQLiteConnection db, FormProduit f)
        {
            InitializeComponent();
            DB = db;
            formPrecedent = f;
            initListFournisseur();
            initItemsColors();
        }

        /// <summary>
        /// Méthode pour initialiser la liste des fournisseurs en RAM.
        /// </summary>
        public void initListFournisseur()
        {

            listFournisseur.Items.Clear();
            int nb = 0;
            foreach (Fournisseur f in DB.GetAllWithChildren<Fournisseur>())
            {
                listFournisseur.Items.Add(f);
                nb++;
            }

            if (nb > 0)
            {
                erreurListevide.Visible = false;
            }
            else
            {
                erreurListevide.Visible = true;
            }
        }

        /// <summary>
        /// Méthode pour initialiser les couleurs du formulaire.
        /// Elle n'est destinée à être appelée qu'une seule fois.
        /// </summary>
        public void initItemsColors()
        {
            backgroundBlock.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonAjouterGenre.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonModifierGenre.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonSupprimerGenre.BackColor = Color.FromArgb(50, 12, 12, 12);
            erreurListevide.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel5.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel4.BackColor = Color.FromArgb(80, 12, 12, 12);

        }

        /// <summary>
        /// Méthode pour supprimer un fournisseur de la base de données.
        /// Attention, elle fait appel au formulaire de confirmation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimerFournisseur_Click(object sender, EventArgs e)
        {
            var f = (Fournisseur)listFournisseur.SelectedItem;
            SupprimerFournisseur supprimer = new SupprimerFournisseur(f, DB);
            if (supprimer.ShowDialog() == DialogResult.OK)
            {
                listFournisseur.Items.Remove(f);
            }
        }

        /// <summary>
        /// Méthode pour ajouter un fournisseur à la liste des fournisseurs connus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouterFournisseur_Click(object sender, EventArgs e)
        {
            AjouterFournisseur ajoutFournisseur = new AjouterFournisseur(DB);
            if (ajoutFournisseur.ShowDialog() == DialogResult.OK)
            {
                initListFournisseur();
            }
        }

        /// <summary>
        /// Méthode pour modifier un fournisseur existant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifierFournisseur_Click(object sender, EventArgs e)
        {
            if (listFournisseur.SelectedItem != null)
            {
                Fournisseur f = (Fournisseur)listFournisseur.SelectedItem;
                ModifierFournisseur paramétrer = new ModifierFournisseur(this, f, DB);
                if (paramétrer.ShowDialog() == DialogResult.OK)
                {
                    initListFournisseur();
                }
            }
        }

        /// <summary>
        /// Méthode pour faire un retour arrière vers l'écran de gestion des fournisseurs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccueilFournisseur_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrecedent.initComboBoxes();
        }

        /// <summary>
        /// Méthode pour faire un retour en arrière en annulant toute la procédure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goBackButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}

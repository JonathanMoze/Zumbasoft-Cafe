using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;
using SQLiteNetExtensions;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Produit
{
    public partial class AccueilGenre : Form
    {
        SQLiteConnection DB;
        FormProduit formPrecedent;

        /// <summary>
        /// Constructeur d'un accueil de gestion des genres.
        /// </summary>
        /// <param name="db">La connection actuelle à la BD.</param>
        /// <param name="f">Le formulaire à partir duquel cet accueil a été appelé.</param>
        public AccueilGenre(SQLiteConnection db, FormProduit f)
        {
            InitializeComponent();
            DB = db;
            formPrecedent = f;
            initListGenre();
            initItemsColors();
        }

        /// <summary>
        /// Méthode pour initialiser la liste des genres en RAM.
        /// </summary>
        public void initListGenre()
        {
            listGenre.Items.Clear();

            int nb = 0;
            foreach (Genre g in DB.GetAllWithChildren<Genre>())
            {
                listGenre.Items.Add(g);
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
        /// </summary>
        public void initItemsColors()
        {
            backgroundBlock.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonAjouterGenre.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonModifierGenre.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonSupprimerGenre.BackColor = Color.FromArgb(50, 12, 12, 12);
            erreurListevide.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel1.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel4.BackColor = Color.FromArgb(80, 12, 12, 12);

        }

        /// <summary>
        /// Méthode pour ajouter un nouveau genre à la base de données.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouterGenre_Click(object sender, EventArgs e)
        {
            AjouterGenre ajouterGenre = new AjouterGenre(DB);
            if (ajouterGenre.ShowDialog() == DialogResult.OK)
            {
                initListGenre();
            }
        }

        /// <summary>
        /// Méthode pour modifier un genre existant dans la base de données.
        /// Attention, cela passe par une boîte de dialogue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifierGenre_Click(object sender, EventArgs e)
        {
            if (listGenre.SelectedItem != null)
            {
                Genre g = (Genre)listGenre.SelectedItem;
                ModifierGenre paramétrer = new ModifierGenre(g, DB);
                if (paramétrer.ShowDialog() == DialogResult.OK)
                {
                    initListGenre();
                }
            }
        }

        /// <summary>
        /// Méthode pour supprimer un genre de la BD.
        /// Attention, ceci demande une confirmation sous forme de boîte de dialogue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimerGenre_Click(object sender, EventArgs e)
        {
            var g = (Genre)listGenre.SelectedItem;
            SupprimerGenre supprimer = new SupprimerGenre(g, DB);
            if (supprimer.ShowDialog() == DialogResult.OK)
            {
                listGenre.Items.Remove(g);
            }
        }

        /// <summary>
        /// Méthode pour revenir au formulaire précédent après que tout soit bon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRetour_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Méthode pour annuler la procédure et revenir au formulaire précédent.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccueilGenre_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrecedent.initComboBoxes();
        }

    }
}

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
    public partial class SupprimerFournisseur : Form
    {
        Fournisseur fournisseur;
        SQLiteConnection DB;

        /// <summary>
        /// Constructeur du formulaire.
        /// </summary>
        /// <param name="f"></param>
        /// <param name="db"></param>
        public SupprimerFournisseur(Fournisseur f, SQLiteConnection db)
        {
            InitializeComponent();
            initItemsColors();
            this.fournisseur = f;
            this.DB = db;
        }

        /// <summary>
        /// Méthode d'initialisation des couleurs du formulaire.
        /// </summary>
        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(90, System.Drawing.Color.Red);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonSupprimer.BackColor = Color.FromArgb(50, 12, 12, 12);
        }

        /// <summary>
        /// Méthode pour supprimer le fournisseyr.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            DB.Delete(fournisseur);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Méthode pour annuler la procédure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

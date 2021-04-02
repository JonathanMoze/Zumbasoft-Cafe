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
    public partial class SupprimerProduit : Form
    {
        SQLiteConnection DB;
        Produit produit;

        /// <summary>
        /// Constructeur du formulaire de suppression de produit.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="db"></param>
        public SupprimerProduit(Produit p, SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            this.produit = p;
            initItemsColors();

        }

        /// <summary>
        /// Méthode pour initialiser les couleurs du formulaire.
        /// Elle n'est appelée qu'une fois.
        /// </summary>
        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(90, System.Drawing.Color.Red);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonSupprimer.BackColor = Color.FromArgb(50, 12, 12, 12);

        }

        /// <summary>
        /// Méthode pour valider la suppression d'un produit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            DB.Delete(produit);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Méthode pour annuler toute la procédure.
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

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
    public partial class AjouterGenre : Form
    {
        private SQLiteConnection DB;
        public Genre genre;

        /// <summary>
        /// Constructeur de ce formulaire.
        /// </summary>
        /// <param name="db">La connection actuelle à la base de données.</param>
        public AjouterGenre(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initItemsColors();
        }

        /// <summary>
        /// Méthode pour initialiser les objets de type Genre correctement.
        /// </summary>
        /// <returns>Le genre initialisé.</returns>
        public Genre initObjectGenre()
        {
            genre = new Genre();
            genre.intitule = textBoxNom.Text;
            return genre;
        }

        /// <summary>
        /// Méthode pour initialiser les couleurs du formulaire.
        /// Elle n'est destnée à être appelée qu'une seule fois.
        /// </summary>
        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(50, 12, 12, 12);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonOK.BackColor = Color.FromArgb(50, 12, 12, 12);
        }

        /// <summary>
        /// Méthode pour pour confirmer le formulaire et ajouter un nouveau Genre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
                genre = initObjectGenre();
                DB.InsertWithChildren(genre);
                DialogResult = DialogResult.OK;
                this.Close();
        }

        /// <summary>
        /// Méthode pour annuler toute l'opération d'ajout.
        /// Celle-ci renvoie au formulaire précédent.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}

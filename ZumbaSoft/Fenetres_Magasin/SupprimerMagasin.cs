using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;
using SQLiteNetExtensions.Extensions;
using SQLite;

namespace ZumbaSoft.Fenetres_Magasin
{
    public partial class Confirmation : Form
    {
        Magasin magasin;
        SQLiteConnection DB;

        /// <summary>
        /// Constructeur de la boîte de dialogue de confirmation de suppression d'un magasin.
        /// Attention, après cela, le magasin est défintiivement supprimé.
        /// </summary>
        /// <param name="magasin">Le magasin à supprimer.</param>
        /// <param name="db">La connection actuelle à la base de données.</param>
        public Confirmation(Magasin magasin, SQLiteConnection db)
        {
            InitializeComponent();
            initItemsColors();
            this.magasin = magasin;
            this.DB = db;
        }

        /// <summary>
        /// Méthode pour initialiser les couleurs du formulaire.
        /// Elle n'est destinée à être appelée qu'une seule fois.
        /// </summary>
        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(90, System.Drawing.Color.Red);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonSupprimer.BackColor = Color.FromArgb(50, 12, 12, 12);

        }

        /// <summary>
        /// Méthode pour annuler toute la procédure.
        /// Celle-ci tue la fenêtre courante.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Méthode pour confirmer la suppression du magasin, l'effaçant de la base.
        /// Attention, cette méthode est définitive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            DB.Delete(magasin,true);
            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}

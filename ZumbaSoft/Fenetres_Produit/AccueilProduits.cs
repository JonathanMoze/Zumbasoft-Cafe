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
    public partial class AccueilProduits : Form
    {
        SQLiteConnection DB;
        public AccueilProduits(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initListProduits();
            initItemsColors();
        }

        public void initListProduits()
        {
            int nb = 0;
            foreach (Produit p in DB.GetAllWithChildren<Produit>())
            {
                listGenre.Items.Add(p);
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

        public void initItemsColors()
        {
            backgroundBlock.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonAjouterProduit.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonModifierProduit.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonSupprimerGenre.BackColor = Color.FromArgb(50, 12, 12, 12);
            erreurListevide.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel1.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel4.BackColor = Color.FromArgb(80, 12, 12, 12);
        }

        private void buttonSupprimerGenre_Click(object sender, EventArgs e)
        {
            var p = (Produit)listProduits.SelectedItem;
            SupprimerProduit supprimer = new SupprimerProduit(p, DB);
            if (supprimer.ShowDialog() == DialogResult.OK)
            {
                listGenre.Items.Remove(p);
            }
        }

        private void buttonModifierProduit_Click(object sender, EventArgs e)
        {
            if (listProduits.SelectedItem != null)
            {
                Produit p = (Produit)listProduits.SelectedItem;
                ModifierProduit paramétrer = new ModifierProduit(p, DB);
                if (paramétrer.ShowDialog() == DialogResult.OK)
                {
                    listProduits.Refresh();
                }
            }
        }

        private void buttonAjouterProduit_Click(object sender, EventArgs e)
        {
            AjouterProduit ajouterproduit = new AjouterProduit(DB);
            if (ajouterproduit.ShowDialog() == DialogResult.OK)
            {
                var pd = ajouterproduit.produit;
                listProduits.Items.Add(pd);
                listProduits.SelectedItem = pd;
            }
        }
        private void buttonRetourAccueil_Click(object sender, EventArgs e)
        {
            //TO DO
        }
    }
}

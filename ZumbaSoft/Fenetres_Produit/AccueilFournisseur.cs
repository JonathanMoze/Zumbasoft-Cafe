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
        public AccueilFournisseur(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initListFournisseur();
            initItemsColors();
        }

        public void initListFournisseur()
        {
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

        private void buttonSupprimerGenre_Click(object sender, EventArgs e)
        {
            var f = (Fournisseur)listFournisseur.SelectedItem;
            SupprimerFournisseur supprimer = new SupprimerFournisseur(f, DB);
            if (supprimer.ShowDialog() == DialogResult.OK)
            {
                listFournisseur.Items.Remove(f);
            }
        }

        private void buttonAjouterGenre_Click(object sender, EventArgs e)
        {
            AjouterFournisseur ajoutFournisseur = new AjouterFournisseur(DB);
            if (ajoutFournisseur.ShowDialog() == DialogResult.OK)
            {
                var fou = ajoutFournisseur.fournisseur;
                listFournisseur.Items.Add(fou);
                listFournisseur.SelectedItem = fou;
            }
        }

        private void buttonModifierGenre_Click(object sender, EventArgs e)
        {
            if (listFournisseur.SelectedItem != null)
            {
                Fournisseur f = (Fournisseur)listFournisseur.SelectedItem;
                ModifierFournisseur paramétrer = new ModifierFournisseur(f, DB);
                if (paramétrer.ShowDialog() == DialogResult.OK)
                {
                    listFournisseur.Refresh();
                }
            }
        }
    }
}

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

        public AccueilGenre(SQLiteConnection db, FormProduit f)
        {
            InitializeComponent();
            DB = db;
            formPrecedent = f;
            initListGenre();
            initItemsColors();
        }

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


        private void buttonAjouterGenre_Click(object sender, EventArgs e)
        {
            AjouterGenre ajouterGenre = new AjouterGenre(DB);
            if (ajouterGenre.ShowDialog() == DialogResult.OK)
            {
                initListGenre();
            }
        }

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

        private void buttonSupprimerGenre_Click(object sender, EventArgs e)
        {
            var g = (Genre)listGenre.SelectedItem;
            SupprimerGenre supprimer = new SupprimerGenre(g, DB);
            if (supprimer.ShowDialog() == DialogResult.OK)
            {
                listGenre.Items.Remove(g);
            }
        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AccueilGenre_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrecedent.initComboBoxes();
        }
    }
}

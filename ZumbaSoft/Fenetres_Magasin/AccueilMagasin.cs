using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Magasin
{
    public partial class AccueilMagasin : Form
    {
        SQLiteConnection DB;

        public AccueilMagasin(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initListMagasin();
            initItemsColors();
            
        }

        public void initListMagasin()
        {
            int nb = 0;
            foreach (Magasin m in DB.GetAllWithChildren<Magasin>()){
                listMagasin.Items.Add(m);
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
            buttonAjouterMagasin.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonModifierMagasin.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonSupprimerMagasin.BackColor = Color.FromArgb(50, 12, 12, 12);
            erreurListevide.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel1.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel4.BackColor = Color.FromArgb(80, 12, 12, 12);

        }

        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            var m = (Magasin)listMagasin.SelectedItem;
            SupprimerMagasin supprimer = new SupprimerMagasin(m, DB);
            if(supprimer.ShowDialog() == DialogResult.OK)
            {
                listMagasin.Items.Remove(m);
            }
        }

        private void boutonModifier_Click(object sender, EventArgs e)
        {
            if(listMagasin.SelectedItem != null)
            {
                Magasin m = (Magasin)listMagasin.SelectedItem;
                ParamétrerMagasin paramétrer = new ParamétrerMagasin(m,DB);
                if (paramétrer.ShowDialog() == DialogResult.OK)
                {
                    listMagasin.Refresh();
                }
            }
        }

        private void boutonAjouter_Click(object sender, EventArgs e)
        {
            AjouterMagasin ajouterMagasin = new AjouterMagasin(DB);
            if(ajouterMagasin.ShowDialog() == DialogResult.OK)
            {
                var mag = ajouterMagasin.magasin;
                listMagasin.Items.Add(mag);
                listMagasin.SelectedItem = mag;
            }
        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

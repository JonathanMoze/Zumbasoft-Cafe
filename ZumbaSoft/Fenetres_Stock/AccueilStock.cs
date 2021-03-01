using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Stock
{
    public partial class AccueilStock : Form
    {
        SQLiteConnection DB;
        public AccueilStock(SQLiteConnection db)
        {
            InitializeComponent();
            db = DB;
            initListStock();
        }
        public void initListStock()
        {
            foreach (ProduitEnStock ps in DB.GetAllWithChildren<ProduitEnStock>())
            {
                listStock.Items.Add(ps);
            }
        }

        private void buttonAjouterStock_Click(object sender, EventArgs e)
        {
            AjouterStock ajouterStock = new AjouterStock(DB);
            if (ajouterStock.ShowDialog() == DialogResult.OK)
            {
                var s = ajouterStock.produitEnStock;
                listStock.Items.Add(s);
                listStock.SelectedItem = s;
            }
        }

        private void buttonModifierStock_Click(object sender, EventArgs e)
        {
            if (listStock.SelectedItem != null)
            {
                ProduitEnStock ps = (ProduitEnStock)listStock.SelectedItem;
                ModifierStock modifStock = new ModifierStock(ps, DB);
                if (modifStock.ShowDialog() == DialogResult.OK)
                {
                    listStock.Refresh();
                }
            }
        }

        private void buttonSuppStock_Click(object sender, EventArgs e)
        {
            var ps = (ProduitEnStock)listStock.SelectedItem;
            SupprimerStock supprimer = new SupprimerStock(ps, DB);
            if (supprimer.ShowDialog() == DialogResult.OK)
            {
                listStock.Items.Remove(ps);
            }
        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

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
    public partial class AjouterStock : Form
    {
        SQLiteConnection DB;

        public ProduitEnStock produitEnStock;
        public Magasin magasin;

        public AjouterStock(SQLiteConnection db, Magasin m)
        {
            InitializeComponent();
            DB = db;
            magasin = m;

            initListProd();
        }

        public void initListProd()
        {
            List<Produit> produits = DB.Table<Produit>().ToList();
            listBoxProduits.Items.Add(produits);
        }
         
        public ProduitEnStock initObjectStock()
        {
            produitEnStock = new ProduitEnStock();
            //produitEnStock.quantite = barreQuantite;
            return produitEnStock;
        }

        private void buttonOKstock_Click(object sender, EventArgs e)
        {
            produitEnStock = initObjectStock();
            DB.InsertWithChildren(produitEnStock);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonAnnulerStock_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

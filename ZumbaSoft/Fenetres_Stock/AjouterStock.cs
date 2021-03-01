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
        public AjouterStock(SQLiteConnection db)
        {
            InitializeComponent();
            db = DB;
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
    }
}

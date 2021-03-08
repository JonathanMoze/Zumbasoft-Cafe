using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Produit
{
    public partial class AjouterProduit : Form
    {
        SQLiteConnection DB;
        public Produit produit;

        public AjouterProduit(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
        }

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            AccueilGenre accGenre = new AccueilGenre(DB);
            accGenre.Show();
        }

        private void buttonFournisseurs_Click(object sender, EventArgs e)
        {
            AccueilFournisseur accFourni = new AccueilFournisseur(DB);
            accFourni.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;
using SQLite;


namespace ZumbaSoft.Fenetres_Produit
{   
    public partial class SupprimerProduit : Form
    {
        SQLiteConnection DB;
        Produit produit;
        public SupprimerProduit(Produit p, SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            this.produit = p;

        }
    }
}

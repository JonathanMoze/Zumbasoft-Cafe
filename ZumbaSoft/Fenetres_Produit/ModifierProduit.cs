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
    public partial class ModifierProduit : Form
    {
        SQLiteConnection DB;
        Produit produit;
        public ModifierProduit(Produit p,SQLiteConnection db)
        {
            InitializeComponent();
            this.produit = p;
            DB = db;
        }
    }
}

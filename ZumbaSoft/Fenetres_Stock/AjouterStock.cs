using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Stock
{
    public partial class AjouterStock : Form
    {
        public ProduitEnStock produitEnStock;
        public AjouterStock(SQLiteConnection db)
        {
            InitializeComponent();
        }
    }
}

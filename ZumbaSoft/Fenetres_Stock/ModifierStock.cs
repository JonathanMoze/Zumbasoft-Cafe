using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;
using SQLite;

namespace ZumbaSoft.Fenetres_Stock
{
    public partial class ModifierStock : Form
    {
        public ModifierStock(ProduitEnStock ps, SQLiteConnection db)
        {
            InitializeComponent();
        }
    }
}

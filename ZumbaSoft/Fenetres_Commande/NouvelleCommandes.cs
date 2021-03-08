﻿using SQLite;
using System.Windows.Forms;

namespace ZumbaSoft.Fenetres_Commande
{
    public partial class NouvelleCommandes : Form
    {
        SQLiteConnection DB;

        public NouvelleCommandes()
        {
            InitializeComponent();
            initializeGrid();
        }

        private void initializeGrid()
        {
            tableauProd.ColumnCount = 5;
            tableauProd.Columns[0].Name = "Ref. Produit";
            tableauProd.Columns[1].Name = "Nom Produit";
            tableauProd.Columns[2].Name = "Quantité";
            tableauProd.Columns[3].Name = "Prix unitaire TTC";
            tableauProd.Columns[4].Name = "Prix totale TTC";
        }

        private void buttonAjouterProd_Click(object sender, System.EventArgs e)
        {
            ChoixProd_Fourni prodFourni = new ChoixProd_Fourni();
            if(prodFourni.ShowDialog() == DialogResult.OK)
            {
                //TODO
            }
        }
    }
}

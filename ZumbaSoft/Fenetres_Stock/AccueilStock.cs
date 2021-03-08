﻿using System;
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
        Magasin magasin;
        SQLiteConnection DB;

        public AccueilStock(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            magasin = new Magasin();
            initListStock(magasin);
        }

        private void initListStock(Magasin m)
        {
            List<ProduitEnStock> stock = DB.GetAllWithChildren<ProduitEnStock>(); //Et non pas Table<T>().ToList() car sinon magasin et produit sont null
            if(stock.Count > 0)
            {
                foreach (ProduitEnStock ps in stock)
                {
                    listStock.Items.Add(ps);
                }
            }
            else
            {
                listStock.Items.Add("Aucun produit en stock.");
            }
        }
        private ProduitEnStock initObjectStock()
        {
            ProduitEnStock produitEnStock = new ProduitEnStock();
            produitEnStock.quantite = (int)barreQuantite.Value;
            produitEnStock.produit = (Produit)listBoxProduits.SelectedItem;
            produitEnStock.magasin = magasin;
            return produitEnStock;
        }

        private bool isFieldNewPrdValid()
        {
            if(listBoxProduits.SelectedItem == null)
            {
                labelErreurListPrd.Visible = true;
                return false;
            }
            if(barreQuantite.Value == 0)
            {
                labelErreurBarreQtt.Visible = true;
                return false;
            }
            return true;
        }

        private void buttonAjouterStock_Click(object sender, EventArgs e)
        {
            if (isFieldNewPrdValid())
            {
                ProduitEnStock produit = initObjectStock();
                DB.InsertWithChildren(produit);
                majListStock(produit);
            }
        }

        private void majListStock(ProduitEnStock produitEnStock)
        {
            if(listStock.Items[0].Equals("Aucun produit en stock."))
            {
                listStock.Items.Clear();
            }
            listStock.Items.Add(produitEnStock);
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

        private void barreQuantite_ValueChanged(object sender, EventArgs e)
        {
            if (labelErreurBarreQtt.Visible)
            {
                labelErreurBarreQtt.Visible = false;
            }
        }
    }

}

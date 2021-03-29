﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLiteNetExtensions.Extensions;
using SQLite;
using ZumbaSoft.Model;
using ZumbaSoft.Fenetres_Ventes;

namespace ZumbaSoft.Fenetres_Produit
{
    public partial class RechercheProduit : Form
    {

        SQLiteConnection DB;
        public Produit selectedPRoduit;

        public RechercheProduit(SQLiteConnection db)
        {
            this.DB = db;
            InitializeComponent();
            initListProduit();
        }

        public void initListProduit()
        {
            if(DB.GetAllWithChildren<Produit>().Count >0)
            {
                foreach (Produit p in DB.GetAllWithChildren<Produit>())
                {
                    listBoxProduits.Items.Add(p);
                }
            }
            else
            {
                listBoxProduits.Items.Add("aucun produits");
            }
        }



        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {
            listBoxProduits.Items.Clear();
                string searche = textBoxRecherche.Text.ToUpper();
                List<Produit> produitsSearched = DB.GetAllWithChildren<Produit>().FindAll(p => p.nom.ToUpper().Contains(searche));
                listBoxProduits.Items.Clear();
                foreach (Produit p in produitsSearched)
                {
                    listBoxProduits.Items.Add(p);
                }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if(listBoxProduits.SelectedItem != null)
            {
                selectedPRoduit = (Produit)listBoxProduits.SelectedItem;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
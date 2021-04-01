using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZumbaSoft.Fenetres_Stock;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Stock.Tests
{
    [TestClass()]
    public class SupprimerStockTests
    {

        SQLiteConnection DB;

        public SupprimerStockTests()
        {
            InitializeDataBase();
        }

        [TestMethod()]
        public void SupprimerStockTest()
        {
            DB.DeleteAll<ProduitEnStock>();
            DB.DeleteAll<Produit>();

            Produit produit = new Produit();
            DB.InsertWithChildren(produit);
            Magasin magasin = new Magasin();
            DB.InsertWithChildren(magasin);
            int quantite = 10;
            ProduitEnStock pes = new ProduitEnStock() { produit = produit, magasin = magasin, quantite = quantite };
            DB.InsertWithChildren(pes);
            
            SupprimerStock suppStock = new SupprimerStock(pes, DB);
            while(!(suppStock.ShowDialog() == System.Windows.Forms.DialogResult.OK)) { }

            List<ProduitEnStock> produits = DB.GetAllWithChildren<ProduitEnStock>();
            Assert.IsTrue(produits[0].quantite < quantite);

            pes.quantite = 0;
            DB.UpdateWithChildren(pes);
            while (!(suppStock.ShowDialog() == System.Windows.Forms.DialogResult.OK)) { }

            produits = DB.GetAllWithChildren<ProduitEnStock>();
            Assert.IsTrue(produits.Count == 0);

        }

        public void InitializeDataBase()
        {
            string databasePath = System.IO.Path.GetFullPath("./../../../DataBase.db");
            DB = new SQLiteConnection(databasePath);
            DB.CreateTable<Adresse>();
            DB.CreateTable<Genre>();
            DB.CreateTable<Produit>();
            DB.CreateTable<Client>();
            DB.CreateTable<Commande>();
            DB.CreateTable<Disponibilite>();
            DB.CreateTable<Droit>();
            DB.CreateTable<FicheDePaye>();
            DB.CreateTable<Fournisseur>();
            DB.CreateTable<Magasin>();
            DB.CreateTable<Panier>();
            DB.CreateTable<Personne>();
            DB.CreateTable<ProduitCommande>();
            DB.CreateTable<ProduitEnStock>();
            DB.CreateTable<Rapport>();
            DB.CreateTable<Role>();
            DB.CreateTable<Utilisateur>();
            DB.CreateTable<DroitToRole>();
        }
    }
}
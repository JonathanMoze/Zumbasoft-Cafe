using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZumbaSoft.Fenetres_Produit;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Produit.Tests
{
    [TestClass()]
    public class RechercheProduitTests
    {
        SQLiteConnection db;

        public RechercheProduitTests()
        {
            InitializeDataBase();
        }

        public void InitializeDataBase()
        {
            string databasePath = System.IO.Path.GetFullPath("./../../../DataBase.db");
            db = new SQLiteConnection(databasePath);
            db.CreateTable<Adresse>();
            db.CreateTable<Genre>();
            db.CreateTable<Produit>();
            db.CreateTable<Client>();
            db.CreateTable<Commande>();
            db.CreateTable<Disponibilite>();
            db.CreateTable<Droit>();
            db.CreateTable<FicheDePaye>();
            db.CreateTable<Fournisseur>();
            db.CreateTable<Magasin>();
            db.CreateTable<Panier>();
            db.CreateTable<Personne>();
            db.CreateTable<ProduitCommande>();
            db.CreateTable<ProduitEnStock>();
            db.CreateTable<Rapport>();
            db.CreateTable<Role>();
            db.CreateTable<Utilisateur>();
            db.CreateTable<DroitToRole>();
        }


        [TestMethod()]
        public void initListProduitTest()
        {
            db.DeleteAll<Produit>();

            RechercheProduit rp = new RechercheProduit(db);
            Assert.AreEqual(rp.listBoxProduits.Items[0], "aucun produits");


            Produit p = new Produit();
            p.nom = "test";
            p.etat = EtatEnum.EnStock;

            db.InsertWithChildren(p);

            
            rp.initListProduit();

            Assert.IsTrue(rp.listBoxProduits.Items.Count == 1);
            Produit ptest = (Produit)rp.listBoxProduits.Items[0];
            Assert.IsTrue(ptest.nom == "test");
        }

        [TestMethod()]
        public void buttonValider_ClickTest()
        {
            db.DeleteAll<Produit>();

            RechercheProduit rp = new RechercheProduit(db);
            Assert.AreEqual(rp.listBoxProduits.Items[0], "aucun produits");


            Produit p = new Produit();
            p.nom = "test";
            p.etat = EtatEnum.EnStock;

            db.InsertWithChildren(p);


            rp.initListProduit();

            rp.listBoxProduits.SelectedIndex = 0;
            rp.buttonValider_Click(null, null);

            Assert.AreEqual(p.id_produit, rp.selectedPRoduit.id_produit);
        }
    }
}
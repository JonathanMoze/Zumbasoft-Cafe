using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZumbaSoft;
using ZumbaSoft.Model;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ZumbaSoft.Tests
{
    [TestClass()]
    public class AccueilTests
    {

        SQLiteConnection db;

        public AccueilTests()
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
        }

        [TestMethod()]
        public void AccueilTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AccueilTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void initItemsColorsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InitializeDataBaseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RoleButton_ClickTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void buttonGestionMag_ClickTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void buttonSeConnecter_ClickTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void buttonGestionStock_ClickTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void quitButton_ClickTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void buttonGestionProduits_ClickTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void buttonGestionStock_Click_1Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void buttonAcceptConditions_ClickTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void label3_ClickTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void buttonGestionVentes_ClickTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Accueil_FormClosedTest()
        {
            Assert.Fail();
        }
    }
}
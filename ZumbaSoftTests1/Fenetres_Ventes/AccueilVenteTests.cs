using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZumbaSoft.Fenetres_Ventes;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using ZumbaSoft.Model;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Ventes.Tests
{
    [TestClass()]
    public class AccueilVenteTests
    {
        SQLiteConnection db;
        Magasin m;

        [TestMethod()]
        public void AccueilVenteTest()
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
        public void initListClientsTest()
        {
            db.DeleteAll<Client>();

            Client c1 = new Client();
            c1.nom = "Martin";
            Client c2 = new Client();
            c2.nom = "Stephane";

            db.InsertWithChildren(c1);
            db.InsertWithChildren(c2);

            AccueilVente c = new AccueilVente(db,m);
            c.initListClients();

            Assert.IsTrue(c.listBox1RechercheClient.Items.Count == 2);
            Client ctest1 = (Client)c.listBox1RechercheClient.Items[0];
            Client ctest2 = (Client)c.listBox1RechercheClient.Items[1];
            Assert.IsTrue(ctest1.nom == c1.nom);
            Assert.IsTrue(ctest2.nom == c2.nom);
        }

        [TestMethod()]
        public void refreshListPanierTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void refreshPrixTotalTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void buttonCatalogueProd_ClickTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void buttonPlus_ClickTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void buttonMoins_ClickTest()
        {
            Assert.Fail();
        }
    }
}
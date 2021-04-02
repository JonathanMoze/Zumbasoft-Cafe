using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZumbaSoft.Fenetres_Ventes;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;
using SQLiteNetExtensions;

namespace ZumbaSoft.Fenetres_Ventes.Tests
{
    [TestClass()]
    public class AccueilClientTests
    {
        SQLiteConnection db;
        Client client;

        public AccueilClientTests()
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
        public void initListClientTest()
        {
            db.DeleteAll<Client>();

            Client c1 = new Client();
            c1.prenom = "Julien";
            c1.nom = "Marchand";
            Client c2 = new Client();
            c2.prenom = "Antoine";
            c2.nom = "Test";

            db.InsertWithChildren(c1);
            db.InsertWithChildren(c2);

            AccueilClient c = new AccueilClient(db, null, null);
            c.initListClient();

            Assert.IsTrue(c.listClient.Items.Count == 2);
            Client ctest1 = (Client)c.listClient.Items[0];
            Client ctest2 = (Client)c.listClient.Items[1];
            Assert.IsTrue(ctest1.nom == c1.nom);
            Assert.IsTrue(ctest2.nom == c2.nom);
        }
    }
}
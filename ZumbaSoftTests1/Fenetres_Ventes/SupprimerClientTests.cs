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
    public class SupprimerClientTests
    {
        SQLiteConnection db;
        Client client;

        public SupprimerClientTests()
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
        public void buttonSupprimer_ClickTest()
        {
            db.DeleteAll<Client>();

            Client c1 = new Client();
            c1.nom = "Teo";
            c1.prenom = "Test";
            db.InsertWithChildren(c1);

            AccueilClient c = new AccueilClient(db, null, null);
            c.initListClient();

            Assert.IsTrue(c.listClient.Items.Count == 1);

            c.listClient.SelectedIndex = 0;

            c.buttonSupprimerClient_Click(null, null);

            c.initListClient();

            Assert.IsTrue(c.listClient.Items.Count == 0);
        }
    }
}
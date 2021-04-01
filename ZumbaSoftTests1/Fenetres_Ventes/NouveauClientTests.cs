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
    public class NouveauClientTests
    {
        SQLiteConnection db;
        Client client;

        [TestMethod()]
        public void NouveauClientTest()
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
        public void buttonValider_ClickTest()
        {
            db.DeleteAll<Client>();
            NouveauClient c = new NouveauClient(db);
            AccueilClient ac = new AccueilClient(db, client);

            c.textBoxNom.Text = "Thomas";
            c.buttonValider_Click(null, null);

            Assert.IsTrue(ac.listClient.Items.Count == 1);
            Client ctest1 = (Client)ac.listClient.Items[0];
            Assert.IsTrue(ctest1.nom == "Thomas");
        }
    }
}
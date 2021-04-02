using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZumbaSoft.Fenetres_Produit;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Produit.Tests
{
    [TestClass()]
    public class AjouterGenreTests
    {
        SQLiteConnection db;
        FormProduit genre;

        public AjouterGenreTests()
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
        public void buttonOK_ClickTest()
        {
            db.DeleteAll<Genre>();
            AjouterGenre g = new AjouterGenre(db);
            AccueilGenre ag = new AccueilGenre(db, genre);

            g.textBoxNom.Text = "capsule";

            g.buttonOK_Click(null, null);
            ag.initListGenre();

            Assert.IsTrue(db.GetAllWithChildren<Genre>().Count == 1);
            Genre gtest1 = (Genre)ag.listGenre.Items[0];
            Assert.IsTrue(gtest1.intitule == "capsule");
        }
    }
}
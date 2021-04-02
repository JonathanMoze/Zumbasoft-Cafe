using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZumbaSoft.Fenetres_Produit;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using ZumbaSoft.Model;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Produit.Tests
{
    [TestClass()]
    public class SupprimerGenreTests
    {
        SQLiteConnection db;
        FormProduit gen;
        public  SupprimerGenreTests()
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
            db.DeleteAll<Genre>();

            Genre g1 = new Genre();
            g1.intitule = "genre1";
            db.InsertWithChildren(g1);

            AccueilGenre g = new AccueilGenre(db, gen);
            SupprimerGenre sg = new SupprimerGenre(g1, db);
            g.initListGenre();

            Assert.IsTrue(g.listGenre.Items.Count == 1);
            g.listGenre.SelectedIndex = 0;
            sg.buttonSupprimer_Click(null, null);
            g.initListGenre();

            Assert.IsTrue(g.listGenre.Items.Count == 0);
        }
    }
}
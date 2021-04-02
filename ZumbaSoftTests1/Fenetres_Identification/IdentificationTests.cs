using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZumbaSoft.Fenetres_Identification;
using ZumbaSoft.Model;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Identification.Tests
{
    [TestClass()]
    public class IdentificationTests
    {

        SQLiteConnection db;

        public IdentificationTests()
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
        public void connection_button_ClickTest()
        {
            db.DeleteAll<Utilisateur>();

            Utilisateur u = new Utilisateur();
            u.adresse = null;
            u.login = "loginTest";
            u.mot_de_passe = "123456";
            u.nom = "MonNom";
            u.prenom = "MonPrenom";

            db.InsertWithChildren(u);

            Identification i = new Identification(db);
            i.loginField.Text = "loginTest";
            i.passwordField.Text = "123456";

            Assert.IsTrue(i.uConnecte == null);

            i.connection_button_Click(null, null);

            Assert.IsTrue(i.uConnecte.id_personne == u.id_personne);
        }

        [TestMethod()]
        public void get_passTest()
        {
            db.DeleteAll<Utilisateur>();

            Utilisateur u = new Utilisateur();
            u.adresse = null;
            u.login = "loginTest";
            u.mot_de_passe = "123456";
            u.nom = "MonNom";
            u.prenom = "MonPrenom";

            db.InsertWithChildren(u);

            Identification i = new Identification(db);
            Assert.IsTrue(i.get_pass(u.login) == u.mot_de_passe);
        }
    }
}
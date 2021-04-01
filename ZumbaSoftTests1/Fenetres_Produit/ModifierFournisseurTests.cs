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
    public class ModifierFournisseurTests
    {
        SQLiteConnection db;
        FormProduit fournisseur;

        public ModifierFournisseurTests()
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
        public void buttonOKParamMag_ClickTest()
        {
            db.DeleteAll<Fournisseur>();
            Fournisseur ftest = new Fournisseur();
            ftest.nom = "TEST";
            ftest.produits = new List<Produit>();
            ftest.commandes = new List<Commande>();
            db.InsertWithChildren(ftest);
            AccueilFournisseur af = new AccueilFournisseur(db, fournisseur);
            ModifierFournisseur f = new ModifierFournisseur(af,ftest, db);

            Fournisseur fbefore = db.GetAllWithChildren<Fournisseur>()[0];
            Assert.IsTrue(fbefore.nom == "TEST");
            f.textBoxNom.Text = "Ninous";
            f.buttonOKParamMag_Click(null, null);
            af.initListFournisseur();
            
            Assert.IsTrue(db.GetAllWithChildren<Fournisseur>().Count == 1);
            Fournisseur ftest1 = db.GetAllWithChildren<Fournisseur>()[0];
            Assert.IsTrue(ftest1.nom == "Ninous");
        }
    }
}
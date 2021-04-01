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
    public class SupprimerFournisseurTests
    {
        SQLiteConnection db;
        FormProduit fourni;
        Fournisseur fournisseur;

        [TestMethod()]
        public void SupprimerFournisseurTest()
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
            db.DeleteAll<Fournisseur>();

            Fournisseur f1 = new Fournisseur();
            f1.nom = "fourni1";
            db.InsertWithChildren(f1);

            AccueilFournisseur f = new AccueilFournisseur(db, fourni);
            SupprimerFournisseur sf = new SupprimerFournisseur(fournisseur,db);
            f.initListFournisseur();

            Assert.IsTrue(f.listFournisseur.Items.Count == 1);
            f.listFournisseur.SelectedIndex = 0;
            sf.buttonSupprimer_Click(null, null);
            f.initListFournisseur();

            Assert.IsTrue(f.listFournisseur.Items.Count == 0);
        }
    }
}
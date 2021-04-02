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
    public class AjouterFournisseurTests
    {
        SQLiteConnection db;
        FormProduit fourni;

        public AjouterFournisseurTests()
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
            db.DeleteAll<Fournisseur>();
            AjouterFournisseur f = new AjouterFournisseur(db);
            AccueilFournisseur af = new AccueilFournisseur(db, fourni);

            f.textBoxNom.Text = "Ninous";
            f.textBoxMailFourni.Text = "mathilde@gmail.com";
            f.textBoxEtatFourni.Text = "test";
            f.textBoxTelFourni.Text = "0793847539";
            f.adresse = new Adresse();
            f.textBoxAdr.Text = "ok";

            f.buttonOK_Click(null, null);
            af.initListFournisseur();

            int test = db.GetAllWithChildren<Fournisseur>().Count;
            Assert.IsTrue( test == 1);
            Fournisseur ftest1 = (Fournisseur)af.listFournisseur.Items[0];
            Assert.IsTrue(ftest1.nom == "Ninous");
        }
    }
}
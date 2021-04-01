using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZumbaSoft.Fenetres_Magasin;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;
using System.Runtime.InteropServices;

namespace ZumbaSoft.Fenetres_Magasin.Tests
{
    [TestClass()]
    public class AccueilMagasinTests
    {

        SQLiteConnection db;

        public AccueilMagasinTests()
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
        public void updateListMagasin()
        {
            db.DeleteAll<Adresse>();
            db.DeleteAll<Magasin>();

            for (int i=0; i < 20; i++)
            {
                Adresse adresse = new Adresse() { adresse = i + " Rue de OUATELSE", code_postal = (i * 10000).ToString(), ville = "Bordeaux " + i };
                Magasin mag = new Magasin() { adresse = adresse, mot_de_passe = "MOTDEPASSE12345" };
                db.InsertWithChildren(mag);
            }

            AccueilMagasin am = new AccueilMagasin(db,null);

            am.updateListMagasin();

            Assert.AreEqual(20, am.listMagasin.Items.Count);

            Magasin magasin = db.Table<Magasin>().ToList()[0];
            db.Delete(magasin);

            am.updateListMagasin();
            Assert.AreEqual(19, am.listMagasin.Items.Count);

        }

        [TestMethod()]
        public void buttonAjouter_ClickTest()
        {
            db.DeleteAll<Magasin>();
            db.DeleteAll<Adresse>();

            AccueilMagasin am = new AccueilMagasin(db,null);

            for (int i = 0; i < 20; i++)
            {
                Adresse adresse = new Adresse() { adresse = i + " Rue de OUATELSE", code_postal = (i * 10000).ToString(), ville = "Bordeaux " + i };
                am.newAdresse = adresse;
                db.Insert(adresse);
                am.textBoxNewMdp.Text = "MOTDEPASSE12345";
                Magasin mag = am.initObjectMagasin();
                Assert.IsNotNull(mag);
                db.InsertWithChildren(mag);
            }

            List<Magasin> magasins = db.Table<Magasin>().ToList();
            Assert.IsTrue(magasins.Count == 20);
            List<Adresse> adresses = db.Table<Adresse>().ToList();
            Assert.IsTrue(adresses.Count == 20);
        }

        // Il s'agit ici du test pour NouvelleAsresse
        [TestMethod()]
        public void buttonAdr_ClickTest()
        {
            db.DeleteAll<Adresse>();

            NouvelleAdresse nouvelleAdresse = new NouvelleAdresse(db);
            nouvelleAdresse.textBoxAdresse.Text = "53 Rue de OUATELSE";
            nouvelleAdresse.textBoxCodePostal.Text = "33600";
            nouvelleAdresse.textBoxVille.Text = "Pessac";

            nouvelleAdresse.buttonOK_Click(null, null);
            Adresse adresse = db.Table<Adresse>().ToList()[0];

            Assert.IsNotNull(adresse);
            Assert.IsTrue(adresse.code_postal == "33600");
            Assert.IsTrue(adresse.adresse == "53 Rue de OUATELSE");
            Assert.IsTrue(adresse.ville == "Pessac");
        }
    }
}
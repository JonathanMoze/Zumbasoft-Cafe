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
    public class CreationCompteTests
    {

        SQLiteConnection db;

        public CreationCompteTests()
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
        public void CreationCompteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void initComboBoxesTest()
        {
            db.DeleteAll<Role>();

            Role r1 = new Role();
            r1.nom = "vendeur";
            Role r2 = new Role();
            r1.nom = "Directeur";

            CreationCompte c = new CreationCompte(db);
            c.initComboBoxes();

            Assert.IsTrue(c.comboBoxCivilité.Items.Count == 2);
            Assert.IsTrue(c.comboBoxStatus.Items.Count == 2);
            Assert.IsTrue(c.comboBoxRole.Items.Count == 2);

        }

        [TestMethod()]
        public void correctInformationsTest()
        {
            Utilisateur utilisateur = new Utilisateur();
            db.DeleteAll<Role>();

            Role r1 = new Role();
            r1.nom = "vendeur";
            Role r2 = new Role();
            r1.nom = "Directeur";

            CreationCompte c = new CreationCompte(db);
            c.initComboBoxes();


            c.comboBoxCivilité.SelectedItem = EnumCivilite.Monsieur;
            c.comboBoxStatus.SelectedItem = EnumStatus.Actif;
            c.textBoxNom.Text = "Moze";
            c.textBoxPrenom.Text = "Jonathan";
            c.textBoxTel.Text = "0683543525";
            c.textBoxMail.Text = "test@gmail.com";
            c.dateTimeNaissance.Value = new DateTime(2008, 3, 1);
            c.adresse = new Adresse();
            c.textBoxLogin.Text = "MonLogin";
            c.textBoxPassword.Text = "MonMotDePasse";


        }

        [TestMethod()]
        public void loginUniqueTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAgeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void buttonValider_ClickTest()
        {
            Assert.Fail();
        }
    }
}
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
        public void initComboBoxesTest()
        {
            db.DeleteAll<Role>();

            Role r1 = new Role();
            r1.nom = "vendeur";
            Role r2 = new Role();
            r1.nom = "Directeur";

            db.InsertWithChildren(r1);
            db.InsertWithChildren(r2);

            CreationCompte c = new CreationCompte(db);
            c.initComboBoxes();

            Assert.IsTrue(c.comboBoxCivilité.Items.Count == 3);
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

            db.InsertWithChildren(r1);
            db.InsertWithChildren(r2);

            CreationCompte c = new CreationCompte(db);
            c.initComboBoxes();


            c.comboBoxCivilité.SelectedItem = EnumCivilite.Monsieur;
            c.comboBoxStatus.SelectedItem = EnumStatus.Actif;
            c.comboBoxRole.SelectedIndex = 0;
            c.textBoxNom.Text = "Moze";
            c.textBoxPrenom.Text = "Jonathan";
            c.textBoxTel.Text = "0683543525";
            c.textBoxMail.Text = "test@gmail.com";
            c.dateTimeNaissance.Value = new DateTime(2000, 3, 1);
            c.adresse = new Adresse();
            c.textBoxLogin.Text = "MonLogin";
            c.textBoxPassword.Text = "MonMotDePasse";

            c.comboBoxCivilité.SelectedItem = null;
            Assert.IsFalse(c.correctInformations());
            c.comboBoxCivilité.SelectedItem = EnumCivilite.Monsieur;

            c.comboBoxStatus.SelectedItem = null;
            Assert.IsFalse(c.correctInformations());
            c.comboBoxStatus.SelectedItem = EnumStatus.Actif;

            c.comboBoxRole.SelectedItem = null;
            Assert.IsFalse(c.correctInformations());
            c.comboBoxRole.SelectedIndex = 0;

            c.textBoxNom.Text = "";
            Assert.IsFalse(c.correctInformations());
            c.textBoxNom.Text = "Moze";

            c.textBoxPrenom.Text = "";
            Assert.IsFalse(c.correctInformations());
            c.textBoxPrenom.Text = "Jonathan";

            c.textBoxTel.Text = "test";
            Assert.IsFalse(c.correctInformations());
            c.textBoxTel.Text = "0683543525";

            c.textBoxMail.Text = "";
            Assert.IsFalse(c.correctInformations());
            c.textBoxMail.Text = "test@gmail.com";


            c.dateTimeNaissance.Value = DateTime.Now;
            Assert.IsFalse(c.correctInformations());
            c.dateTimeNaissance.Value = new DateTime(2000, 3, 1);

            c.textBoxLogin.Text = "";
            Assert.IsFalse(c.correctInformations());
            c.textBoxLogin.Text = "MonLogin";

            c.textBoxPassword.Text = "";
            Assert.IsFalse(c.correctInformations());
            c.textBoxPassword.Text = "MonMotDePasse";


            Assert.IsTrue(c.correctInformations());
        }

        [TestMethod()]
        public void loginUniqueTest()
        {

            db.DeleteAll<Utilisateur>();


            CreationCompte cc = new CreationCompte(db);
            cc.initComboBoxes();

            Utilisateur c = new Utilisateur();

            c.civilite = EnumCivilite.Monsieur;
            c.status = EnumStatus.Actif;
            c.role = new Role();
            c.nom= "Moze";
            c.prenom = "Jonathan";
            c.telephone = "0683543525";
            c.email = "test@gmail.com";
            c.date_naissance = new DateTime(2000, 3, 1);
            c.adresse = new Adresse();
            c.login = "MonLogin";
            c.mot_de_passe = "MonMotDePasse";

            db.InsertWithChildren(c);

            cc.textBoxLogin.Text = "MonLogin";

            Assert.IsFalse(cc.loginUnique());

            cc.textBoxLogin.Text = "NewLogin";

            Assert.IsTrue(cc.loginUnique());

        }

        [TestMethod()]
        public void GetAgeTest()
        {
            DateTime datenaissance = new DateTime(2010, 3, 1);
            CreationCompte cc = new CreationCompte(db);

            Assert.AreEqual(cc.GetAge(datenaissance), 11);

        }

        [TestMethod()]
        public void buttonValider_ClickTest()
        {
            Utilisateur utilisateur = new Utilisateur();
            db.DeleteAll<Role>();
            db.DeleteAll<Utilisateur>();

            Role r1 = new Role();
            r1.nom = "vendeur";
            Role r2 = new Role();
            r1.nom = "Directeur";

            db.InsertWithChildren(r1);
            db.InsertWithChildren(r2);

            CreationCompte c = new CreationCompte(db);
            c.initComboBoxes();


            c.comboBoxCivilité.SelectedItem = EnumCivilite.Monsieur;
            c.comboBoxStatus.SelectedItem = EnumStatus.Actif;
            c.comboBoxRole.SelectedIndex = 0;
            c.textBoxNom.Text = "Moze";
            c.textBoxPrenom.Text = "Jonathan";
            c.textBoxTel.Text = "0683543525";
            c.textBoxMail.Text = "test@gmail.com";
            c.dateTimeNaissance.Value = new DateTime(2000, 3, 1);
            c.adresse = new Adresse();
            c.textBoxLogin.Text = "MonLogin";
            c.textBoxPassword.Text = "MonMotDePasse";

            c.buttonValider_Click(null, null);

            Assert.IsTrue(db.GetAllWithChildren<Utilisateur>().Count == 1);
        }
    }
}
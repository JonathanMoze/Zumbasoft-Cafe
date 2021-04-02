using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZumbaSoft.Fenetres_Roles;
using ZumbaSoft.Model;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Roles.Tests
{
    [TestClass()]
    public class RolesTests
    {
        SQLiteConnection db;

        public RolesTests()
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
        public void initListRolesTest()
        {
            db.DeleteAll<Role>();

            Role r1 = new Role();
            r1.nom = "vendeur";
            Role r2 = new Role();
            r1.nom = "Directeur";

            db.InsertWithChildren(r1);
            db.InsertWithChildren(r2);

            Roles r = new Roles(db);
            r.initListRoles();

            Assert.IsTrue(r.choixRoles.Items.Count == 2);
            Role rtest1 = (Role)r.choixRoles.Items[0];
            Role rtest2 = (Role)r.choixRoles.Items[1];
            Assert.IsTrue(rtest1.nom == r1.nom);
            Assert.IsTrue(rtest2.nom == r2.nom);



        }

        [TestMethod()]
        public void ajouterRoles_ClickTest()
        {
            db.DeleteAll<Role>();
            Roles r = new Roles(db);

            r.nomRole.Text = "Directeur";
            r.ajouterRoles_Click(null, null);

            Assert.IsTrue(r.choixRoles.Items.Count == 1);
            Role rtest1 = (Role)r.choixRoles.Items[0];
            Assert.IsTrue(rtest1.nom == "Directeur");
        }

        [TestMethod()]
        public void supprimerRole_ClickTest()
        {
            db.DeleteAll<Role>();

            Role r1 = new Role();
            r1.nom = "vendeur";
            db.InsertWithChildren(r1);

            Roles r = new Roles(db);
            r.initListRoles();

            Assert.IsTrue(r.choixRoles.Items.Count == 1);

            r.ConfirmationSR.Checked = true;
            r.choixRoles.SelectedIndex = 0;

            r.supprimerRole_Click(null, null);

            Assert.IsTrue(r.choixRoles.Items.Count == 0);
        }
    }
}
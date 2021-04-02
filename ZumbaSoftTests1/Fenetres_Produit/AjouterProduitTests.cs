using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZumbaSoft.Fenetres_Produit;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Produit.Tests
{
    [TestClass()]
    public class AjouterProduitTests
    {
        SQLiteConnection db;

        public AjouterProduitTests()
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
            db.DeleteAll<Fournisseur>();
            db.DeleteAll<Genre>();

            Fournisseur f = new Fournisseur();
            f.nom = "fournisseur1";
            Genre g = new Genre();
            g.intitule = "genre1";

            db.InsertWithChildren(f);
            db.InsertWithChildren(g);

            AjouterProduit a = new AjouterProduit(db);

            a.initComboBoxes();
            Assert.IsTrue(a.comboBoxFournisseur.Items.Count == 1);
            Assert.IsTrue(a.comboBoxGenre.Items.Count == 1);

        }


        [TestMethod()]
        public void buttonOK_ClickTest()
        {
            db.DeleteAll<Produit>();
            db.DeleteAll<Genre>();
            db.DeleteAll<Fournisseur>();

            Genre g = new Genre();
            g.intitule = "test";

            Fournisseur f = new Fournisseur();
            f.nom = "testfourni";
            f.adresse = new Adresse();

            db.InsertWithChildren(g);
            db.InsertWithChildren(f);

            AjouterProduit ap = new AjouterProduit(db);

            ap.initComboBoxes();

           
            ap.textBoxNom.Text = "NomProduit";
            ap.textBoxRef.Text = "RefProduit";
            ap.textBoxCodeB.Text = "452665";


            ap.numericUpDownAHT.Value = 7;
            ap.numericUpDownATTC.Value = 10.16M;
            ap.numericUpDownVHT.Value = 20;
            ap.numericUpDownVTTC.Value = 25.56M;


            ap.textBoxType.Text = "TypeProduit";
            ap.textBoxMarque.Text = "MarqueProduit";
            ap.textBoxCouleur.Text = "CouleurProduit";
            ap.comboBoxGenre.SelectedIndex = 0;
            ap.comboBoxFournisseur.SelectedIndex = 0;

            ap.buttonOK_Click(null,null);

            Assert.IsTrue(db.GetAllWithChildren<Produit>().Count == 1);
            Assert.IsTrue(db.GetAllWithChildren<Produit>()[0].nom == "NomProduit");
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZumbaSoft.Fenetres_Stock;
using System;
using System.Collections.Generic;
using System.Text;
using ZumbaSoft.Model;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Stock.Tests
{
    [TestClass()]
    public class AccueilStockTests
    {
        List<Produit> produits = new List<Produit>();
        SQLiteConnection DB;

        public AccueilStockTests()
        {
            InitializeDataBase();
            Fournisseur fournisseur = new Fournisseur() { nom = "LEADER COFEE" };
            DB.InsertWithChildren(fournisseur);
            string[] productName = { "café", "cosi", "fortissio", "vivalto", "roma", "arpeigo", "pura", "lungo", "rizla", "dolce latte" };
            for(int i=0; i < 10; i++)
            {
                Produit prod = new Produit() { fournisseur = fournisseur ,nom = productName[i], etat = EtatEnum.Rupture, marque = "Nespresso", prix_vente_TTC = 2, prix_achat_TTC = 1 };
                produits.Add(prod);
            }
            DB.InsertAllWithChildren(produits);
            
        }

        public void InitializeDataBase()
        {
            string databasePath = System.IO.Path.GetFullPath("./../../../DataBase.db");
            DB = new SQLiteConnection(databasePath);
            DB.CreateTable<Adresse>();
            DB.CreateTable<Genre>();
            DB.CreateTable<Produit>();
            DB.CreateTable<Client>();
            DB.CreateTable<Commande>();
            DB.CreateTable<Disponibilite>();
            DB.CreateTable<Droit>();
            DB.CreateTable<FicheDePaye>();
            DB.CreateTable<Fournisseur>();
            DB.CreateTable<Magasin>();
            DB.CreateTable<Panier>();
            DB.CreateTable<Personne>();
            DB.CreateTable<ProduitCommande>();
            DB.CreateTable<ProduitToCommande>();
            DB.CreateTable<ProduitEnStock>();
            DB.CreateTable<Rapport>();
            DB.CreateTable<Role>();
            DB.CreateTable<Utilisateur>();
            DB.CreateTable<DroitToRole>();
        }

        [TestMethod()]
        public void initTableaux()
        {
            DB.DeleteAll<ProduitEnStock>();
            DB.DeleteAll<Commande>();
            DB.DeleteAll<Magasin>();

            foreach (Produit p in produits)
            {
                ProduitEnStock pes = new ProduitEnStock() { produit = p, quantite = 1, magasin = new Magasin() };
                DB.InsertWithChildren(pes);
            }

            Magasin magasin = new Magasin();
            DB.Insert(magasin);
            foreach(Produit p in produits)
            {
                List<ProduitToCommande> ptcS = new List<ProduitToCommande>();
                ProduitToCommande produit = new ProduitToCommande() { produit = p, quantite = 5 };
                ptcS.Add(produit);
                DB.InsertAllWithChildren(ptcS);
                Commande commande = new Commande() { magasin = new Magasin(), fournisseur = p.fournisseur, PTC = ptcS };
                DB.InsertWithChildren(commande);
            }

            AccueilStock accueilStock = new AccueilStock(DB, null);

            Assert.AreEqual(10 + 1, accueilStock.tableauCommandes.Rows.Count);
            Assert.AreEqual(10 + 1, accueilStock.tableauStock.Rows.Count);
            Assert.AreEqual("10", accueilStock.textBoxNbArticle.Text);
            Assert.AreEqual("20 €", accueilStock.textBoxValeurStk.Text);
        }
    }
}
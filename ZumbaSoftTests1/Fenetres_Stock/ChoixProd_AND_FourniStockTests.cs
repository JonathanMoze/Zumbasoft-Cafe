using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZumbaSoft.Fenetres_Stock;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using ZumbaSoft.Model;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Stock.Tests
{
    [TestClass()]
    public class ChoixProd_AND_FourniStockTests
    {
        SQLiteConnection DB;

        [TestMethod()]
        public void ChoixProd_AND_FourniStockTest()
        {
            InitializeDataBase();
            List<Produit> produits = new List<Produit>();
            Fournisseur fournisseur = new Fournisseur() { nom = "LEADER COFEE" };
            DB.InsertWithChildren(fournisseur);
            Magasin magasin = new Magasin();
            string[] productName = { "café", "cosi", "fortissio", "vivalto", "roma", "arpeigo", "pura", "lungo", "rizla", "dolce latte" };
            for (int i = 0; i < 10; i++)
            {
                Produit prod = new Produit() { fournisseur = fournisseur, nom = productName[i], etat = EtatEnum.Rupture, marque = "Nespresso", prix_vente_TTC = 2, prix_achat_TTC = 1 };
                produits.Add(prod);
            }
            DB.InsertAllWithChildren(produits);

            ChoixProd_AND_FourniStock choixProd_AND_Fourni = new ChoixProd_AND_FourniStock(DB,magasin);

            choixProd_AND_Fourni.textBoxRecherchePrd.Text = "cosi";
            Assert.AreEqual("cosi", choixProd_AND_Fourni.listBoxProduits.Items[0].ToString());
            choixProd_AND_Fourni.listBoxProduits.SelectedIndex = 0;

            choixProd_AND_Fourni.barreQuantite.Value = 10;
            choixProd_AND_Fourni.pes = new ProduitEnStock() { produit = (Produit)choixProd_AND_Fourni.listBoxProduits.SelectedItem, quantite = (int)choixProd_AND_Fourni.barreQuantite.Value, magasin = magasin };
            choixProd_AND_Fourni.swithToFourni();

            choixProd_AND_Fourni.textBoxRechercheFourni.Text = "LEader";
            Assert.AreEqual("LEADER COFEE", choixProd_AND_Fourni.listBoxFournisseur.Items[0].ToString());
            choixProd_AND_Fourni.listBoxFournisseur.SelectedIndex = 0;

            choixProd_AND_Fourni.fournisseur = (Fournisseur)choixProd_AND_Fourni.listBoxFournisseur.SelectedItem;
            Assert.AreEqual(fournisseur.nom, choixProd_AND_Fourni.fournisseur.nom);
            Assert.AreEqual(10, choixProd_AND_Fourni.pes.quantite);
            Assert.AreEqual("cosi", choixProd_AND_Fourni.pes.produit.ToString());

            DB.DeleteAll<Produit>();
            DB.DeleteAll<Produit>();
            DB.DeleteAll<Magasin>();
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
    }
}
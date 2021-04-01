using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZumbaSoft;
using ZumbaSoft.Model;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ZumbaSoft.Tests
{
    [TestClass()]
    public class AccueilTests
    {


        [TestMethod()]
        public void InitializeDataBaseTest()
        {
            Accueil accueil = new ZumbaSoft.Accueil();

            List<string> allTablesName = new List<string>(){ "Adresse", "Genre", "Produit", "Client", "Commande", "Disponibilite", "Droit", "FicheDePaye", "Magasin","Fournisseur", "Panier", "Personne", "ProduitCommande", "ProduitEnStock", "Rapport", "Role", "Utilisateur" };
            int nbTable = allTablesName.Count;

            //Vérifie qu'il n'y a pas des tables étrangères.
            foreach (TableMapping map in accueil.db.TableMappings)
            {
                if (!allTablesName.Contains(map.TableName))
                {
                    if (!map.TableName.Equals("ColumnInfo"))
                    {
                        Assert.Fail("La table " + map.TableName + " ne devrait pas être créée.");
                    }

                }
                else
                {
                    nbTable--;
                }
            }

            //Vérifie que toutes les tables attendue sont bien présentent.
            Assert.AreEqual(0,nbTable);
        }
    }
}
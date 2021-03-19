using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Commande
{
    public partial class GestionDeLaCommande : Form
    {
        SQLiteConnection DB;
        Magasin magasin;
        public Commande commande;

        public GestionDeLaCommande(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initializeGrid();
        }

        public GestionDeLaCommande(SQLiteConnection db, Commande cmd)
        {
            InitializeComponent();
            DB = db;
            commande = cmd;
            initializeGrid();
        }

        private void initFieldCommande()
        {
            foreach(Produit prod in commande.produits.Keys)
            {
                commande.produits.TryGetValue(prod, out int q);
                object[] row = { prod.reference, prod.nom, q, prod.prix_achat_TTC, q * prod.prix_achat_TTC };
                tableauProd.Rows.Add(row);
            }
        }

        private void initializeGrid()
        {
            tableauProd.ColumnCount = 5;
            tableauProd.Columns[0].Name = "Ref. Produit";
            tableauProd.Columns[1].Name = "Nom Produit";
            tableauProd.Columns[2].Name = "Quantité";
            tableauProd.Columns[3].Name = "Prix unitaire TTC";
            tableauProd.Columns[4].Name = "Prix totale TTC";
        }

        private void buttonAjouterProd_Click(object sender, System.EventArgs e)
        {
            ChoixProd_Fourni prodFourni = new ChoixProd_Fourni(DB);
            if(prodFourni.ShowDialog() == DialogResult.OK)
            {
                Produit newProd = prodFourni.produit;
                Fournisseur newFourni = prodFourni.fournisseur;
                int quantite = prodFourni.quantite;
                ajouterALaCommande(newProd, newFourni, quantite);
            }
        }

        private void ajouterALaCommande(Produit p, Fournisseur f, int q)
        {
            if(commande == null)
            {
                commande = new Commande();
                commande.produits.Add(p, q);
                commande.fournisseur = f;
                commande.magasin = magasin;
                commande.dateCommande = DateTime.Today;
            }
            else
            {
                if(f.Equals(commande.fournisseur))
                {
                    commande.produits.Add(p, q);
                }
                else
                {
                    //TODO
                }
            }
            object[] row = { p.reference, p.nom, q, p.prix_achat_TTC, q * p.prix_achat_TTC };
            tableauProd.Rows.Add(row);
        }
    }
}

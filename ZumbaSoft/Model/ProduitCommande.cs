using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;


namespace ZumbaSoft.Model
{
    public class ProduitCommande
    {

        [PrimaryKey, AutoIncrement]
        public int id_produitCommande { get; set; }


        //Association Produit
        [ForeignKey(typeof(Produit))]
        public int id_produit { get; set; }

        [ManyToOne]
        public Produit produit { get; set; }

        //Association Panier
        [ForeignKey(typeof(Panier))]
        public int id_panier { get; set; }

        [ManyToOne]
        public Panier panier { get; set; }

        [NotNull]
        public int quantite { get; set; }

        //Entre 0 et 1
        public double reduc { get; set; }

    }
}

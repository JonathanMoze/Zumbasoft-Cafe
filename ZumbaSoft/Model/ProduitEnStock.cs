using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZumbaSoft.Model
{
    public class ProduitEnStock
    {
        [PrimaryKey, AutoIncrement]
        public int id_produitEnStock { get; set; }

        //Association Magasin
        [ForeignKey(typeof(Magasin))]
        public int id_magasin { get; set; }

        [ManyToOne]
        public Magasin magasin { get; set; }

        //Association Produit
        [ForeignKey(typeof(Produit))]
        public int id_produit { get; set; }

        [OneToOne]
        public Produit produit { get; set; }

        public int quantite { get; set; }

        public override string ToString()
        {
            return quantite.ToString() + " - " + produit.nom;
        }

    }
}

using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZumbaSoft.Model
{
    public class ProduitEnStock
    {
        //Association Magasin
        [ForeignKey(typeof(Magasin))]
        public int id_magasin { get; set; }

        [ManyToOne]
        public Magasin magasin { get; set; }

        //Association Produit
        [ForeignKey(typeof(Produit))]
        public int id_produit { get; set; }

        [ManyToOne]
        public Produit produit { get; set; }

        [NotNull]
        public int quantite { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
using ZumbaSoft.Model;

namespace ZumbaSoft.Model
{
    public class ProduitToCommande
    {
        [PrimaryKey, AutoIncrement]
        public int id_associationProdCmd { get; set; }

        //Association Produit
        [ManyToOne]
        public Produit produit { get; set; }

        [ForeignKey(typeof(Produit))]
        public int id_produit { get; set; }

        //Association Commande
        [ManyToOne]
        public Commande commande { get; set; }

        [ForeignKey(typeof(Commande))]
        public int id_commande { get; set; }

        public int quantite { get; set; }
    }
}

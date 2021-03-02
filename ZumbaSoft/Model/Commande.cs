using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZumbaSoft.Model
{
    public class Commande
    {
        [PrimaryKey, AutoIncrement]
        public int id_commande { get; set; }

        //Association Magasin
        [ForeignKey(typeof(Magasin))]
        public int id_magasin { get; set; }

        [OneToOne]
        public Magasin magasin { get; set; }

        //Association Produit
        [ForeignKey(typeof(Produit))]
        public int id_produit { get; set; }
        [OneToMany]
        public List<Produit> produits { get; set; }

        //Association Fournisseur
        [ForeignKey(typeof(Fournisseur))]
        public int id_fournisseur { get; set; }

        [OneToOne]
        public Fournisseur fournisseur { get; set; }

        public override string ToString()
        {
            return id_commande.ToString() + " - " + fournisseur.ToString();
        }
    }
}

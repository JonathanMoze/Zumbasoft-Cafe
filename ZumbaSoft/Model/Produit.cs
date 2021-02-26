using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ZumbaSoft.Model
{
    public class Produit
    {
        [PrimaryKey, AutoIncrement]
        public int id_produit { get; set; }

        public int code_barre { get; set; }

        public string nom { get; set; }

        public int prix_vente_HT { get; set; }

        public int prix_vente_TTC { get; set; }

        public int prix_achat_HT { get; set; }

        public int prix_achat_TTC { get; set; }

        public string reference { get; set; }

        public string couleur { get; set; }

        public string marque { get; set; }

        public string etat { get; set; }

        public string type { get; set; }

        //Association Genre
        [ForeignKey(typeof(Genre))]
        public int id_genre { get; set; }

        [ManyToOne]
        public Genre genre { get; set; }

        //Association Fournisseur
        [ForeignKey(typeof(Fournisseur))]
        public int id_fournisseur { get; set; }

        [ManyToOne]
        public Fournisseur fournisseur { get; set; }

    }
}

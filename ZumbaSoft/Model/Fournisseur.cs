using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ZumbaSoft.Model
{
    public class Fournisseur
    {
        [PrimaryKey, AutoIncrement]
        public int id_fournisseur { get; set; }

        public string nom { get; set; }

        public string mail { get; set; }

        public string etat_contrat { get; set; }

        public string telephone { get; set; }

        //Association Produit
        [OneToMany]
        public List<Produit> produits { get; set; }

        //Association Commande
        [OneToMany]
        public List<Commande> commandes { get; set; }

        //Association Adresse
        [ForeignKey(typeof(Adresse))]
        public int id_adresse { get; set; }

        [OneToOne]
        public Adresse adresse { get; set; }
    }
}

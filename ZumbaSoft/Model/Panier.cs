using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZumbaSoft.Model
{
    public class Panier
    {
        [PrimaryKey, AutoIncrement]
        public int id_panier { get; set; }

        public DateTime date { get; set; }

        public DateTime heure { get; set; }

        //Association Client
        [ForeignKey(typeof(Client))]
        public int id_client { get; set; }

        [ManyToOne]
        public Client client { get; set; }

        //Association Magasin
        [ForeignKey(typeof(Magasin))]
        public int id_magasin { get; set; }

        [ManyToOne]
        public Magasin magasin { get; set; }

        //Association Utlisateur
        [ForeignKey(typeof(Utilisateur))]
        public int id_utilisateur { get; set; }

        [ManyToOne]
        public Utilisateur utilisateur { get; set; }

        //Association ProduitCommande
        [OneToMany]
        public List<ProduitCommande> produits { get; set; }
    }
}

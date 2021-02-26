using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZumbaSoft.Model
{
    public class Magasin
    {
        [PrimaryKey, AutoIncrement]
        public int id_magasin { get; set; }

        public string mot_de_passe { get; set; }

        //Association Adresse
        [ForeignKey(typeof(Adresse))]
        public int id_adresse { get; set; }

        [OneToOne]
        public Adresse adresse { get; set; }

        //Association ProduitEnStock
        [OneToMany]
        public List<ProduitEnStock> stock { get; set; }

        //Association Commande
        [OneToMany]
        public List<Commande> commandes { get; set; }

        //Association Utilisateur
        [OneToMany]
        public List<Utilisateur> utilisateurs { get; set; }

        //Association Rapport
        [OneToMany]
        public List<Rapport> rapports { get; set; }

        //Association Panier
        [OneToMany]
        public List<Panier> paniers { get; set; }

    }
}

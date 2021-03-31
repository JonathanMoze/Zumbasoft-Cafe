using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZumbaSoft.Model
{
    public class Utilisateur : Personne
    {

        public string login { get; set; }

        public string mot_de_passe { get; set; }

        public string poste { get; set; }

        public DateTime date_embauche { get; set; }

        public int heures_par_semaine { get; set; }

        //Association FicheDePaye
        [OneToMany]
        public List<FicheDePaye> ficheDePayes { get; set; }

        //Association Panier
        [OneToMany]
        public List<Panier> paniersVendus { get; set; }

        //Association Magasin
        [ManyToOne]
        public Magasin magasin { get; set; }

        [ForeignKey(typeof(Magasin))]
        public int id_magasin { get; set; }

        //Association Role
        [OneToOne]
        public Role role { get; set; }

        [ForeignKey(typeof(Role))]
        public int id_role { get; set; }

        public override string ToString()
        {
            return prenom + " " + nom;
        }
    }
}

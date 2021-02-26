using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZumbaSoft.Model
{
    public class FicheDePaye
    {
        [PrimaryKey, AutoIncrement]
        public int id_ficheDePaye { get; set; }

        public string mois { get; set; }

        public double salaire_brut { get; set; }

        public double charges_patronales { get; set; }

        public double charges_salariales{get; set;}

        public double imposable { get; set; }

        //Association Utilisateur
        [OneToOne]
        public Utilisateur utilisateur { get; set; }

        [ForeignKey(typeof(Utilisateur))]
        public int id_utilisateur { get; set; }

}
}

using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZumbaSoft.Model
{
    public class Personne
    {
        [PrimaryKey, AutoIncrement]
        public int id_personne { get; set; }

        [NotNull]
        public string prenom { get; set; }

        [NotNull]
        public string nom { get; set; }

        public string telephone { get; set; }

        public string email { get; set; }

        public DateTime date_naissance { get; set; }

        public EnumCivilite civilite {get; set;}

        public EnumStatus status {get;set;}

        //Association Adresse
        [ForeignKey(typeof(Adresse))]
        public int id_adresse { get; set; }

        [OneToOne]
        public Adresse adresse { get; set; }
    }
}

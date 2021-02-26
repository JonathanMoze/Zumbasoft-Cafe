using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZumbaSoft.Model
{
    public class Disponibilite
    {
        [PrimaryKey, AutoIncrement]
        public int id_dispo { get; set; }

        public DateTime date_debut { get; set; }

        public DateTime date_fin { get; set; }

        public EnumDispo dispo { get; set; }

        //Association Utilisateur
        [OneToMany]
        List<Utilisateur> utilisateurs { get; set; }
    }
}

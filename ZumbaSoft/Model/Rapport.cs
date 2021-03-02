using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZumbaSoft.Model
{
    public class Rapport
    {
        [PrimaryKey, AutoIncrement]
        public int id_rapport { get; set; }

        [NotNull]
        public string texte { get; set; }

        public DateTime date { get; set; }

        //Association Magasin
        [ForeignKey(typeof(Magasin))]
        public int id_magasin { get; set; }

        [OneToOne]
        public Magasin magasin { get; set; }

        public override string ToString()
        {
            return texte.Substring(0, 10).Insert(10, "...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ZumbaSoft.Model
{
    public class Genre
    {
        [PrimaryKey, AutoIncrement]
        public int id_genre { get; set; }

        public string intitule { get; set; }

        //Association Produit
        [OneToMany]
        public List<Produit> produits { get; set; }
    }
}

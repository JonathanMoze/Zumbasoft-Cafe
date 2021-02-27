using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZumbaSoft.Model
{
    public class Adresse
    {
        [PrimaryKey, AutoIncrement]
        public int id_adresse { get; set; }

        [NotNull]
        public string adresse { get; set; }

        [NotNull]
        public string code_postal { get; set; }

        [NotNull]
        public string ville { get; set; }

        public string complement { get; set; }

    }
}

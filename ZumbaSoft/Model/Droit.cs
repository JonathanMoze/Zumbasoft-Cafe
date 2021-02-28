using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZumbaSoft.Model
{
    public class Droit
    {
        [PrimaryKey, AutoIncrement]
        public int id_droit { get; set; }

        public string intitule { get; set; }

        [OneToMany]
        public List<Role> roles { get; set; }

        [ForeignKey(typeof(Role))]
        public int id_roles { get; set; }
    }
}

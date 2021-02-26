using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZumbaSoft.Model
{
    public class Role
    {

        [PrimaryKey, AutoIncrement]
        public int id_role { get; set; }

        public string nom { get; set; }

        //Association Droit
        [OneToMany]
        public List<Droit> droits { get; set; }

    }
}

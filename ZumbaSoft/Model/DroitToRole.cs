using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace ZumbaSoft.Model
{
    public class DroitToRole
    {
        [ForeignKey(typeof (Droit))]
        public int id_droits { get; set; }

        [ForeignKey(typeof(Role))]
        public int id_roles { get; set; }
    }
}

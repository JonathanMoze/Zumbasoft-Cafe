using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZumbaSoft.Model
{
    public class Client : Personne
    {

        public string tel_domicile { get; set; }

        public string tel_travail { get; set; }

        public string fax { get; set; }

        public string mail { get; set; }

        public string commentaire { get; set; }

        //Association Panier
        [ForeignKey(typeof(Panier))]
        public int  id_panier { get; set; }

        [OneToOne]
        public Panier panier { get; set; }


        public override string ToString()
        {
            return this.nom + " " + this.prenom;
        }
    }
}

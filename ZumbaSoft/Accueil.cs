using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ZumbaSoft.Model;
using ZumbaSoft.Fenetres_Magasin;
using ZumbaSoft.Fenetres_Roles;
using ZumbaSoft.Fenetres_Stock;
using ZumbaSoft.Fenetres_Identification;

namespace ZumbaSoft
{
    public partial class Accueil : Form
    {
        SQLiteConnection db;
        Magasin magasin;

        public Accueil()
        {
            InitializeComponent();
            db = InitializeDataBase();
        }
        public Accueil(SQLiteConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        private SQLiteConnection InitializeDataBase()
        {
            string databasePath = System.IO.Path.GetFullPath("./../../../DataBase.db");
            SQLiteConnection db = new SQLiteConnection(databasePath);
            db.CreateTable<Adresse>();
            db.CreateTable<Genre>();
            db.CreateTable<Produit>();
            db.CreateTable<Client>();
            db.CreateTable<Commande>();
            db.CreateTable<Disponibilite>();
            db.CreateTable<Droit>();
            db.CreateTable<FicheDePaye>();
            db.CreateTable<Fournisseur>();
            db.CreateTable<Magasin>();
            db.CreateTable<Panier>();
            db.CreateTable<Personne>();
            db.CreateTable<ProduitCommande>();
            db.CreateTable<ProduitEnStock>();
            db.CreateTable<Rapport>();
            db.CreateTable<Role>();
            db.CreateTable<Utilisateur>();
            return db;
        }

        

        private void RoleButton_Click(object sender, EventArgs e)
        {
            Roles r = new Roles(db);
            r.Show();
        }

        private void buttonGestionMag_Click(object sender, EventArgs e)
        {
            AccueilMagasin m = new AccueilMagasin(db);
            this.Visible = false;
            if (m.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        private void buttonID_Click(object sender, EventArgs e)
        {
            Identification i = new Identification(db);
            i.Show();
        }

        private void buttonSeConnecter_Click(object sender, EventArgs e)
        {
            Identification m = new Identification(db);
            this.Visible = false;
            if (m.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        private void buttonGestionStock_Click(object sender, EventArgs e)
        {
            AccueilStock s = new AccueilStock(db, magasin);
            this.Visible = false;
            if (s.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }
    }
}

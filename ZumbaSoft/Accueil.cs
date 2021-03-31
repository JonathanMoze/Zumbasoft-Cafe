using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using ZumbaSoft.Model;
using ZumbaSoft.Fenetres_Magasin;
using ZumbaSoft.Fenetres_Roles;
using ZumbaSoft.Fenetres_Stock;
using ZumbaSoft.Fenetres_Identification;
using ZumbaSoft.Fenetres_Produit;
using ZumbaSoft.Fenetres_Ventes;

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
            initItemsColors();
        }
        public Accueil(SQLiteConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        public void initItemsColors()
        {
            backgroundBlock.BackColor = Color.FromArgb(99, 1, 1, 1);
            buttonGestionMag.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonGestionRoles.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonGestionStock.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonGestionProduits.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonGestionVentes.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAcceptConditions.BackColor = Color.FromArgb(80, 1, 1, 1);

            buttonSeConnecter.BackColor = Color.FromArgb(99, 1, 1, 1);
            quitButton.BackColor = Color.FromArgb(99, 1, 1, 1);

            panelConditions.Visible = false;
            panelConditions.BackColor = Color.FromArgb(80, 1, 1, 1);

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
            this.Visible = false;
            if (r.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
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

        private void buttonSeConnecter_Click(object sender, EventArgs e)
        {
            Identification m = new Identification(db);
            this.Visible = false;
            DialogResult dr = m.ShowDialog();
            if ( dr == DialogResult.OK)
            {
                // TODO
                this.Visible = true;
            }
            if( dr == DialogResult.Cancel)
            {
                //DO NOTHING
                this.Visible = true;
            }
        }

        private void buttonGestionStock_Click(object sender, EventArgs e)
        {
            AccueilStock s = new AccueilStock(db);
            this.Visible = false;
            if (s.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGestionProduits_Click(object sender, EventArgs e)
        {
            AccueilProduits p = new AccueilProduits(db);
            this.Visible = false;
            if (p.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        private void buttonGestionStock_Click_1(object sender, EventArgs e)
        {
            AccueilStock st = new AccueilStock(db);
            this.Visible = false;
            if (st.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        private void buttonAcceptConditions_Click(object sender, EventArgs e)
        {
            panelConditions.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (panelConditions.Visible)
            {
                panelConditions.Visible = false;
            } else
            {
                panelConditions.Visible = true;
            }
        }

        private void buttonGestionVentes_Click(object sender, EventArgs e)
        {
            AccueilVente ve = new AccueilVente(db, magasin);
            this.Visible = false;
            if (ve.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }
    }
}

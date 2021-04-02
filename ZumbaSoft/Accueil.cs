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
        public SQLiteConnection db;
        public Utilisateur uConnected;//utilisateur courant connecté. Cette ligne est là uniquement pour indiquer la nécessité de l'attribut (à modifier pour qu'il ne soit plus static).
        public Magasin magasin;


        public Accueil(SQLiteConnection database, Magasin mag)
        {
            InitializeComponent();
            db = database;
            magasin = mag;
            initItemsColors();
        }


        public Accueil()
        {
            InitializeComponent();
            db = InitializeDataBase();
            magasin = null;
            initItemsColors();
        }

        public void initItemsColors()
        {
            backgroundBlock.BackColor = Color.FromArgb(99, 1, 1, 1);
            buttonGestionMag.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonGestionRoles.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonGestionStock.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonGestionProduits.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonGestionVentes.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonGestionClients.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAcceptConditions.BackColor = Color.FromArgb(80, 1, 1, 1);

            buttonSeConnecter.BackColor = Color.FromArgb(99, 1, 1, 1);
            quitButton.BackColor = Color.FromArgb(99, 1, 1, 1);

            panelConditions.Visible = false;
            panelConditions.BackColor = Color.FromArgb(80, 1, 1, 1);

        }

        public SQLiteConnection InitializeDataBase()
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
            db.CreateTable<ProduitToCommande>();
            db.CreateTable<ProduitEnStock>();
            db.CreateTable<Rapport>();
            db.CreateTable<Role>();
            db.CreateTable<Utilisateur>();
            db.CreateTable<DroitToRole>();
            return db;
        }

        

        public void RoleButton_Click(object sender, EventArgs e)
        {
            Roles r = new Roles(db, uConnected);
            this.Visible = false;
            if (r.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        public void buttonGestionMag_Click(object sender, EventArgs e)
        {
            AccueilMagasin m = new AccueilMagasin(db, uConnected);
            this.Visible = false;
            if (m.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        public void buttonSeConnecter_Click(object sender, EventArgs e)
        {
            Identification m = new Identification(db);
            this.Visible = false;
            DialogResult dr = m.ShowDialog();
            if ( dr == DialogResult.OK)
            {
                uConnected = m.uConnecte;
                this.Visible = true;
            }
            if( dr == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        public void buttonGestionStock_Click(object sender, EventArgs e)
        {
            AccueilStock s = new AccueilStock(db, uConnected);
            this.Visible = false;
            if (s.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        public void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void buttonGestionProduits_Click(object sender, EventArgs e)
        {
            AccueilProduits p = new AccueilProduits(db, uConnected);
            this.Visible = false;
            if (p.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        public void buttonGestionStock_Click_1(object sender, EventArgs e)
        {
            AccueilStock st = new AccueilStock(db, uConnected);
            this.Visible = false;
            if (st.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        public void buttonAcceptConditions_Click(object sender, EventArgs e)
        {
            panelConditions.Visible = false;
        }

        public void label3_Click(object sender, EventArgs e)
        {
            if (panelConditions.Visible)
            {
                panelConditions.Visible = false;
            } else
            {
                panelConditions.Visible = true;
            }
        }

        public void buttonGestionVentes_Click(object sender, EventArgs e)
        {
            AccueilVente ve = new AccueilVente(db, magasin, uConnected);
            this.Visible = false;
            if (ve.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        public void Accueil_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonGestionClients_Click(object sender, EventArgs e)
        {
            AccueilClient c = new AccueilClient(db);
            this.Visible = false;
            if (c.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }
    }
}

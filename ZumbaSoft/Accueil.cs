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

namespace ZumbaSoft
{
    public partial class Accueil : Form
    {
        SQLiteConnection db;
        Magasin magasin;

        /// <summary>
        /// Constructeur d'un nouvel accueil lorsqu'il n'y a pas de conection à la BD.
        /// Celle-ci est donc instanciée manuellement.
        /// </summary>
        public Accueil()
        {
            InitializeComponent();
            db = InitializeDataBase();
            initItemsColors();
        }

        /// <summary>
        /// Constructeur d'un nouvel accueil pour une connexion déjà existante à la base de données.
        /// </summary>
        /// <param name="db">La connection actuelle.</param>
        public Accueil(SQLiteConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        /// <summary>
        /// Méthode pour initialiser les couleurs de chaque élément de la fenêtre d'accueil.
        /// Elle n'est destinée à être appelée qu'en interne au sein du constructeur.
        /// </summary>
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

        /// <summary>
        /// Méthode pour initialiser une connection à la base de données embarquée de l'application.
        /// </summary>
        /// <returns>La connexion, ensuite transmise dans toute l'application pour son fonctionnement.</returns>
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

        
        /// <summary>
        /// Gestionnaire de l'évènement : clic sur le bouton "gérer les rôles".
        /// Cette méthode est aussi utilisée pour déployer le formulaire des rôles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoleButton_Click(object sender, EventArgs e)
        {
            Roles r = new Roles(db);
            this.Visible = false;
            if (r.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        /// <summary>
        /// Méthode permettant de déployer l'écran de gestion des magasins.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGestionMag_Click(object sender, EventArgs e)
        {
            AccueilMagasin m = new AccueilMagasin(db);
            this.Visible = false;
            if (m.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        /// <summary>
        /// Méthode pour déployer le formulaire de connection.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Méthode d'accès aux formulaires de gestion des stocks de l'entreprise.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGestionStock_Click(object sender, EventArgs e)
        {
            AccueilStock s = new AccueilStock(db, magasin);
            this.Visible = false;
            if (s.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        /// <summary>
        /// Méthode de meurtre propre de l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Méthode pour accéder au panel de gestion des produits par magasin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGestionProduits_Click(object sender, EventArgs e)
        {
            AccueilProduits p = new AccueilProduits(db);
            this.Visible = false;
            if (p.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        /// <summary>
        /// Méthode pour déployer le menu de gestion des stocks.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGestionStock_Click_1(object sender, EventArgs e)
        {
            AccueilStock st = new AccueilStock(db, magasin);
            this.Visible = false;
            if (st.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }

        /// <summary>
        /// Boutons pour accepter les conditions d'utilisation du logiciel.
        /// Une fois celles-ci acceptées, le panel devient invisible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAcceptConditions_Click(object sender, EventArgs e)
        {
            panelConditions.Visible = false;
        }

        /// <summary>
        /// Méthode pour déployer le panel des conditions d'utilisation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
    }
}

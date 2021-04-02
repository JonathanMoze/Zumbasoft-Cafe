using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;

namespace ZumbaSoft
{
    public partial class ConnexionMagasin : Form
    {
        SQLiteConnection db;
        Magasin magasin;

        public ConnexionMagasin()
        {
            InitializeComponent();
            db = InitializeDataBase();
            initItemsColors();
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
            db.CreateTable<DroitToRole>();
            return db;
        }

        public void initItemsColors()
        {
            backgroundBlock.BackColor = Color.FromArgb(99, 1, 1, 1);

            buttonSeConnecter.BackColor = Color.FromArgb(99, 1, 1, 1);
            buttonAdmin.BackColor = Color.FromArgb(99, 1, 1, 1);
            quitButton.BackColor = Color.FromArgb(99, 1, 1, 1);


        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            if (iddentificationMagasin())
            {
                this.Visible = false;
                Accueil a = new Accueil(db, magasin);
                if (a.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private bool iddentificationMagasin()
        {
            Magasin mag = db.GetAllWithChildren<Magasin>().Find(m => m.adresse.ville.Equals(textBoxVille.Text));
            if (check_login(mag))
            {
                if(mag.mot_de_passe == textBoxMdp.Text)
                {
                    magasin = mag;
                    return true;
                }
                else
                {
                    labelErreur.Visible = true;
                    return false;
                }
            }
            else
            {
                labelErreur.Visible = true;
                return false;
            }
        }


        private bool check_login(Magasin mag)
        {
            if (mag != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void buttonConnexionAdmin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Accueil a = new Accueil(db, null);
            if (a.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

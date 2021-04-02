using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using ZumbaSoft.Model;
using SQLiteNetExtensions;
using SQLiteNetExtensions.Extensions;
using System.Diagnostics;
using System.IO;

namespace ZumbaSoft.Fenetres_Produit
{
    public partial class AccueilProduits : Form
    {
        SQLiteConnection DB;

        /// <summary>
        /// Constructeur d'un nouvel AccueilProduits.
        /// </summary>
        /// <param name="db">La connection actuelle à la base de données.</param>
        public AccueilProduits(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initListProduits();
            initItemsColors();
            checkDB();
        }

        /// <summary>
        /// Méthode pour initialiser la liste des produits à manipuler en RAM.
        /// </summary>
        public void initListProduits()
        {
            listProduits.Items.Clear();

            int nb = 0;
            foreach (Produit p in DB.GetAllWithChildren<Produit>())
            {
                listProduits.Items.Add(p);
                nb++;
            }

            if (nb > 0)
            {
                erreurListevide.Visible = false;
            }
            else
            {
                erreurListevide.Visible = true;
            }
        }

        /// <summary>
        /// Méthode pour initialiser les couleurs du formulaire.
        /// </summary>
        public void initItemsColors()
        {
            backgroundBlock.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonAjouterProduit.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonModifierProduit.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonSupprimerProduit.BackColor = Color.FromArgb(50, 12, 12, 12);
            erreurListevide.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel5.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel4.BackColor = Color.FromArgb(80, 12, 12, 12);
            panelERROR.BackColor = Color.FromArgb(100, 120, 1, 1);
            buttonModifierProduit.Enabled = false;
            buttonSupprimerProduit.Enabled = false;
        }

        /// <summary>
        /// Méthode de vérification de l'accès à la base de données.
        /// Dans le cas où l'accès n'ests pas fonctionnel, un message d'erreur est renvoyé.
        /// </summary>
        public void checkDB()
        {
            var database = new FileInfo("DataBase.db");
            if (!database.Exists)
            {
                msgBDstatusERROR.Visible = true;
                msgBDstatusOK.Visible = false;

                dbERROR.Visible = true;
                dbOK.Visible = false;

                var t = new Timer();
                t.Interval = 2000; // Durée de l'attente avant l'affichage du message
                t.Tick += (s, e) =>
                {
                    panelERROR.Visible = true;
                    t.Stop();
                };
                t.Start();

                var t2 = new Timer();
                t2.Interval = 8000; // Durée de l'affichage du message
                t2.Tick += (s, e) =>
                {
                    panelERROR.Visible = false;
                    t2.Stop();
                };
                t2.Start();

            }
            else
            {
                msgBDstatusERROR.Visible = false;
                msgBDstatusOK.Visible = true;

                dbERROR.Visible = false;
                dbOK.Visible = true;
            }
        }

        /// <summary>
        /// Méthode pour supprimer un produit de la BD.
        /// Attention, cette méthode demande une confirmation à l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimerProduit_Click(object sender, EventArgs e)
        {
            if (listProduits.SelectedItem != null)
            {
                var p = (Produit)listProduits.SelectedItem;
                SupprimerProduit supprimer = new SupprimerProduit(p, DB);
                if (supprimer.ShowDialog() == DialogResult.OK)
                {
                    listProduits.Items.Remove(p);
                }
            }
        }

        /// <summary>
        /// Méthode pour modifier un produit dans la BD.
        /// Cette méthode passe par une boîte de dialogue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifierProduit_Click(object sender, EventArgs e)
        {
            if (listProduits.SelectedItem != null)
            {
                Produit p = (Produit)listProduits.SelectedItem;
                ModifierProduit paramétrer = new ModifierProduit(p, DB);
                if (paramétrer.ShowDialog() == DialogResult.OK)
                {
                    initListProduits();
                }
            }
        }

        /// <summary>
        /// Méthode pour ajouter un produit dans la BD.
        /// Cette méthode passe par une boîte de dialogue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouterProduit_Click(object sender, EventArgs e)
        {
            AjouterProduit ajouterproduit = new AjouterProduit(DB);
            if (ajouterproduit.ShowDialog() == DialogResult.OK)
            {
                initListProduits();
            }
        }

        /// <summary>
        /// Méthode pour revenir au formuulaire précédent une fois que les manipulations sont finies.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goBackButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Méthode pour générer un mail de rapport de bug aux administrateurs.
        /// Le mail généré est automatique, évitant les rapports inutiles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonContactAdmin_Click(object sender, EventArgs e)
        {
            Process OpenMailClient = new Process();
            DateTime date = DateTime.Now;
            String emailAddress = "mrkafeine@gmail.com";
            String subject = "Rapport d'erreur - BD introuvable";
            String body = "---------------------------------%0a%0aRapport d'erreur  OUATELSE : le " + date.ToString("MM/dd/yyyy") + " à " + date.ToString("HH:mm") + " : ERREUR 01 - Impossible d'accéder à la base de données : le fichier correspondant à la base de données (Database.db) est introuvable.%0a%0aRépondez directement à ce mail pour échanger avec le magasin concerné.%0a%0a---------------------------------%0a%0aEntrez des détails ici (que s'est-il passé avant l'apparition de ce problème, d'éventuelles remarques...) :";

            string filename = "mailto:" + emailAddress + "?subject=" + subject + "&body=" + body;
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = filename;
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.RedirectStandardOutput = false;
            myProcess.Start();
        }

        /// <summary>
        /// Méthode pour retourner au menu principal de l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackHome_Click(object sender, EventArgs e)
        {
            panelERROR.Visible = false;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Méthode pour gérer le click sur un message d'erreur de la BD.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msgBDstatusERROR_Click(object sender, EventArgs e)
        {
            if (!panelERROR.Visible)
            {
                panelERROR.Visible = true;
                var t = new Timer();
                t.Interval = 8000; // Durée de l'affichage du message
                t.Tick += (s, e) =>
                {
                    panelERROR.Visible = false;
                    t.Stop();
                };
                t.Start();
            }

        }

        /// <summary>
        /// Méthode pour gérer le changement de produit sélectionné par l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledInfoField();
        }

        /// <summary>
        /// Méthode pour activer les boutons de sélection d'un produit sélectionné.
        /// </summary>
        private void EnabledInfoField()
        {
            buttonModifierProduit.Enabled = true;
            buttonSupprimerProduit.Enabled = true;
        }
    }
}

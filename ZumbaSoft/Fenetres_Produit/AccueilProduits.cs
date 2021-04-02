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
        Utilisateur user;
        Magasin magasin;
        public AccueilProduits(SQLiteConnection db, Magasin mag, Utilisateur uConnected)
        {
            InitializeComponent();
            DB = db;
            user = uConnected;
            magasin = mag;
            initListProduits();
            initItemsColors();
            checkDB();
            checkMagasinAndUser();
        }

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

        public void checkDB()
        {
            var database = new FileInfo("../../../DataBase.db");
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

        public void checkMagasinAndUser()
        {
            if (magasin != null)
            {
                magasinSelectionne.Text = Convert.ToString(magasin);
            }

            if (user != null)
            {
                userSelectionne.Text = Convert.ToString(user);
                anonymousIcon.Visible = false;
                userIcon.Visible = true;
            }
            else
            {
                anonymousIcon.Visible = true;
                userIcon.Visible = false;
            }
        }

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

        private void buttonModifierProduit_Click(object sender, EventArgs e)
        {
            if (listProduits.SelectedItem != null)
            {
                Produit p = (Produit)listProduits.SelectedItem;
                p = DB.GetWithChildren<Produit>(p.id_produit);
                ModifierProduit paramétrer = new ModifierProduit(p, DB);
                if (paramétrer.ShowDialog() == DialogResult.OK)
                {
                    initListProduits();
                }
            }
        }

        private void buttonAjouterProduit_Click(object sender, EventArgs e)
        {
            AjouterProduit ajouterproduit = new AjouterProduit(DB);
            if (ajouterproduit.ShowDialog() == DialogResult.OK)
            {
                initListProduits();
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

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

        private void buttonBackHome_Click(object sender, EventArgs e)
        {
            panelERROR.Visible = false;
            DialogResult = DialogResult.OK;
            this.Close();
        }

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

        private void listProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledInfoField();
        }

        private void EnabledInfoField()
        {
            buttonModifierProduit.Enabled = true;
            buttonSupprimerProduit.Enabled = true;
        }

        private void AccueilProduits_FormClosed(object sender, FormClosedEventArgs e)
        {
            panelERROR.Visible = false;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

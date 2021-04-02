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
using System.IO;
using System.Diagnostics;

namespace ZumbaSoft.Fenetres_Ventes
{
    public partial class AccueilClient : Form
    {
        SQLiteConnection DB;
        Magasin magasin;
        Utilisateur user;

        public AccueilClient(SQLiteConnection db, Magasin mag, Utilisateur uConnected)
        {
            InitializeComponent();
            DB = db;
            user = uConnected;
            magasin = mag;
            initListClient();
            initItemsColors();
            checkDB();
            checkMagasinAndUser();
        }

        public void initListClient()
        {
            listClient.Items.Clear();

            int nb = 0;
            foreach (Client c in DB.GetAllWithChildren<Client>())
            {
                listClient.Items.Add(c);
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
            buttonAjouterClient.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonModifierClient.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonSupprimerClient.BackColor = Color.FromArgb(50, 12, 12, 12);
            erreurListevide.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel2.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel4.BackColor = Color.FromArgb(80, 12, 12, 12);
            panelERROR.BackColor = Color.FromArgb(100, 120, 1, 1);

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

        public void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            NouveauClient newClient = new NouveauClient(DB);
            if (newClient.ShowDialog() == DialogResult.OK)
            {
                initListClient();
            }
        }

        public void buttonModifierClient_Click(object sender, EventArgs e)
        {
            if (listClient.SelectedItem != null)
            {
                Client c = (Client)listClient.SelectedItem;
                ModifierClient paramétrer = new ModifierClient(c, DB);
                if (paramétrer.ShowDialog() == DialogResult.OK)
                {
                    initListClient();
                }
            }
        }

        public void buttonSupprimerClient_Click(object sender, EventArgs e)
        {
            var c = (Client)listClient.SelectedItem;
            SupprimerClient supprimer = new SupprimerClient(c, DB);
            if (supprimer.ShowDialog() == DialogResult.OK)
            {
                listClient.Items.Remove(c);
            }
        }

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AccueilClient_FormClosed(object sender, FormClosedEventArgs e)
        {
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
    }
}

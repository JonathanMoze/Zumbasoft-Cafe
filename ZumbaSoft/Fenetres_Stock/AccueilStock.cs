using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SQLite;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Stock
{
    public partial class AccueilStock : Form
    {
        Magasin magasin;
        SQLiteConnection DB;

        public AccueilStock(SQLiteConnection db, Magasin m)
        {
            InitializeComponent();
            DB = db;
            magasin = m;
            initListStock(magasin);
            initItemsColors();
            checkDB();
        }
        public void initListStock(Magasin m)
        {
            List<ProduitEnStock> stock = DB.Table<ProduitEnStock>().Where(ps => ps.magasin == m).ToList();
            if(stock.Count >= 1)
            {
                erreurListeVide.Visible = false;
                foreach (ProduitEnStock ps in stock)
                {
                    listStock.Items.Add(ps);
                }
            }
            else
            {
                erreurListeVide.Visible = true;
            }
        }

        public void initItemsColors()
        {
            backgroundBlock.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonAjouterStock.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonModifierStock.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonSuppStock.BackColor = Color.FromArgb(50, 12, 12, 12);
            panelERROR.BackColor = Color.FromArgb(100, 120, 1, 1);
            panel5.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel4.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonModifierStock.Enabled = false;
            buttonSuppStock.Enabled = false;
        }

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

        private void buttonAjouterStock_Click(object sender, EventArgs e)
        {
            AjouterStock ajouterStock = new AjouterStock(DB, magasin);
            if (ajouterStock.ShowDialog() == DialogResult.OK)
            {
                var s = ajouterStock.produitEnStock;
                listStock.Items.Add(s);
                listStock.SelectedItem = s;
            }
        }

        private void buttonModifierStock_Click(object sender, EventArgs e)
        {
            if (listStock.SelectedItem != null)
            {
                ProduitEnStock ps = (ProduitEnStock)listStock.SelectedItem;
                ModifierStock modifStock = new ModifierStock(ps, DB);
                if (modifStock.ShowDialog() == DialogResult.OK)
                {
                    listStock.Refresh();
                }
            }
        }

        private void buttonSuppStock_Click(object sender, EventArgs e)
        {
            var ps = (ProduitEnStock)listStock.SelectedItem;
            SupprimerStock supprimer = new SupprimerStock(ps, DB);
            if (supprimer.ShowDialog() == DialogResult.OK)
            {
                listStock.Items.Remove(ps);
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

    }
}

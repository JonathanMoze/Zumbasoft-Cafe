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
using ZumbaSoft.Fenetres_Magasin;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Roles
{
    public partial class Roles : Form
    {

        SQLiteConnection DB;
        public Roles(SQLiteConnection database)
        {
            InitializeComponent();
            DB = database;
            initListRoles();
            initItemsColors();
            checkDB();
        }

        public void initItemsColors()
        {
            panel1.BackColor = Color.FromArgb(95, 12, 12, 12);
            panel2.BackColor = Color.FromArgb(95, 12, 12, 12);
            panel3.BackColor = Color.FromArgb(95, 12, 12, 12);
            panel4.BackColor = Color.FromArgb(80, 12, 12, 12);
            panelERROR.BackColor = Color.FromArgb(100, 120, 1, 1);

            ajouterRoles.BackColor = Color.FromArgb(80, 12, 12, 12);
            supprimerRole.BackColor = Color.FromArgb(80, 12, 12, 12);
            msgBDstatusOK.ForeColor = Color.FromArgb(80, 235, 235, 235);
            magasinSelectionne.ForeColor = Color.FromArgb(80, 235, 235, 235);
            buttonBackHome.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonContactAdmin.BackColor = Color.FromArgb(80, 12, 12, 12);
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

        public void initListRoles()
        {
            choixRoles.Items.Clear();
            int nb = 0;

            foreach (Role role in DB.GetAllWithChildren<Role>())
            {
                choixRoles.Items.Add(role);
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

        public void ajouterRoles_Click(object sender, EventArgs e)
        {
            if (nomRole.Text != "")
            {
                Role r = new Role();
                r.nom = nomRole.Text;
                r.droits = new List<Droit>();
                DB.InsertWithChildren(r);
                initListRoles();
                nomRole.Text = "";
                erreurAjout.Visible = false;
                confirmationAjout.Visible = true;
            }
            else
            {
                confirmationAjout.Visible = false;
                erreurAjout.Visible = true;
            }
            var t = new Timer();
            t.Interval = 5000; // Durée de l'affichage du message
            t.Tick += (s, e) =>
            {
                confirmationAjout.Visible = false;
                erreurAjout.Visible = false;
                t.Stop();
            };
            t.Start();

        }

        public void supprimerRole_Click(object sender, EventArgs e)
        {
            if (ConfirmationSR.Checked && choixRoles.SelectedItem != null)
            {
                Role r = (Role)choixRoles.SelectedItem;
                DB.Delete(r);
                initListRoles();
                ConfirmationSR.ForeColor = System.Drawing.Color.Black;
            } else
            {
                ConfirmationSR.ForeColor = System.Drawing.Color.Tomato;

            }
        }

        public void goBackButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }


        public void msgBDstatusERROR_Click(object sender, EventArgs e)
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



        public void buttonContactAdmin_Click(object sender, EventArgs e)
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

        public void buttonBackHome_Click(object sender, EventArgs e)
        {
            panelERROR.Visible = false;
            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}

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

        private void ajouterRoles_Click(object sender, EventArgs e)
        {
            if (nomRole.Text != "")
            {
                Role r = new Role();
                r.nom = nomRole.Text;
                r.droits = new List<Droit>();
                DB.Insert(r);
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

        private void supprimerRole_Click(object sender, EventArgs e)
        {
            if (ConfirmationSR.Checked && choixRoles.SelectedItem != null)
            {
                Role r = (Role)choixRoles.SelectedItem;
                DB.Delete(r);
                initListRoles();
                ConfirmationSR.ForeColor = System.Drawing.Color.Black;
            } else
            {
                ConfirmationSR.ForeColor = System.Drawing.Color.Red;

            }
        }

    }
}

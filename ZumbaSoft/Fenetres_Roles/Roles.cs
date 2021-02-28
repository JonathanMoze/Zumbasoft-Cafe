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
            foreach (Role role in DB.GetAllWithChildren<Role>())
            {
                choixRoles.Items.Add(role);
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
            }
            
        }

        private void supprimerRole_Click(object sender, EventArgs e)
        {
            if (ConfirmationSR.Checked && choixRoles.SelectedItem != null)
            {
                Role r = (Role)choixRoles.SelectedItem;
                DB.Delete(r);
                initListRoles();
            }
        }
    }
}

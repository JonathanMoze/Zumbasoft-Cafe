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

namespace ZumbaSoft.Fenetres_Ventes
{
    public partial class AccueilClient : Form
    {
        SQLiteConnection DB;
        Client client;
        
        public AccueilClient(SQLiteConnection db, Client c)
        {
            InitializeComponent();
            DB = db;
            client = c;
            initListClient();
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

        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            NouveauClient newClient = new NouveauClient(DB);
            if (newClient.ShowDialog() == DialogResult.OK)
            {
                initListClient();
            }
        }

        private void buttonModifierClient_Click(object sender, EventArgs e)
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

        private void buttonSupprimerClient_Click(object sender, EventArgs e)
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

    }
}

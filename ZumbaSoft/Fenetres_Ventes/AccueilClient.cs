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
        
        
        public AccueilClient(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initListClient();
            initItemsColors();
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
            buttonAjouterGenre.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonModifierGenre.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonSupprimerGenre.BackColor = Color.FromArgb(50, 12, 12, 12);
            erreurListevide.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel1.BackColor = Color.FromArgb(50, 12, 12, 12);
            panel4.BackColor = Color.FromArgb(80, 12, 12, 12);

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

    }
}

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

namespace ZumbaSoft.Fenetres_Ventes
{
    public partial class SupprimerClient : Form
    {
        Client client;
        SQLiteConnection DB;
        public SupprimerClient(Client c, SQLiteConnection db)
        {
            InitializeComponent();
            this.client = c;
            this.DB = db;
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            DB.Delete(client);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

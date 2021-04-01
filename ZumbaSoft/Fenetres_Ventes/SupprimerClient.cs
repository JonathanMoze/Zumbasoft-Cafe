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
            initItemsColors();
            this.client = c;
            this.DB = db;
        }

        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(90, System.Drawing.Color.Red);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonSupprimer.BackColor = Color.FromArgb(50, 12, 12, 12);

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

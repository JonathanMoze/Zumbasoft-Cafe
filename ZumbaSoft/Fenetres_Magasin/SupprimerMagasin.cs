using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;
using SQLiteNetExtensions.Extensions;
using SQLite;

namespace ZumbaSoft.Fenetres_Magasin
{
    public partial class SupprimerMagasin : Form
    {
        Magasin magasin;
        SQLiteConnection DB;

        public SupprimerMagasin(Magasin magasin, SQLiteConnection db)
        {
            InitializeComponent();
            this.magasin = magasin;
            this.DB = db;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            DB.Delete(magasin);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

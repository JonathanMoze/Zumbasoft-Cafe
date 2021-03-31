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
            initItemsColors();
            this.magasin = magasin;
            this.DB = db;
        }

        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(90, System.Drawing.Color.Red);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonSupprimer.BackColor = Color.FromArgb(50, 12, 12, 12);

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            DB.Delete(magasin,true);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

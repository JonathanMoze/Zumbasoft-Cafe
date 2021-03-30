using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Stock
{
    public partial class SupprimerStock : Form
    {

        SQLiteConnection DB;
        public ProduitEnStock PES;
        public bool allDeleted;

        public SupprimerStock(ProduitEnStock ps, SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            PES = ps;
            barreQtt.Maximum = ps.quantite;
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            deleteQtt();
            DialogResult = DialogResult.OK;
            this.Close();
        }


        private void deleteQtt()
        {
            if(barreQtt.Maximum == barreQtt.Value)
            {
                DB.Delete(PES);
            }
            else
            {
                PES.quantite -= (int)barreQtt.Value;
                DB.UpdateWithChildren(PES);
            }
        }

        private void buttonAnuuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

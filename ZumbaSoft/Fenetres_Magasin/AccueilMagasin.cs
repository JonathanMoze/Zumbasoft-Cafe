using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Magasin
{
    public partial class AccueilMagasin : Form
    {
        SQLiteConnection DB;

        public AccueilMagasin(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initListMagasin();
            
        }

        public void initListMagasin()
        {
            foreach(Magasin m in DB.GetAllWithChildren<Magasin>()){
                listMagasin.Items.Add(m);
            }
        }

        private void boutonSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void boutonModifier_Click(object sender, EventArgs e)
        {
            if(listMagasin.SelectedItem != null)
            {
                Magasin m = (Magasin)listMagasin.SelectedItem;
                ParamétrerMagasin paramétrer = new ParamétrerMagasin(m,DB);
                if (paramétrer.ShowDialog() == DialogResult.OK)
                {
                    listMagasin.Refresh();
                }
            }
        }

        private void boutonAjouter_Click(object sender, EventArgs e)
        {
            AjouterMagasin ajouterMagasin = new AjouterMagasin(DB);
            if(ajouterMagasin.ShowDialog() == DialogResult.OK)
            {
                var mag = ajouterMagasin.magasin;
                listMagasin.Items.Add(mag);
                listMagasin.SelectedItem = mag;
            }
        }
    }
}

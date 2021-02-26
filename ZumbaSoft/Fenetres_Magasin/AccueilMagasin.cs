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

        public AccueilMagasin(SQLiteConnection db)
        {
            InitializeComponent();
            for(int i=0; i < 5; i++)
            {
                db.Insert(new Magasin() { mot_de_passe = i.ToString() });
            }
            initListMagasin(db);
            
        }

        public void initListMagasin(SQLiteConnection db)
        {
            foreach(Magasin m in db.GetAllWithChildren<Magasin>()){
                listMagasin.Items.Add(m);
            }
        }

        private void boutonSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void boutonModifier_Click(object sender, EventArgs e)
        {

        }

        private void boutonAjouter_Click(object sender, EventArgs e)
        {

        }
    }
}

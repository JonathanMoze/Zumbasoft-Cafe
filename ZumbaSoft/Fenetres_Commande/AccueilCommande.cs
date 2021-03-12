using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;

namespace ZumbaSoft.Fenetres_Commande
{
    public partial class AccueilCommande : Form
    {
        SQLiteConnection DB;

        public AccueilCommande(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
        }

        private void buttonNewCmd_Click(object sender, EventArgs e)
        {
            NouvelleCommandes nCmd = new NouvelleCommandes(DB);
            if(nCmd.ShowDialog() == DialogResult.OK)
            {
                //TODO
            }
        }
    }
}

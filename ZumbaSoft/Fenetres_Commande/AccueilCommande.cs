using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZumbaSoft.Fenetres_Commande
{
    public partial class AccueilCommande : Form
    {
        public AccueilCommande()
        {
            InitializeComponent();
        }

        private void buttonNewCmd_Click(object sender, EventArgs e)
        {
            NouvelleCommandes nCmd = new NouvelleCommandes();
            if(nCmd.ShowDialog() == DialogResult.OK)
            {
                //TODO
            }
        }
    }
}

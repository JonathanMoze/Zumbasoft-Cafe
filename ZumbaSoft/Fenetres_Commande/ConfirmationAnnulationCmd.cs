using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZumbaSoft.Fenetres_Commande
{
    public partial class ConfirmationAnnulationCmd : Form
    {
        public ConfirmationAnnulationCmd()
        {
            InitializeComponent();
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
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

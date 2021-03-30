using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZumbaSoft.Fenetres_Ventes
{
    public partial class ConfirmationAnnulerPanier : Form
    {
        public ConfirmationAnnulerPanier()
        {
            InitializeComponent();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
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

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
    public partial class ParamétrerMagasin : Form
    {
        public ParamétrerMagasin(Magasin magasin)
        {
            InitializeComponent();
            InitInfosField(magasin);

        }
        public void InitInfosField(Magasin magasin)
        {
            labelNom.Text = magasin.mot_de_passe;
        }

        public bool isFieldValid()
        {
            if (true)
            {
            }
            return true;
        }

        private void buttonOKParamMag_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnnulParamMag_Click(object sender, EventArgs e)
        {

        }

        private void ParamétrerMagasin_Load(object sender, EventArgs e)
        {

        }

    }
}

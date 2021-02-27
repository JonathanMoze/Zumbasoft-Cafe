using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;
using SQLite;

namespace ZumbaSoft.Fenetres_Magasin
{
    public partial class AjouterMagasin : Form
    {
        SQLiteConnection DB;
        Magasin mag;
        public AjouterMagasin(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
        }

        public Magasin initObjectMagasin()
        {
            Magasin magasin = new Magasin();
            magasin.mot_de_passe = textBoxMdp.Text;
            return magasin;
        }

        public bool fieldsIsValid()
        {
            if (textBoxMdp.Text != null)
            {
                if (textBoxMdp.Text.Length <= 8 && textBoxMdp.Text.Length >= 32)
                {
                    labelErreurMdp.Visible = true;
                    return false;
                }
            }
            if (textBoxAdr.Text == null)
            {
                labelErreurAdr.Visible = true;
                return false;
            }
            return true;
        }

        private void buttonOKmdp_Click(object sender, EventArgs e)
        {
            Magasin m = initObjectMagasin();
            DB.Insert(m);
        }

        private void buttonAdr_Click(object sender, EventArgs e)
        {
            NouvelleAdresse newAdr = new NouvelleAdresse(DB);
            if (newAdr.ShowDialog() == DialogResult.OK)
            {
                mag.adresse = newAdr.adr;
                textBoxAdr.Text = newAdr.adr.adresse;
            }
        }

        private void textBoxMdp_TextChanged(object sender, EventArgs e)
        {
            if (labelErreurMdp.Visible == true)
            {
                labelErreurMdp.Visible = false;
            }
        }

        private void textBoxAdr_TextChanged(object sender, EventArgs e)
        {
            if (labelErreurAdr.Visible == true)
            {
                labelErreurAdr.Visible = false;
            }
        }
    }
}

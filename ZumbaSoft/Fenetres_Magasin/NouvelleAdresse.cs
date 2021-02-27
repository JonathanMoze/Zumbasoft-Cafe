using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Magasin
{
    public partial class NouvelleAdresse : Form
    {
        SQLiteConnection DB;
        public Adresse adr;
        public NouvelleAdresse(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
        }

        public Adresse initObjectAdresse()
        {
            Adresse adresse = new Adresse();
            adresse.adresse = textBoxAdresse.Text;
            adresse.code_postal = textBoxCodePostal.Text;
            adresse.complement = textBoxComplement.Text;
            adresse.ville = textBoxVille.Text;
            return adresse;
        }

        public bool fieldIsValid()
        {
            if (textBoxAdresse.Text == "")
            {
                labelErreurAdr.Visible = true;
                return false;
            }
            if (textBoxCodePostal.Text == "")
            {
                labelErreurCP.Visible = true;
                return false;
            }
            if (textBoxVille.Text == "")
            {
                labelErreurVille.Visible = true;
                return false;
            }
            return true;
        }

        private void buttonNewAdresse_Click(object sender, EventArgs e)
        {
            if (fieldIsValid())
            {
                Adresse adresse = initObjectAdresse();
                DB.Insert(adresse);
                adr = adresse;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonAnnulerNewAdr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxAdresse_TextChanged(object sender, EventArgs e)
        {
            if (labelErreurAdr.Visible == true)
            {
                labelErreurAdr.Visible = false;
            }
        }

        private void textBoxCodePostal_TextChanged(object sender, EventArgs e)
        {
            if (labelErreurCP.Visible == true)
            {
                labelErreurCP.Visible = false;
            }
        }

        private void textBoxVille_TextChanged(object sender, EventArgs e)
        {
            if (labelErreurVille.Visible == true)
            {
                labelErreurVille.Visible = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;
using SQLite;
using SQLiteNetExtensions;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Magasin
{
    public partial class AjouterMagasin : Form
    {
        private SQLiteConnection DB;
        public Adresse adresse;
        public Magasin magasin;
        public AjouterMagasin(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initItemsColors();
        }

        public Magasin initObjectMagasin()
        {
            magasin = new Magasin();
            magasin.mot_de_passe = textBoxMdp.Text;
            magasin.adresse = adresse;
            magasin.commandes = new List<Commande>();
            magasin.rapports = new List<Rapport>();
            magasin.stock = new List<ProduitEnStock>();
            magasin.utilisateurs = new List<Utilisateur>();
            return magasin;
        }

        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(50, 12, 12, 12);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonAdr.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonOKmdp.BackColor = Color.FromArgb(50, 12, 12, 12);

        }

        public bool fieldsIsValid()
        {
            if (textBoxMdp.Text == "")
            {
                labelErreurMdp.Visible = true;
                return false;
            }
            else
            {
                if (textBoxMdp.Text.Length <= 8 || textBoxMdp.Text.Length >= 32)
                {
                    labelErreurMdp.Visible = true;
                    return false;
                }
            }
            if (textBoxAdr.Text == "")
            {
                labelErreurAdr.Visible = true;
                return false;
            }
            return true;
        }

        private void buttonOKmdp_Click(object sender, EventArgs e)
        {
            if (fieldsIsValid())
            {
                magasin = initObjectMagasin();
                DB.InsertWithChildren(magasin);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonAdr_Click(object sender, EventArgs e)
        {
            NouvelleAdresse newAdr = new NouvelleAdresse(DB);
            if (newAdr.ShowDialog() == DialogResult.OK)
            {
                adresse = newAdr.adr;
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

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }



    }
}

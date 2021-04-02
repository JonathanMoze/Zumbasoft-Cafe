using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using SQLiteNetExtensions;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;
using ZumbaSoft.Fenetres_Magasin;

namespace ZumbaSoft.Fenetres_Produit
{
    
    public partial class AjouterFournisseur : Form
    {
        private SQLiteConnection DB;
        public Adresse adresse;
        public Fournisseur fournisseur;
        public AjouterFournisseur(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initItemsColors();
        }
        public Fournisseur initObjectFournisseur()
        {
            fournisseur = new Fournisseur();
            fournisseur.nom = textBoxNom.Text;
            fournisseur.mail = textBoxMailFourni.Text;
            fournisseur.etat_contrat = textBoxEtatFourni.Text;
            fournisseur.telephone = textBoxTelFourni.Text;
            fournisseur.adresse = adresse;
            fournisseur.commandes = new List<Commande>();
            fournisseur.produits = new List<Produit>();
            return fournisseur;
        }

        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(50, 12, 12, 12);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonAdr.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonOK.BackColor = Color.FromArgb(50, 12, 12, 12);
        }

        public bool fieldsIsValid()
        {
            if (textBoxAdr.Text == "")
            {
                labelErreurAdr.Visible = true;
                return false;
            }
            return true;
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

        private void textBoxAdr_TextChanged(object sender, EventArgs e)
        {
            if (labelErreurAdr.Visible == true)
            {
                labelErreurAdr.Visible = false;
            }
        }

        public void buttonOK_Click(object sender, EventArgs e)
        {
            if (fieldsIsValid())
            {
                fournisseur = initObjectFournisseur();
                DB.InsertWithChildren(fournisseur);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}

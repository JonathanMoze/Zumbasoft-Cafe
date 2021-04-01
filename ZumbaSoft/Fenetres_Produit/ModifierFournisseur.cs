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
using ZumbaSoft.Fenetres_Magasin;

namespace ZumbaSoft.Fenetres_Produit
{
    public partial class ModifierFournisseur : Form
    {
        Fournisseur fournisseur;
        SQLiteConnection DB;
        public Adresse adresse;
        AccueilFournisseur af;

        public ModifierFournisseur(AccueilFournisseur af, Fournisseur f, SQLiteConnection db)
        {
            InitializeComponent();
            this.fournisseur = f;
            this.DB = db;
            this.af = af;
            InitInfoField();
            initItemsColors();
        }

        public void InitInfoField()
        {
            textBoxNom.PlaceholderText = fournisseur.nom;
            textBoxNewTel.PlaceholderText = fournisseur.telephone;
            textBoxEmail.PlaceholderText = fournisseur.mail;
            textBoxContrat.PlaceholderText = fournisseur.etat_contrat;

            

            if (fournisseur.produits.Count != 0)
            {
                foreach (Produit p in fournisseur.produits)
                {
                    listViewProduits.Items.Add(p.ToString());
                }
            }
            else { 
                listViewProduits.Items.Add("Aucun");
            }

            if (fournisseur.commandes.Count != 0)
            {
                foreach (Commande c in fournisseur.commandes)
                {
                    listViewCommandes.Items.Add(c.ToString());
                }
            }
            else {
                listViewCommandes.Items.Add("Aucun");
            }
        }

        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(50, 12, 12, 12);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonAdr.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonOK.BackColor = Color.FromArgb(50, 12, 12, 12);
        }

        private void buttonOKParamMag_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "")
            {
                textBoxNom.PlaceholderText = textBoxNom.Text;
                textBoxNom.Text = "";
            }

            if (textBoxNewTel.Text != "")
            {
                textBoxNewTel.PlaceholderText = textBoxNewTel.Text;
                textBoxNewTel.Text = "";
            }

            if (textBoxEmail.Text != "")
            {
                textBoxEmail.PlaceholderText = textBoxEmail.Text;
                textBoxEmail.Text = "";
            }

            if (textBoxContrat.Text != "")
            {
                textBoxContrat.PlaceholderText = textBoxContrat.Text;
                textBoxContrat.Text = "";
            }

            fournisseur.telephone = textBoxNewTel.PlaceholderText;
            fournisseur.nom = textBoxNom.PlaceholderText;
            fournisseur.etat_contrat = textBoxContrat.PlaceholderText;
            fournisseur.mail = textBoxEmail.PlaceholderText;
            DB.Update(fournisseur);
            af.initListFournisseur();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonAnnulParamMag_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
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
    }
}

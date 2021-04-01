using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;
using SQLite;

namespace ZumbaSoft.Fenetres_Produit
{
    public partial class ModifierFournisseur : Form
    {
        Fournisseur fournisseur;
        SQLiteConnection DB;
        AccueilFournisseur af;

        public ModifierFournisseur(AccueilFournisseur af, Fournisseur f, SQLiteConnection db)
        {
            InitializeComponent();
            this.fournisseur = f;
            this.DB = db;
            this.af = af;
            InitInfoField();
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

        public void buttonOKParamMag_Click(object sender, EventArgs e)
        {
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

        private void buttonModifs_Click(object sender, EventArgs e)
        {
            if(textBoxNom.Text != "")
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

        }
    }
}

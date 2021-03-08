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

        public ModifierFournisseur(Fournisseur f, SQLiteConnection db)
        {
            InitializeComponent();
            this.fournisseur = f;
            this.DB = db;
            InitInfoField();
        }

        public void InitInfoField()
        {
            if (fournisseur.nom != null)
            {
                labelCurrentNom.Text = fournisseur.nom;
            }
            labelCurrentTelephone.Text = fournisseur.telephone;

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

        private void buttonOKParamMag_Click(object sender, EventArgs e)
        {
            fournisseur.telephone = textBoxNewTel.Text;
            DB.Update(fournisseur);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonAnnulParamMag_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonModifTel_Click(object sender, EventArgs e)
        {
            if (textBoxNewTel.Visible != true)
            {
                textBoxNewTel.Visible = true;
            }
        }

        private void buttonModifProduits_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void buttonModifEmpl_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}

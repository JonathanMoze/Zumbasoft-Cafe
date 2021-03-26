using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Produit
{
    public partial class ModifierProduit : Form, FormProduit
    {
        SQLiteConnection DB;
        Produit produit;
        public ModifierProduit(Produit p,SQLiteConnection db)
        {
            InitializeComponent();
            this.produit = p;
            DB = db;
            initComboBoxes();
            initChamps();
            TitreNomProduit.Text = p.nom;
        }


        public void initComboBoxes()
        {
            comboBoxFournisseur.Items.Clear();
            comboBoxGenre.Items.Clear();

            foreach (Fournisseur f in DB.GetAllWithChildren<Fournisseur>())
            {
                comboBoxFournisseur.Items.Add(f);
            }

            foreach (Genre g in DB.GetAllWithChildren<Genre>())
            {
                comboBoxGenre.Items.Add(g);
            }

        }

        public void initChamps()
        {
            textBoxNom.PlaceholderText = produit.nom;
            textBoxCodeB.PlaceholderText = Convert.ToString(produit.code_barre);
            textBoxRef.PlaceholderText = produit.reference;
            numericUpDownAHT.Value = produit.prix_achat_HT;
            numericUpDownATTC.Value = produit.prix_achat_TTC;
            numericUpDownVHT.Value = produit.prix_vente_HT;
            numericUpDownVTTC.Value = produit.prix_vente_TTC;
            textBoxType.PlaceholderText = produit.type;
            textBoxMarque.PlaceholderText = produit.marque;
            textBoxCouleur.PlaceholderText = produit.couleur;
            comboBoxGenre.SelectedIndex = comboBoxGenre.
                FindStringExact(produit.genre.intitule);
            comboBoxFournisseur.SelectedIndex = comboBoxFournisseur.
                FindStringExact(produit.fournisseur.nom);

        }

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            AccueilGenre accGenre = new AccueilGenre(DB, this);
            accGenre.Show();
        }

        private void buttonFournisseurs_Click(object sender, EventArgs e)
        {
            AccueilFournisseur accFourni = new AccueilFournisseur(DB, this);
            accFourni.Show();
        }


        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "")
            {
                textBoxNom.PlaceholderText = textBoxNom.Text;
                TitreNomProduit.Text = textBoxNom.Text;
                textBoxNom.Text = "";
            }

            if (textBoxRef.Text != "")
            {
                textBoxRef.PlaceholderText = textBoxRef.Text;
                textBoxRef.Text = "";
            }

            if (textBoxCodeB.Text != "")
            {
                int i;
                if (Int32.TryParse(textBoxCodeB.Text, out i))
                {
                    textBoxCodeB.PlaceholderText = textBoxCodeB.Text;
                }
                textBoxCodeB.Text = "";
            }

            if (textBoxType.Text != "")
            {
                textBoxType.PlaceholderText = textBoxType.Text;
                textBoxType.Text = "";
            }

            if (textBoxMarque.Text != "")
            {
                textBoxMarque.PlaceholderText = textBoxMarque.Text;
                textBoxMarque.Text = "";
            }

            if (textBoxCouleur.Text != "")
            {
                textBoxCouleur.PlaceholderText = textBoxCouleur.Text;
                textBoxCouleur.Text = "";
            }

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void butonOk_Click(object sender, EventArgs e)
        {
            produit.nom = textBoxNom.PlaceholderText;
            produit.reference = textBoxRef.PlaceholderText;
            produit.code_barre = Int32.Parse(textBoxCodeB.PlaceholderText);
            produit.type = textBoxType.PlaceholderText;
            produit.marque = textBoxMarque.PlaceholderText;
            produit.couleur = textBoxCouleur.PlaceholderText;

            produit.prix_achat_HT = numericUpDownAHT.Value;
            produit.prix_achat_TTC = numericUpDownATTC.Value;
            produit.prix_vente_HT = numericUpDownVHT.Value;
            produit.prix_vente_TTC = numericUpDownVTTC.Value;
            produit.genre = (Genre)comboBoxGenre.SelectedItem;
            produit.fournisseur = (Fournisseur)comboBoxFournisseur.SelectedItem;


            DB.UpdateWithChildren(produit);


            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

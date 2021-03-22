using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Produit
{
    public partial class AjouterProduit : Form
    {
        SQLiteConnection DB;
        public Produit produit;

        public AjouterProduit(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initComboBoxes();
        }

        private void initComboBoxes()
        {
            comboBoxFournisseur.Items.Clear();
            comboBoxGenre.Items.Clear();

            foreach(Fournisseur f in DB.GetAllWithChildren<Fournisseur>())
            {
                comboBoxFournisseur.Items.Add(f);
            }

            foreach(Genre g in DB.GetAllWithChildren<Genre>())
            {
                comboBoxGenre.Items.Add(g);
            }

        }

        public Produit initObjetProduit(){
            produit = new Produit();
            produit.nom = textBoxNom.Text;
            produit.reference = textBoxRef.Text;
            int i;
            if (Int32.TryParse(textBoxCodeB.Text, out i))
            {
                produit.code_barre = Int32.Parse(textBoxCodeB.Text);
            }
            else
            {
                produit.code_barre = 0000;
            }


            produit.prix_achat_HT = numericUpDownAHT.Value;
            produit.prix_achat_TTC = numericUpDownATTC.Value;
            produit.prix_vente_HT = numericUpDownVHT.Value;
            produit.prix_vente_TTC = numericUpDownVTTC.Value;


            produit.type = textBoxType.Text;
            produit.marque = textBoxMarque.Text;
            produit.couleur = textBoxCouleur.Text;
            produit.genre = (Genre)comboBoxGenre.SelectedItem;
            produit.fournisseur = (Fournisseur)comboBoxFournisseur.SelectedItem;

            return produit;
            

        }

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            AccueilGenre accGenre = new AccueilGenre(DB);
            accGenre.Show();
        }

        private void buttonFournisseurs_Click(object sender, EventArgs e)
        {
            AccueilFournisseur accFourni = new AccueilFournisseur(DB);
            accFourni.Show();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            produit = initObjetProduit();
            DB.InsertWithChildren(produit);
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

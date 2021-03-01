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
    public partial class ParamétrerMagasin : Form
    {
        Magasin magasin;
        SQLiteConnection DB;
        public ParamétrerMagasin(Magasin magasin, SQLiteConnection db)
        {
            InitializeComponent();
            this.magasin = magasin;
            this.DB = db;
            InitInfoField();

        }
        public void InitInfoField()
        {
            if (magasin.adresse != null)
            {
                labelCurrentAdresse.Text = magasin.adresse.adresse;
            }
            labelCurrentMdp.Text = magasin.mot_de_passe;
            if(magasin.stock.Count != 0)
            {
                foreach(ProduitEnStock p in magasin.stock)
                {
                    listViewStock.Items.Add(p.ToString());
                }
            }
            else { listViewStock.Items.Add("Aucun"); }
            if (magasin.rapports.Count != 0)
            {
                foreach (Rapport r in magasin.rapports)
                {
                    listViewRapports.Items.Add(r.ToString());
                }
            }
            else { listViewRapports.Items.Add("Aucun"); }
            if(magasin.commandes.Count != 0)
            {
                foreach (Commande c in magasin.commandes)
                {
                    listViewCommandes.Items.Add(c.ToString());
                }
            }
            else { listViewCommandes.Items.Add("Aucun"); }
            if(magasin.utilisateurs.Count != 0)
            {
                foreach (Utilisateur u in magasin.utilisateurs)
                {
                    listViewEmployes.Items.Add(u.ToString());
                }
            }
            else { listViewEmployes.Items.Add("Aucun"); }
        }

        public bool isFieldValid()
        {
            if (textBoxMdp.Visible)
            {
                if(!(textBoxMdp.Text.Length <=32) || !(textBoxMdp.Text.Length >= 8))
                {
                    labelErrorMdp.Visible = true;
                    return false;
                }
            }
            return true;
        }

        private void buttonOKParamMag_Click(object sender, EventArgs e)
        {
            if (isFieldValid())
            {
                magasin.mot_de_passe = textBoxMdp.Text;
                DB.Update(magasin);
                DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void buttonAnnulParamMag_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ParamétrerMagasin_Load(object sender, EventArgs e)
        {

        }

        private void buttonModifMdp_Click(object sender, EventArgs e)
        {
            if(textBoxMdp.Visible != true)
            {
                textBoxMdp.Visible = true;
            }
        }

        private void textBoxMdp_TextChanged(object sender, EventArgs e)
        {
            if (labelErrorMdp.Visible == true)
            {
                labelErrorMdp.Visible = false;
            }
        }
    }
}

using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Magasin
{
    public partial class AccueilMagasin : Form
    {
        SQLiteConnection DB;
        Magasin magasin;
        Adresse newAdresse;

        public AccueilMagasin(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initListMagasin();
            initItemsColors();
        }

        public void initListMagasin()
        {
            foreach (Magasin m in DB.GetAllWithChildren<Magasin>())
            {
                listMagasin.Items.Add(m);
            }
        }

        public void initItemsColors()
        {
            panel1.BackColor = Color.FromArgb(95, 12, 12, 12);
            panel2.BackColor = Color.FromArgb(95, 12, 12, 12);
            panel3.BackColor = Color.FromArgb(95, 12, 12, 12);
            panel4.BackColor = Color.FromArgb(80, 12, 12, 12);
            panel5.BackColor = Color.FromArgb(80, 12, 12, 12);
            panel6.BackColor = Color.FromArgb(80, 12, 12, 12);
            panel7.BackColor = Color.FromArgb(80, 12, 12, 12);
            
            button1.BackColor = Color.FromArgb(80, 12, 12, 12);
            button2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAccueil.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAdr.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAjouter.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonModifCmd.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonModifEmpl.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonModifMdp.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonModifRprt.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonModifStock.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonSupprimer.BackColor = Color.FromArgb(80, 12, 12, 12);


        }

        private void listMagasin_SelectedIndexChanged(object sender, EventArgs e)
        {
            magasin = (Magasin)listMagasin.SelectedItem;
            EnabledInfoField();
            UpdateInfoField();
        }
        

        private void EnabledInfoField()
        {
            buttonModifCmd.Enabled = true;
            buttonModifEmpl.Enabled = true;
            buttonModifRprt.Enabled = true;
            buttonModifStock.Enabled = true;
            buttonModifMdp.Enabled = true;
            buttonSupprimer.Enabled = true;
        }

        private void UpdateInfoField()
        {
            if (magasin.adresse != null)
            {
                labelCurrentAdresse.Text = magasin.adresse.adresse;
            }
            labelCurrentMdp.Text = magasin.mot_de_passe;

            listViewStock.Items.Clear();
            if (magasin.stock.Count != 0)
            {
                foreach (ProduitEnStock p in magasin.stock)
                {
                    listViewStock.Items.Add(p.ToString());
                }
            }
            else { listViewStock.Items.Add("Aucun"); }

            listViewRapports.Items.Clear();
            if (magasin.rapports.Count != 0)
            {
                foreach (Rapport r in magasin.rapports)
                {
                    listViewRapports.Items.Add(r.ToString());
                }
            }
            else { listViewRapports.Items.Add("Aucun"); }

            listViewCommandes.Items.Clear();
            if (magasin.commandes.Count != 0)
            {
                foreach (Commande c in magasin.commandes)
                {
                    listViewCommandes.Items.Add(c.ToString());
                }
            }
            else { listViewCommandes.Items.Add("Aucun"); }

            listViewEmployes.Items.Clear();
            if (magasin.utilisateurs.Count != 0)
            {
                foreach (Utilisateur u in magasin.utilisateurs)
                {
                    listViewEmployes.Items.Add(u.ToString());
                }
            }
            else { listViewEmployes.Items.Add("Aucun"); }
        }

        private void boutonSupprimer_Click(object sender, EventArgs e)
        {
            
        }


        public Magasin initObjectMagasin()
        {
            magasin = new Magasin();
            magasin.mot_de_passe = textBoxNewMdp.Text;
            magasin.adresse = newAdresse;
            magasin.commandes = new List<Commande>();
            magasin.rapports = new List<Rapport>();
            magasin.stock = new List<ProduitEnStock>();
            magasin.utilisateurs = new List<Utilisateur>();
            return magasin;
        }

        public bool fieldsNewMagasinIsValid()
        {
            if (textBoxNewMdp.Text == "")
            {
                labelErreurNewMdp.Visible = true;
                return false;
            }
            else
            {
                if (textBoxNewMdp.Text.Length <= 8 || textBoxNewMdp.Text.Length >= 32)
                {
                    labelErreurNewMdp.Visible = true;
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

        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (fieldsNewMagasinIsValid())
            {
                Magasin mag = initObjectMagasin();
                DB.InsertWithChildren(magasin);
                listMagasin.Items.Add(mag);
                listMagasin.SelectedItem = mag;
                clearNewMagasinField();
            }
        }

        private void clearNewMagasinField()
        {
            textBoxAdr.Text = "";
            textBoxNewMdp.Text = "";
        }

        private void buttonAdr_Click(object sender, EventArgs e)
        {
            NouvelleAdresse newAdr = new NouvelleAdresse(DB);
            if (newAdr.ShowDialog() == DialogResult.OK)
            {
                newAdresse = newAdr.adr;
                textBoxAdr.Text = newAdr.adr.adresse;
            }
        }

        private void buttonModifMdp_Click(object sender, EventArgs e)
        {
            if (fielModifMagasinIsValid())
            {
                magasin.mot_de_passe = textBoxModifMdp.Text;
                DB.UpdateWithChildren(magasin);

                listMagasin.Items.Clear();
                initListMagasin();
                UpdateInfoField();

                textBoxModifMdp.Text = "";
                labelErrorModifMdp.Visible = false;

                listMagasin.SelectedIndex = 0;
            }
        }

        private bool fielModifMagasinIsValid()
        {
            if (textBoxModifMdp.Text == "")
            {
                labelErrorModifMdp.Visible = true;
                return false;
            }
            else
            {
                if (textBoxModifMdp.Text.Length <= 8 || textBoxModifMdp.Text.Length >= 32)
                {
                    labelErrorModifMdp.Visible = true;
                    return false;
                }
            }
            return true;
        }

        private void buttonModifStock_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void buttonModifEmpl_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void buttonModifCmd_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void buttonModifRprt_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            SupprimerMagasin supprimerMagasin = new SupprimerMagasin(magasin, DB);
            if(supprimerMagasin.ShowDialog() == DialogResult.OK)
            {
                var deletedMag = magasin;
                magasin = null;
                listMagasin.SelectedIndex = 0;
                listMagasin.Items.Clear();
                initListMagasin();
                UpdateInfoField();
            }
        }

        private void AccueilMagasin_Load(object sender, EventArgs e)
        {

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

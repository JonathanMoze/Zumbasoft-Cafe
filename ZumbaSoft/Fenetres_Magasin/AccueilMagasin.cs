using SQLite;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        /// <summary>
        /// Constructeur de ce formulaire.
        /// </summary>
        /// <param name="db">La connection actuelle à la base de données.</param>
        public AccueilMagasin(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initListMagasin();
            initItemsColors();
            checkDB();
        }

        /// <summary>
        /// Méthode pour instancier les objets nécéssaires à la gestion du magasin en RAM.
        /// </summary>
        public void initListMagasin()
        {
            foreach (Magasin m in DB.GetAllWithChildren<Magasin>())
            {
                listMagasin.Items.Add(m);
            }
        }

        /// <summary>
        /// Méthode d'initalisation des couleurs des objets du formulaire.
        /// Elle n'est pas destinée à servir ailleurs.
        /// </summary>
        public void initItemsColors()
        {
            panel1.BackColor = Color.FromArgb(95, 12, 12, 12);
            panel2.BackColor = Color.FromArgb(95, 12, 12, 12);
            panel3.BackColor = Color.FromArgb(95, 12, 12, 12);
            panel4.BackColor = Color.FromArgb(80, 12, 12, 12);
            panel5.BackColor = Color.FromArgb(80, 12, 12, 12);
            panel6.BackColor = Color.FromArgb(80, 12, 12, 12);
            panel7.BackColor = Color.FromArgb(80, 12, 12, 12);
            panelERROR.BackColor = Color.FromArgb(100, 120, 1, 1);

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
            buttonBackHome.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonContactAdmin.BackColor = Color.FromArgb(80, 12, 12, 12);

        }

        /// <summary>
        /// Méthode pour vérifier la conexion à la BD.
        /// Cette méthode renvoie un message d'erreur dans le cas où la BD est introuvable.
        /// </summary>
        public void checkDB()
        {
            var database = new FileInfo("Dataddbase.db");
            if (!database.Exists)
            {
                msgBDstatusERROR.Visible = true;
                msgBDstatusOK.Visible = false;

                dbERROR.Visible = true;
                dbOK.Visible = false;

                var t = new Timer();
                t.Interval = 2000; // Durée de l'attente avant l'affichage du message
                t.Tick += (s, e) =>
                {
                    panelERROR.Visible = true;
                    t.Stop();
                };
                t.Start();

                var t2 = new Timer();
                t2.Interval = 8000; // Durée de l'affichage du message
                t2.Tick += (s, e) =>
                {
                    panelERROR.Visible = false;
                    t2.Stop();
                };
                t2.Start();

            }
            else
            {
                msgBDstatusERROR.Visible = false;
                msgBDstatusOK.Visible = true;

                dbERROR.Visible = false;
                dbOK.Visible = true;
            }
        }

        /// <summary>
        /// Méthode appelée en cas de changement de magasin sélectionné par l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listMagasin_SelectedIndexChanged(object sender, EventArgs e)
        {
            magasin = (Magasin)listMagasin.SelectedItem;
            EnabledInfoField();
            UpdateInfoField();
        }
        
        /// <summary>
        /// Méthode pour activer le champ d'informations, qui recense les magasins.
        /// </summary>
        private void EnabledInfoField()
        {
            buttonModifCmd.Enabled = true;
            buttonModifEmpl.Enabled = true;
            buttonModifRprt.Enabled = true;
            buttonModifStock.Enabled = true;
            buttonModifMdp.Enabled = true;
            buttonSupprimer.Enabled = true;
        }

        /// <summary>
        /// Méthode pour mettre à jour le panel d'informations.
        /// Ce panel recense les divers magasins connus de l'application.
        /// </summary>
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

        /// <summary>
        /// Méthode pour ajouter un magasin dans la liste des magasins connus de l'application.
        /// Nécessite la connection à la BD.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Méthode pour vérifier que l'ajout d'un magasin est valide.
        /// </summary>
        /// <returns>true si le formulaire est correctement rempli, false sinon.</returns>
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

        /// <summary>
        /// Méthode pour gérer le retour à l'accueil de l'application.
        /// Celle-ci se fait via le bouton "retour à l'accueil" uniquement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Méthode pour déployer le formulaire d'ajout de magasin dans le panneau concerné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Méthode pour vider le formulaire d'ajout de magasin.
        /// </summary>
        private void clearNewMagasinField()
        {
            textBoxAdr.Text = "";
            textBoxNewMdp.Text = "";
        }

        /// <summary>
        /// Méthode pour obtenir une nouvelle adresse pour un magasin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdr_Click(object sender, EventArgs e)
        {
            NouvelleAdresse newAdr = new NouvelleAdresse(DB);
            if (newAdr.ShowDialog() == DialogResult.OK)
            {
                newAdresse = newAdr.adr;
                textBoxAdr.Text = newAdr.adr.adresse;
            }
        }

        /// <summary>
        /// Méthode pour gérer la modification de mots de passe par l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Méthode pour vérifier le formulaire de modification d'un magasin.
        /// </summary>
        /// <returns>True si tout s'est bien passé, false sinon.</returns>
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

        /// <summary>
        /// Méthode pour gérer la suppression d'un magasin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            Confirmation supprimerMagasin = new Confirmation(magasin, DB);
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

        /// <summary>
        /// Méthode pour fermer la fenêtre courante.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goBackButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Méthode pour afficher le message d'erreur en cas de problèmes de connection à la BD.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msgBDstatusERROR_Click(object sender, EventArgs e)
        {
            if (!panelERROR.Visible)
            {
                panelERROR.Visible = true;
                var t = new Timer();
                t.Interval = 8000; // Durée de l'affichage du message
                t.Tick += (s, e) =>
                {
                    panelERROR.Visible = false;
                    t.Stop();
                };
                t.Start();
            }
        }

        /// <summary>
        /// Méthode pour créer un email de contact aux administrateurs en cas d'erreur, notamment de connection à la BD.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonContactAdmin_Click(object sender, EventArgs e)
        {
            Process OpenMailClient = new Process();
            DateTime date = DateTime.Now;
            String emailAddress = "mrkafeine@gmail.com";
            String subject = "Rapport d'erreur - BD introuvable";
            String body = "---------------------------------%0a%0aRapport d'erreur  OUATELSE : le " + date.ToString("MM/dd/yyyy") + " à " + date.ToString("HH:mm") + " : ERREUR 01 - Impossible d'accéder à la base de données : le fichier correspondant à la base de données (Database.db) est introuvable.%0a%0aRépondez directement à ce mail pour échanger avec le magasin concerné.%0a%0a---------------------------------%0a%0aEntrez des détails ici (que s'est-il passé avant l'apparition de ce problème, d'éventuelles remarques...) :";

            string filename = "mailto:"+emailAddress+"?subject=" + subject + "&body="+body;
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = filename;
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.RedirectStandardOutput = false;
            myProcess.Start();

        }

        /// <summary>
        /// Méthode pour retourner à l'écran d'accueil.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackHome_Click(object sender, EventArgs e)
        {
            panelERROR.Visible = false;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

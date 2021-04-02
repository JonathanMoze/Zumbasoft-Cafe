using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using ZumbaSoft.Model;

namespace ZumbaSoft.Fenetres_Magasin
{
    public partial class NouvelleAdresse : Form
    {
        SQLiteConnection DB;
        public Adresse adr;
        public NouvelleAdresse(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initItemsColors();
        }

        /// <summary>
        /// Méthode pour instancier une nouvelle adresse.
        /// </summary>
        /// <returns></returns>
        public Adresse initObjectAdresse()
        {
            Adresse adresse = new Adresse();
            adresse.adresse = textBoxAdresse.Text;
            adresse.code_postal = textBoxCodePostal.Text;
            adresse.complement = textBoxComplement.Text;
            adresse.ville = textBoxVille.Text;
            return adresse;
        }

        /// <summary>
        /// Méthode pour initialiser les couleurs du formulaire.
        /// Elle n'est destinée à être appelée qu'une seule fois.
        /// </summary>
        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(50, 12, 12, 12);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonOK.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
        }


        /// <summary>
        /// Permet de vérifier si les champs saisit par l'utilisateur sont valides.
        /// </summary>
        /// <returns>true si ils sont valides sinon false</returns>
        public bool fieldIsValid()
        {
            if (textBoxAdresse.Text == "")
            {
                labelErreurAdr.Visible = true;
                return false;
            }
            if (!(textBoxCodePostal.Text == ""))
            {
                int n;
                foreach(char c in textBoxCodePostal.Text.ToCharArray())
                {
                    if (!Int32.TryParse(c.ToString(),out n))
                    {
                        labelErreurCP.Visible = true;
                        return false;
                    }
                    if(textBoxCodePostal.Text.Length != 5)
                    {
                        labelErreurCP.Visible = true;
                        return false;
                    }
                }
            }
            else
            {
                labelErreurCP.Visible = true;
                return false;
            }
            if (textBoxVille.Text == "")
            {
                labelErreurVille.Visible = true;
                return false;
            }
            return true;
        }

        /// <summary>
        /// Méthode pour gérer la modification de texte dans la textBox de l'adresse en cas d'erreur de texte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAdresse_TextChanged(object sender, EventArgs e)
        {
            if (labelErreurAdr.Visible == true)
            {
                labelErreurAdr.Visible = false;
            }
        }

        /// <summary>
        /// Méthode pour effacer le message d'erreur en cas de modification de la textBox du code postal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCodePostal_TextChanged(object sender, EventArgs e)
        {
            if (labelErreurCP.Visible == true)
            {
                labelErreurCP.Visible = false;
            }
        }

        /// <summary>
        /// Méthode pour effacer le message d'erreur en cas de modification de la textBox du nom de la ville.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxVille_TextChanged(object sender, EventArgs e)
        {
            if (labelErreurVille.Visible == true)
            {
                labelErreurVille.Visible = false;
            }
        }

        /// <summary>
        /// Méthode pour valider le formulaire et calibrer la nouvelle adresse.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (fieldIsValid())
            {
                Adresse adresse = initObjectAdresse();
                DB.Insert(adresse);
                adr = adresse;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        /// <summary>
        /// Méthode pour tuer la fenêtre du formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
using ZumbaSoft.Fenetres_Magasin;

namespace ZumbaSoft.Fenetres_Identification
{
    public partial class CreationCompte : Form
    {
        SQLiteConnection DB;
        public Adresse adresse;
        Utilisateur utilisateur;

        public CreationCompte(SQLiteConnection db)
        {
            DB = db;
            InitializeComponent();
            initComboBoxes();
            initItemsColors();
        }

        public void initComboBoxes()
        {
            comboBoxCivilité.DataSource = Enum.GetValues(typeof(EnumCivilite));
            comboBoxStatus.DataSource = Enum.GetValues(typeof(EnumStatus));
            comboBoxRole.DataSource = DB.GetAllWithChildren<Role>();
        }

        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(50, 12, 12, 12);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAjouter.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
        }

        public void initClient()
        {
            utilisateur = new Utilisateur();
            utilisateur.civilite = (EnumCivilite)comboBoxCivilité.SelectedItem;
            utilisateur.status = (EnumStatus)comboBoxStatus.SelectedItem;
            utilisateur.nom = textBoxNom.Text;
            utilisateur.prenom = textBoxPrenom.Text;
            utilisateur.telephone = textBoxTel.Text;
            utilisateur.email = textBoxMail.Text;
            utilisateur.date_naissance = dateTimeNaissance.Value;
            utilisateur.adresse = adresse;
            utilisateur.login = textBoxLogin.Text;
            utilisateur.mot_de_passe = textBoxPassword.Text;
        }

        public bool correctInformations()
        {
            if (comboBoxCivilité.SelectedItem == null || comboBoxStatus.SelectedItem == null || comboBoxRole.SelectedItem == null)
            {
                return false;
            }
            if (textBoxNom.Text == "" || textBoxPrenom.Text == "")
            {
                return false;
            }
            if (!(textBoxTel.Text == ""))
            {
                int status;
                if (!Int32.TryParse(textBoxTel.Text, out status))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            if (textBoxMail.Text == "")
            {
                return false;
            }
            if (GetAge(dateTimeNaissance.Value) < 18)
            {
                return false;
            }
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                return false;
            }

            return true;
        }

        public bool loginUnique()
        {
            List<Utilisateur> u = DB.Table<Utilisateur>().Where(x => x.login.Equals(textBoxLogin.Text)).ToList();
            if(u.Count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public int GetAge(DateTime Naissance)
        {
            return DateTime.Now.Year - Naissance.Year -
                     (DateTime.Now.Month < Naissance.Month ? 1 :
                     (DateTime.Now.Month == Naissance.Month && DateTime.Now.Day < Naissance.Day) ? 1 : 0);
        }

        private void buttonNvAdresse_Click(object sender, EventArgs e)
        {
            NouvelleAdresse newAdr = new NouvelleAdresse(DB);
            if (newAdr.ShowDialog() == DialogResult.OK)
            {
                adresse = newAdr.adr;
                textBoxAdr.Text = newAdr.adr.adresse;
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void buttonValider_Click(object sender, EventArgs e)
        {
            if (correctInformations())
            {
                if (loginUnique())
                {
                    initClient();
                    DB.InsertWithChildren(utilisateur);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    labelErreur.Visible = true;
                    labelErreur.Text = "Login déja pris";
                }
                
            }
            else
            {
                labelErreur.Text = "Un ou plusieurs champs sont incorrects";
                labelErreur.Visible = true;
            }
        }

    }
}

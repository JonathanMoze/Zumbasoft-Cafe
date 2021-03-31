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

namespace ZumbaSoft.Fenetres_Ventes
{
    public partial class NouveauClient : Form
    {
        SQLiteConnection DB;
        public Client client;
        public Adresse adresse;

        public NouveauClient(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            initComboBoxes();
        }


        public void initComboBoxes()
        {
            comboBoxCivilité.DataSource = Enum.GetValues(typeof(EnumCivilite));
            comboBoxStatus.DataSource = Enum.GetValues(typeof(EnumStatus));
        }

        public void initClient()
        {
            client = new Client();
            client.civilite = (EnumCivilite)comboBoxCivilité.SelectedItem;
            client.status = (EnumStatus)comboBoxStatus.SelectedItem;
            client.nom = textBoxNom.Text;
            client.prenom = textBoxPrenom.Text;
            client.telephone = textBoxTel.Text;
            client.email = textBoxMail.Text;
            client.date_naissance = dateTimeNaissance.Value;
            client.adresse = adresse;
        }


        public bool correctInformations()
        {
            if(comboBoxCivilité.SelectedItem == null || comboBoxStatus.SelectedItem == null)
            {
                return false;
            }
            if(textBoxNom.Text == "" ||textBoxPrenom.Text == "")
            {
                return false;
            }
            if(!(textBoxTel.Text == ""))
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
            if(textBoxMail.Text == "")
            {
                return false;
            }
            if (GetAge(dateTimeNaissance.Value) < 18)
            {
                return false;
            }

            return true;
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

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (correctInformations())
            {
                initClient();
                DB.InsertWithChildren(client);
                DialogResult = DialogResult.OK;
                this.Close();
            }else
            {
                labelErreur.Visible = true;
            }
        }
    }
}

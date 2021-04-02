using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using ZumbaSoft.Model;
using SQLiteNetExtensions;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Fenetres_Magasin;

namespace ZumbaSoft.Fenetres_Ventes
{
    public partial class ModifierClient : Form
    {
        SQLiteConnection DB;
        Client client;

        public ModifierClient(Client c, SQLiteConnection db)
        {
            InitializeComponent();
            this.client = c;
            DB = db;
            initChamps();
            TitreNomClient.Text = c.ToString();
            initItemsColors();
        }

        public void initChamps()
        {
            comboBoxCivilité.DataSource = Enum.GetValues(typeof(EnumCivilite));
            comboBoxStatus.DataSource = Enum.GetValues(typeof(EnumStatus));
            comboBoxCivilité.SelectedItem = client.civilite;
            comboBoxStatus.SelectedItem = client.status;
            textBoxNom.PlaceholderText = client.nom;
            textBoxPrenom.PlaceholderText = client.prenom;
            textBoxTel.PlaceholderText = client.telephone;
            textBoxMail.PlaceholderText = client.mail;
            dateTimeNaissance.Value = client.date_naissance;
            textBoxAdr.PlaceholderText = client.adresse.adresse;
        }

        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(50, 12, 12, 12);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAjouter.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "")
            {
                textBoxNom.PlaceholderText = textBoxNom.Text;
                TitreNomClient.Text = textBoxNom.Text;
                textBoxNom.Text = "";
            }

            if (textBoxPrenom.Text != "")
            {
                textBoxPrenom.PlaceholderText = textBoxPrenom.Text;
                textBoxPrenom.Text = "";
            }

            if (textBoxTel.Text != "")
            {
                textBoxTel.PlaceholderText = textBoxTel.Text;
                textBoxTel.Text = "";
            }

            if (textBoxMail.Text != "")
            {
                textBoxMail.PlaceholderText = textBoxMail.Text;
                textBoxMail.Text = "";
            }

            client.nom = textBoxNom.PlaceholderText;
            client.prenom = textBoxPrenom.PlaceholderText;
            client.telephone = textBoxTel.PlaceholderText;
            client.mail = textBoxMail.PlaceholderText;
            client.civilite = (EnumCivilite)comboBoxCivilité.SelectedItem;
            client.status = (EnumStatus)comboBoxStatus.SelectedItem;
            client.date_naissance = dateTimeNaissance.Value;

            DB.UpdateWithChildren(client);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonNvAdresse_Click(object sender, EventArgs e)
        {
            NouvelleAdresse newAdr = new NouvelleAdresse(DB);
            if (newAdr.ShowDialog() == DialogResult.OK)
            {
                client.adresse = newAdr.adr;
                textBoxAdr.Text = newAdr.adr.adresse;
            }
        }
    }
}

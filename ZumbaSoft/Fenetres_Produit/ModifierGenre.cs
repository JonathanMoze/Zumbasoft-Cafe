using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;
using SQLiteNetExtensions;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Produit
{
    public partial class ModifierGenre : Form
    {
        Genre genre;
        SQLiteConnection DB;
        public ModifierGenre(Genre genre, SQLiteConnection db)
        {
            InitializeComponent();
            this.genre = genre;
            this.DB = db;
            InitInfoField();
            initItemsColors();

        }

        public void InitInfoField()
        {
            labelCurrentIntitule.Text = genre.intitule;
        }

        public void initItemsColors()
        {
            backgroundBlock1.BackColor = Color.FromArgb(50, 12, 12, 12);
            backgroundBlock2.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonAnnuler.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonOK.BackColor = Color.FromArgb(50, 12, 12, 12);
            buttonModifMdp.BackColor = Color.FromArgb(50, 12, 12, 12);
        }

        public void buttonOK_Click(object sender, EventArgs e)
        {
            genre.intitule = textBoxIntitule.Text;
            DB.Update(genre);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonModifMdp_Click(object sender, EventArgs e)
        {
            if (textBoxIntitule.Visible != true)
            {
                textBoxIntitule.Visible = true;
            }
        }
    }
}

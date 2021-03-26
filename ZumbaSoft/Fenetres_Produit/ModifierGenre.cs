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

        }

        public void InitInfoField()
        {
            labelCurrentIntitule.Text = genre.intitule;
        }

        private void buttonOK_Click(object sender, EventArgs e)
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

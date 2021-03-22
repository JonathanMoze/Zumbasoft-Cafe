using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Identification
{
    public partial class Identification : Form
    {
        SQLiteConnection database;
        public Identification(SQLiteConnection db)
        {
            InitializeComponent();
            database = db;
        }

        /// <summary>
        /// Méthode gestionnaire d'évènements appelée lorsqu'on clique sur le bouton "se connecter".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            #region check login
            SQLiteCommand cmd = database.CreateCommand("select password from users where login=?", loginField.Text);
            #endregion
            #region check password
            string pass = get_pass(passwordField.Text);
            if (pass != null)
            {
                //TODO
            }
            #endregion
        }

        /// <summary>
        /// Méthode de traitement interne pour obtenir un mot de passe dans la base.
        /// </summary>
        /// <param name="client">Le mot de passe entré par le client.</param>
        /// <returns></returns>
        private string get_pass(string client)
        {
            return "";
        }
    }
}

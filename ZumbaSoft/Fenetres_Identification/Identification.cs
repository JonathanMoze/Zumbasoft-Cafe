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

        #region log-in
        /// <summary>
        /// Méthode gestionnaire d'évènements appelée lorsqu'on clique sur le bouton "se connecter".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            #region check login
            string log_in = loginField.Text;
            if (check_login(log_in))
            {
                #region check password
                string pass = get_pass(passwordField.Text);
                if (pass != null)
                {
                    //TODO
                }
                else
                {
                    MessageBox.Show("Mauvais mot de passe ou identifiant.");
                }
                #endregion
            }
            #endregion
        }

        /// <summary>
        /// Méthode de traitement interne pour vérifier si le client est bien enregistré.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        private bool check_login(string client)
        {
            //TODO requêtes
            return false;
        }

        /// <summary>
        /// Méthode de traitement interne pour obtenir un mot de passe dans la base.
        /// </summary>
        /// <param name="client">Le mot de passe entré par le client.</param>
        /// <returns></returns>
        private string get_pass(string client)
        {
            //TODO requêtes
            return "";
        }
        #endregion
    }
}

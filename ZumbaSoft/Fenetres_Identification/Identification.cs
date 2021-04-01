using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZumbaSoft.Model;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Identification
{
    public partial class Identification : Form
    {

        public Utilisateur uConnecte;

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
        public void connection_button_Click(object sender, EventArgs e)
        {
            #region check login
            string log_in = loginField.Text;
            if (check_login(log_in))
            {
                #region check password
                string pass = get_pass(loginField.Text);
                if (pass != null)
                {
                    if (pass.Equals(passwordField.Text))
                    {
                        Utilisateur u = database.Table<Utilisateur>().Where(x => x.login.Equals(log_in)).ToList()[0];
                        uConnecte = database.GetWithChildren<Utilisateur>(u.id_personne);
                        this.DialogResult = DialogResult.OK;//retour positif de la fenêtre.
                        MessageBox.Show("Vous êtes connecté.");
                    }
                    else
                    {
                        MessageBox.Show("Mauvais mot de passe ou identifiant.");
                    }
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
        /// Méthode gérant l'évènement de clic sur le bouton "créer un compte".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void buttonCreationCompte_Click(object sender, EventArgs e)
        {
            CreationCompte cp = new CreationCompte(database);
            cp.Show();
        }

        /// <summary>
        /// Méthode de traitement interne pour vérifier si le client est bien enregistré.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        private bool check_login(string client)
        {
            List<Utilisateur> test = database.Table<Utilisateur>().Where(x => x.login.Equals(client)).ToList();
            if (test.Count > 0)
            {
                return test[0] != null;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Méthode de traitement interne pour obtenir un mot de passe dans la base.
        /// </summary>
        /// <param name="client">Le mot de passe entré par le client.</param>
        /// <returns>Le mot de passe, avec un nullcheck à faire.</returns>
        public string get_pass(string client)
        {
            return database.Table<Utilisateur>().Where(x => x.login.Equals(client)).ToList()[0].mot_de_passe;
        }
        #endregion
    }
}

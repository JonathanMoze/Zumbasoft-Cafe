﻿using System;
using System.Windows.Forms;

namespace ZumbaSoft.Fenetres_Magasin
{
    public partial class AuthentificationMagasin : Form
    {
        public AuthentificationMagasin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Méthode pour vérifier si une authentification est valide.
        /// Le processus d'authentification ne mémorisera cependant pas l'identitifiant courant en cas d'erreur.
        /// De même, la fonction "mot de passe oublié" ne sera pas implémentée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validation_Click(object sender, EventArgs e)
        {
            string login = addresse.Text;
            string pass = mdp.Text;
            string textRetour = "";
            if (login != null && pass != null)
            {
                if (login.Length > 64)
                {
                    //TODO
                }
            }
        }
    }
}
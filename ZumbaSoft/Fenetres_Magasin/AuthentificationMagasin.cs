using System;
using SQLite;
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
                #region checklogin
                //TODO faire un check dans la base pour savoir si on connaît le login;
                string waitedPass = "";
                #endregion
                if (true)
                {
                    if (pass == waitedPass)
                    {
                        //TODO init session
                    }
                }
                else
                {
                    textRetour = "Veuillez entrer un identifiant valide.";
                    MessageBox.Show(textRetour);
                }
            }
            else
            {
                textRetour = "Veuillez renseigner votre mot de passe ou votre identifiant.";
                MessageBox.Show(textRetour);
            }
        }
    }
}
using ZumbaSoft.Model;

namespace ZumbaSoft
{
    /// <summary>
    /// Classe statique servant à stocker des données en RAM servant pour tout le logiciel, indépendamment des autres classes.
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// L'utilisateur connecté courant
        /// </summary>
        public static Utilisateur utilisateurCourant = null;
    }
}
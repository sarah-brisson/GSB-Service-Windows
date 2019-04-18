using System;
using System.ServiceProcess;


namespace Service
{
    /// <summary>
    /// Classe qui gère toute la gestion des taches
    /// </summary>
    class GestionTaches
    {
        public void taches()
        {
            ConnexionBDD connexionBDD = new ConnexionBDD();
            // TestGestionDate test = new TestGestionDate();
            // test.test();
            connexionBDD.getConnexion();

            /// <summary>
            ///  CLoture des fiches de frais entre le 1er et le 10 du mois
            /// </summary>
            if (GestionDates.entre(1, 10))
            {
                string moisPrec = GestionDates.getMoisPrecendent();
                string requete = "UPDATE fichefrais SET idetat = 'CL' WHERE mois = '" + moisPrec + "' AND idetat = 'CR'";
                connexionBDD.requeteAdministration(requete);
            }

            /// <summary>
            /// Remboursement des fiches validées au 20e du mois
            /// </summary>
            /// <returns></returns>
            if (GestionDates.entre(20, 31))
            {
                string requete = "UPDATE fichefrais SET idetat = 'RB' WHERE idetat = 'VA'";
                connexionBDD.requeteAdministration(requete);
            }
        }
    }
}
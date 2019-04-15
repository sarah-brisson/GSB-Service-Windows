using System;
using System.ServiceProcess;


namespace Service
{
    // Classe qui gère toute la gestion des taches
    class GestionTaches
    {
        public void taches()
        {
            ConnexionBDD connexionBDD = new ConnexionBDD();
            // TestGestionDate test = new TestGestionDate();
            // test.test();
            connexionBDD.getConnexion();

            // CLoture des fiches de frais entre le 1er et le 10 du mois
            if (GestionDates.entre(1, 10))
            {
                string moisPrec = GestionDates.getMoisPrecendent();
                string requete = "UPDATE fichefrais SET idetat = 'CL' WHERE mois = '" + moisPrec + "'";
                connexionBDD.requeteAdministration(requete);
            }

            // Remboursement des fiches validées au 20e du mois
            if (GestionDates.entre(20, 31))
            {
                string requete = "UPDATE fichefrais SET idetat = 'RB' WHERE idetat = 'VA'";
                connexionBDD.requeteAdministration(requete);
            }
        }
    }
}
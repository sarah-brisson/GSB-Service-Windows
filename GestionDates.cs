using System;

namespace Service

{
    abstract class GestionDates
    {
        private static DateTime dateAujourdhui = DateTime.Now;

        /// <summary>
        /// retourne le mois précédent au mois actuel
        /// </summary>
        /// <returns></returns>
        public static string getMoisPrecendent()
        {
            int an = dateAujourdhui.Year;
            int mois = dateAujourdhui.Month;
            return gestionMoisPrecedent(mois, an);
        }

        /// <summary>
        /// retourne le mois précédent à la date mise en paramètre
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string getMoisPrecendent(DateTime date)
        {
            int an = date.Year;
            int mois = date.Month;
            return gestionMoisPrecedent(mois, an);
        }

        /// <summary>
        /// gère les fonctions getMoisPrecendent
        /// </summary>
        /// <param name="mois"></param>
        /// <param name="an"></param>
        /// <returns></returns>
        private static string gestionMoisPrecedent(int mois, int an)
        {
            String moisPrecedent;
            int annee = an;
            if (mois == 1)
            {
                annee = an - 1;
                moisPrecedent = "12";
            }
            else
            {
                moisPrecedent = (mois - 1).ToString();
            }
            if (moisPrecedent.Length < 2)
            {
                moisPrecedent = '0' + moisPrecedent;
            }
            moisPrecedent = annee + moisPrecedent;
            return moisPrecedent;
        }

        /// <summary>
        /// retourne le mois suivant au mois actuel
        /// </summary>
        /// <returns></returns>
        public static string getMoisSuivant()
        {
            int mois = dateAujourdhui.Month;
            return gestionMoisSuivant(mois);
        }

        /// <summary>
        /// retourne le mois suivant à la date mise en paramètre
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string getMoisSuivant(DateTime date)
        {
            int mois = date.Month;
            return gestionMoisSuivant(mois);
        }

        /// <summary>
        /// gère les fonctions getMoisSuivant
        /// </summary>
        /// <param name="mois"></param>
        /// <returns></returns>
        private static string gestionMoisSuivant(int mois)
        {
            String moisSuivant;
            if (mois == 12)
            {
                moisSuivant = "01";
            }
            else
            {
                moisSuivant = (mois + 1).ToString();
            }
            if (moisSuivant.Length < 2)
            {
                moisSuivant = "0" + moisSuivant;
            }
            return moisSuivant;
        }

        /// <summary>
        /// prend en paramètre deux int de numéros de jours dans le mois dans l'ordre croissant 
        /// retourne vrai si la date actuelle se trouve entre les deux
        /// </summary>
        /// <param name="jour1"></param>
        /// <param name="jour2"></param>
        /// <returns></returns>
        public static Boolean entre(int jour1, int jour2)
        {
            if (dateAujourdhui.Day >= jour1 && dateAujourdhui.Day <= jour2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// prend en paramètre deux int de numéros de jours dans le mois dans l'ordre croissant 
        /// retourne vrai si la date en parametre se trouve entre les deux
        /// </summary>
        /// <param name="jour1"></param>
        /// <param name="jour2"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static Boolean entre(int jour1, int jour2, DateTime date)
        {
            if (date.Day >= jour1 && date.Day <= jour2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

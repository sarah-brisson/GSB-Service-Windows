﻿using System;

namespace Service

{
    abstract class GestionDates
    {
        private static DateTime dateAujourdhui = DateTime.Now;

        //retourne le mois précédent au mois actuel
        public static string getMoisPrecendent()
        {
            int an = dateAujourdhui.Year;
            int mois = dateAujourdhui.Month;
            return gestionMoisPrecedent(mois, an);
        }

        //retourne le mois précédent à la date mise en paramètre
        public static string getMoisPrecendent(DateTime date)
        {
            int an = date.Year;
            int mois = date.Month;
            return gestionMoisPrecedent(mois, an);
        }

        //gère les fonctions getMoisPrecendent
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

        //retourne le mois suivant au mois actuel
        public static string getMoisSuivant()
        {
            int mois = dateAujourdhui.Month;
            return gestionMoisSuivant(mois);
        }

        //retourne le mois suivant à la date mise en paramètre
        public static string getMoisSuivant(DateTime date)
        {
            int mois = date.Month;
            return gestionMoisSuivant(mois);
        }

        //gère les fonctions getMoisSuivant
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

        //prend en paramètre deux int de numéros de jours dans le mois dans l'ordre croissant 
        //retourne vrai si la date actuelle se trouve entre les deux
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

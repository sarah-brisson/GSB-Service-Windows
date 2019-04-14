using System;

namespace Service
{
    class TestGestionDate
    {
        public void test()
        {
            DateTime date = new DateTime(2018, 1, 18);
            DateTime date2 = new DateTime(2018, 12, 18);
            getMoisPrecendentAvecJourActuel();
            getMoisPrecendentAvecDate(date, "12");
            getMoisSuivantAvecJourActuel();
            getMoisSuivantAvecDate(date2, "01");
            entreAvecDateActuelle(12, 15, false);
            entreAvecDatePredefinie(18, 19, date, true);
        }
        public void getMoisPrecendentAvecJourActuel()
        {
            string mois = GestionDates.getMoisPrecendent();
            Console.WriteLine("Doit retourner 201903 : " + mois);
        }
        public void getMoisPrecendentAvecDate(DateTime date, string result)
        {
            string mois = GestionDates.getMoisPrecendent(date);
            Console.WriteLine("Doit retourner " + result + " : " + mois);
        }
        public void getMoisSuivantAvecJourActuel()
        {
            string mois = GestionDates.getMoisSuivant();
            Console.WriteLine("Doit retourner 05 : " + mois);
        }
        public void getMoisSuivantAvecDate(DateTime date, string result)
        {
            string mois = GestionDates.getMoisSuivant(date);
            Console.WriteLine("Doit retourner " + result + " : " + mois);
        }
        public void entreAvecDateActuelle(int jour1, int jour2, Boolean entre)
        {
            Boolean boo = GestionDates.entre(jour1, jour2);
            Console.WriteLine("Doit retourner " + entre + " : " + boo);
        }
        public void entreAvecDatePredefinie(int jour1, int jour2, DateTime date, Boolean entre)
        {
            Boolean boo = GestionDates.entre(jour1, jour2, date);
            Console.WriteLine("Doit retourner " + entre + " : " + boo);
        }
    }
}
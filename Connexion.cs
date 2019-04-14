using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Service
{
    class ConnexionBDD
    {
        public static MySqlConnection connexion;

        //instance unique de la connexion
        private void connexionBase()
        {
            String connexionString = "datasource=localhost; database=gsb_frais;username=root;Password=E6gDn3o;";
            connexion = new MySqlConnection(connexionString);
        }

        // retourne l'instance de la connexion si elle est crée ou la crée et la retourne
        public void getConnexion()
        {

            if (connexion == null)
            {
                connexionBase();
            }
        }

        public void requeteAdministration(string requete)
        {
            try
            {
                connexion.Open();
                Console.WriteLine("connected");
                Console.WriteLine(connexion.Database);
                MySqlCommand command = new MySqlCommand(requete, connexion);
                command.ExecuteNonQuery();
                connexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void requeteSelect(string requete)
        {
            try
            {
                connexion.Open();
                MySqlCommand command = new MySqlCommand(requete, connexion);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.WriteLine(reader.GetValue(i));
                    }
                    Console.WriteLine();
                }
                connexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

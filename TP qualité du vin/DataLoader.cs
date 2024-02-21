using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace TP_qualité_du_vin
{
    internal class DataLoader

    {

        //methode pour recuperer les fichier avec la bibliotheque  csvhelper
        public static List<Vin> ChargerDonneesApprentissage(string cheminFichier)
        {
            List<Vin> donneesApprentissage = new List<Vin>();

            try
            {
                using (StreamReader reader = new StreamReader(cheminFichier))
                using (CsvReader csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" }))
                {
                    // Ignorer la première ligne (en-têtes)
                    csv.Read();

                    while (csv.Read())
                    {
                        float alcool = csv.GetField<float>(0);
                        float sulfate = csv.GetField<float>(1);
                        float acideCitrique = csv.GetField<float>(2);
                        float aciditeVolatile = csv.GetField<float>(3);
                        int qualite = csv.GetField<int>(4);

                        Vin vin = new Vin
                        {
                            Alcool = alcool,
                            Sulfate = sulfate,
                            Acide_citrique = acideCitrique,
                            Acidite_volatile = aciditeVolatile,
                            Qualite = qualite,
                        };
                        donneesApprentissage.Add(vin);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors du chargement des données: " + ex.Message);
            }

            return donneesApprentissage;
        }
    }
}

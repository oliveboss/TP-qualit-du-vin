using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal class DataLoader
    {

        // la classe pour le chargement des fichiers csv pour utilisation dans l,arbre de decision

        public static List<Vin> ChargerDonneesApprentissage(string cheminFichier)
        {
            List<Vin> donneesApprentissage = new List<Vin>();

            try
            {
                using (StreamReader sr = new StreamReader(cheminFichier))
                {
                    // Lire la première ligne pour ignorer les en-têtes parce que ca porte le nom des caracteristiques du vin 
                    string premierLigne = sr.ReadLine();

                    string ligne;
                    while ((ligne = sr.ReadLine()) != null)
                    {
                        string[] elements = ligne.Split(';'); // Supposons que les données sont séparées par des virgules
                        if (elements.Length == 5) // Supposons que chaque ligne a 5 éléments : Alcool, Sulfate, Acide_citrique, Acidité_volatile, Qualité
                        {
                            float alcool = float.Parse(elements[0], CultureInfo.InvariantCulture);
                            float sulfate = float.Parse(elements[1], CultureInfo.InvariantCulture);
                            float acideCitrique = float.Parse(elements[2], CultureInfo.InvariantCulture);
                            float aciditeVolatile = float.Parse(elements[3], CultureInfo.InvariantCulture);
                            int qualite = int.Parse(elements[4], CultureInfo.InvariantCulture);


                            // Créer un nouvel objet Vin en incluant le vignoble
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
                        else
                        {
                            Console.WriteLine("Erreur: Format de ligne invalide.");
                        }
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
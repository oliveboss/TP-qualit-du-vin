using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C'est ceci on va utiliser alaise

            //test  de dataloader
            // Chemin d'accès au fichier CSV contenant les données d'apprentissage"C:\Users\amouz\OneDrive\Bureau\TP qualité du vin\train_reduced.csv"

            string cheminFichier = @"C:\Users\amouz\OneDrive\Bureau\Donnes_D_Apprentissage.csv";// @"C:\Users\Joel Kayemba\OneDrive\Documents\Données - Qualité du Vin(3)\train_reduced.csv"; 

            // Charger les données d'apprentissage à partir du fichier CSV
            List<Vin> donneesApprentissage = DataLoader.ChargerDonneesApprentissage(cheminFichier);

            // Afficher les données d'apprentissage pour vérification
            Console.WriteLine("Données d'apprentissage chargées :");
            foreach (Vin vin in donneesApprentissage)
            {
                vin.Afficher();
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.CodeDom;
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

            Console.WriteLine(" Tester avec les donnes de test ");
            // Créez une liste d'attributs avec les noms corrects
            List<string> attributs = new List<string> { "Alcool", "Sulfate", "Acide_citrique", "Acidite_volatile", "Qualite" };

            // Appelez le constructeur de Arbre_de_decision avec la liste d'attributs
            Arbre_de_decision arbre = new Arbre_de_decision(attributs);

            // Chargez les données d'apprentissage
            string cheminFichierApprentissage = @"C:\Users\amouz\OneDrive\Bureau\Donnes_D_Apprentissage.csv";
            List<Vin> donneesApprentissage = DataLoader.ChargerDonneesApprentissage(cheminFichierApprentissage);

            // Construisez l'arbre de décision avec les données d'apprentissage
            arbre.ConstruireArbre(donneesApprentissage,attributs);

            // Chargez les données de test
            string cheminFichierTest = @"C:\Users\amouz\OneDrive\Bureau\test_reduced.csv";
            List<Vin> donneesTest = DataLoader.ChargerDonneesApprentissage(cheminFichierTest);

            // Testez l'arbre de décision avec les données de test
            foreach (Vin vin in donneesTest)
            {
                int prediction = arbre.Predire(vin);
                Console.WriteLine($"Attributs : Alcool={vin.Alcool}, Sulfate={vin.Sulfate}, Acide_citrique={vin.Acide_citrique}, Acidite_volatile={vin.Acidite_volatile}, \n Qualite (vraie)={vin.Qualite}, Qualite (prédite)={prediction}");
            }

            Console.ReadKey();

        }
    }
}

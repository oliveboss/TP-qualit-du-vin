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

            // Chemin du fichier contenant les données d'apprentissage
            string cheminFichierApprentissage = @"C:\Users\amouz\OneDrive\Bureau\Donnes_D_Apprentissage.csv";

            // Charger les données d'apprentissage depuis le fichier
            List<Vin> donneesApprentissage = DataLoader.ChargerDonneesApprentissage(cheminFichierApprentissage);

            // Nombre de folds pour la validation croisée
            int nombreFolds = 5;
            
            // Effectuer la validation croisée et obtenir la précision moyenne
            double precisionMoyenne = Performance.ValidationCroisee(donneesApprentissage, nombreFolds);

            // Afficher la précision moyenne sur la validation croisée
            Console.WriteLine($"Précision moyenne sur la validation croisée (nombre de plis = {nombreFolds}): {precisionMoyenne:P}");

            // Créer un objet Arbre_de_decision avec les données d'apprentissage
            Arbre_de_decision arbre = new Arbre_de_decision(new List<string> { "Alcool", "Sulfate", "Acide_citrique", "Acidite_volatile", "Qualite" });
            arbre.ConstruireArbre(donneesApprentissage, new List<string> { "Alcool", "Sulfate", "Acide_citrique", "Acidite_volatile", "Qualite" });

            // Chemin du fichier contenant les données de test
            string cheminFichierTest = @"C:\Users\amouz\OneDrive\Bureau\test_reduced.csv";

            // Charger les données de test depuis le fichier
            List<Vin> donneesTest = DataLoader.ChargerDonneesApprentissage(cheminFichierTest);

            // Évaluer le modèle sur l'ensemble de test indépendant
            double precisionTest = Performance.EvaluerModele(arbre, donneesTest);
            
            // Afficher la précision sur l'ensemble de test indépendant
            Console.WriteLine($"Précision sur l'ensemble de test indépendant: {precisionTest:P}");
        }

    }
}

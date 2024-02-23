using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal class Performance
        
    {
        public static double ValidationCroisee(List<Vin> donneesApprentissage, int folds, int maxDepth, int minSamplesSplit)
        {
            Random rand = new Random();
            List<Vin> donneesMelangees = donneesApprentissage.OrderBy(x => rand.Next()).ToList();

            List<List<Vin>> sousEnsembles = new List<List<Vin>>();
            int tailleSousEnsemble = donneesMelangees.Count / folds;
            for (int i = 0; i < folds; i++)
            {
                int debutIndex = i * tailleSousEnsemble;
                int finIndex = (i == folds - 1) ? donneesMelangees.Count : (i + 1) * tailleSousEnsemble;
                sousEnsembles.Add(donneesMelangees.GetRange(debutIndex, finIndex - debutIndex));
            }

            double sommePrecision = 0.0;
            foreach (var sousEnsemble in sousEnsembles)
            {
<<<<<<< HEAD
                List<Vin> donneesValidation = sousEnsemble;
                List<Vin> donneesEntrainement = donneesMelangees.Except(donneesValidation).ToList();

                Arbre_de_decision arbre = new Arbre_de_decision(new List<string> { "Alcool", "Sulfate", "Acide_citrique", "Acidite_volatile", "Qualite" });
                arbre.ConstruireArbre(donneesEntrainement, new List<string> { "Alcool", "Sulfate", "Acide_citrique", "Acidite_volatile", "Qualite" }, maxDepth, minSamplesSplit);

                double precision = EvaluerModele(arbre, donneesValidation);
                sommePrecision += precision;
=======
                return 1; //chercher comment retourner la prédiction de la qualité
>>>>>>> 8ad42724d91fade1e7ddbde20f66dd792ed3a735
            }

            double precisionMoyenne = sommePrecision / folds;
            return precisionMoyenne;
        }

        public static double EvaluerModele(Arbre_de_decision arbre, List<Vin> donnees)
        {
            int predictionsCorrectes = 0;

            foreach (Vin instance in donnees)
            {
                int prediction = arbre.Predire(instance);
                if (prediction == instance.Qualite)
                {
                    predictionsCorrectes++;
                }
            }

            double precision = (double)predictionsCorrectes / donnees.Count;
            return precision;
        }




      

        /*



                public static Dictionary<string, object> TrouverMeilleursHyperparametres(List<Vin> trainingData, List<Vin> validationData, List<string> attributs, Dictionary<string, List<object>> paramGrid)
                {
                    double bestScore = double.MinValue;
                    Dictionary<string, object> bestParams = null;

                    foreach (var paramSet in GenerateParamCombinations(paramGrid))
                    {
                        Arbre_de_decision arbre = new Arbre_de_decision(attributs);

                        // Mettre à jour les paramètres de l'arbre de décision
                        foreach (var kvp in paramSet)
                        {
                            // Configurer les paramètres de l'arbre de décision en fonction des valeurs du paramètre
                            if (kvp.Key == "profondeur_max")
                            {
                                arbre.SetParam("ProfondeurMax", (int)kvp.Value);
                            }
                            else if (kvp.Key == "autre_parametre")
                            {
                                arbre.SetParam("AutreParametre", (string)kvp.Value);
                            }
                            // Ajoutez d'autres conditions pour chaque paramètre que vous souhaitez configurer
                        }

                        // Construire l'arbre avec les données d'entraînement
                        arbre.ConstruireArbre(trainingData, attributs);

                        // Évaluer les performances sur les données de validation
                        double score = EvaluerModele(arbre, validationData);

                        // Mettre à jour les meilleurs paramètres si le score est meilleur
                        if (score > bestScore)
                        {
                            bestScore = score;
                            bestParams = paramSet;
                        }
                    }

                    return bestParams;
                }

                private static IEnumerable<Dictionary<string, object>> GenerateParamCombinations(Dictionary<string, List<object>> paramGrid)
                {
                    if (paramGrid.Count == 0)
                    {
                        yield return new Dictionary<string, object>();
                        yield break;
                    }

        public float CalculPerformance()
        {
           if (vin == null|| qualité==null) 
            {
                return 0;
            }
            else
            {
                return 1; //notre formule à la place de 1
            }
        }
    }
}



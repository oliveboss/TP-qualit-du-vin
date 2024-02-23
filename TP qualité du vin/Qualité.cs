using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal class Qualité
    {
       // private int Quality { get; set; }

<<<<<<< HEAD
        public static void Afficher(int Quality)
=======
        public Qualité(int quality)
        {
            Quality = quality;
        }

        public void Afficher()
>>>>>>> 8ad42724d91fade1e7ddbde20f66dd792ed3a735
        {
            if (Quality >= 3 && Quality <= 4)
            {
<<<<<<< HEAD
                Console.WriteLine("La qualité du vin est plus ou moins moyenne .");
            }
            else if (Quality >= 5 && Quality <= 8)
            {
                Console.WriteLine("La qualité du vin est bonne.");
            }
            else if (Quality >= 9 && Quality <= 10)
            {
                Console.WriteLine("La qualité du vin est excellente.");
            }
            else
            {
                Console.WriteLine("La qualité du vin n'est pas définie.");
=======
                case 3: 
                    Console.WriteLine("La qualité du vin est moyenne ou basse.");
                    break;
                case 6:
                    Console.WriteLine("La qualité du vin est bonne.");
                    break;
                case 9:
                    Console.WriteLine("La qualité du vin est excellente.");
                    break;
                default:
                    Console.WriteLine("La qualité du vin n'est pas définie.");
                    break;
>>>>>>> 8ad42724d91fade1e7ddbde20f66dd792ed3a735
            }
        }

    }
}

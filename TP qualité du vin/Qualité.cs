using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal class Qualité
    {
        private int Quality { get; set; }

        public Qualité(int quality)
        {
            Quality = quality;
        }

        public void Afficher()
        {
            switch (Quality)
            {
                case 3: 
                    Console.WriteLine("La qualité du vin est d'une qualité moyenne ou basse.");
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
            }



        }
    }
}

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

        public void Afficher()
        {
            switch (Quality)
            {
                case 0: // c'est juste un exemple
                    Console.WriteLine("La qualité du vin est d'une qualité moyenne ou basse.");
                    break;
                case 1:
                    Console.WriteLine("La qualité du vin est bonne.");
                    break;
                case 2:
                    Console.WriteLine("La qualité du vin est excellente.");
                    break;
                default:
                    Console.WriteLine("La qualité du vin n'est pas définie.");
                    break;
            }



        }
    }
}

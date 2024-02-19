using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal class Vin
    {
        private float Alcool { get; set; }
        private float Sulfate { get; set; }
        private float Acide_citrique { get; set; }
        private float Acidité_volatile { get; set; }
        private Vignoble Vignoble { get; set; }

        public void Afficher()
        {
            Console.WriteLine("Alcool: " + Alcool + "\nSulfate:" + Sulfate + "\nAcide citrique: " + Acide_citrique + "\nAcidité volatile: " + Acidité_volatile + "\nVignoble: " + Vignoble);
        }
    }
}

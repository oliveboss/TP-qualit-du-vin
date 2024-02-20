using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal class Vin
    {
        private float alcool;
        private float sulfate;
        private float acide_citrique;
        private float acidite_volatile;
        private int qualite;
        public float Alcool
        {
            get { return alcool; }
            set { alcool = value; }
        }

        public float Sulfate
        {
            get { return sulfate; }
            set { sulfate = value; }
        }

        public float Acide_citrique
        {
            get { return acide_citrique; }
            set { acide_citrique = value; }
        }
        public float Acidite_volatile
        {
            get { return acidite_volatile; }
            set { acidite_volatile = value; }
        }

        public int Qualite
        {
            get { return qualite; }
            set { qualite = value; }
        }

        // private Vignoble Vignoble { get; set; }

        public void Afficher()
        {
            Console.WriteLine("Alcool: " + Alcool + "\nSulfate:" + Sulfate + "\nAcide citrique: " + Acide_citrique + "\nAcidité volatile: " + Acidite_volatile );
        }
    }
}

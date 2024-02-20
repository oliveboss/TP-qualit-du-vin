using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal class Terrain
    {
        private float longueur;
        private float largeur;

        public float Surface(float longueur, float largeur)
        {
            return longueur * largeur;
        }

        public void Afficher()
        {
            Console.WriteLine("Le terrain a une longueur de " + longueur + "et une largeur de " + largeur);
        }

        
    }
}

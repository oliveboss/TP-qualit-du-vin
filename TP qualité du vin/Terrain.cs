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
        private float Longueur {  get; set; }
        private float Largeur { get; set; }

        public Terrain(float longueur, float largeur)
        {
            Longueur = longueur;
            Largeur = largeur;
        }

        public float Surface(float longueur, float largeur)
        {
            return longueur * largeur;
        }

        public void Afficher()
        {
            Console.WriteLine("Le terrain a une surface de "+ Longueur * Largeur + " mettre carré");
        }

        
    }
}

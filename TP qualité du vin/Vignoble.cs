using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal class Vignoble
    {
        private Propriétaire Propriétaire { get; set; }
        private Terrain Terrain { get; set; }

        public List<Vin> Vins { get; set; } = new List<Vin>();

        public Vignoble(Propriétaire propriétaire, Terrain terrain)
        {
            Propriétaire = propriétaire;
            Terrain = terrain;
        }

        public void Afficher()
        {
            if (Terrain != null)
            {
               Terrain.Afficher();
                
            }
            else
            {
                Console.WriteLine("Aucun terrain n'est associé à ce vignoble");
            }

            
            if (Propriétaire != null)
            {
                Propriétaire.Afficher();
            }
            else
            {
                Console.WriteLine("Aucun propriétaire n'est associé à ce vignoble");
            }
        }
    }
}

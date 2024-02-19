using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal class Vignoble
    {
        private Propriétaire propriétaire;
        private Terrain terrain;

        public void Afficher()
        {
            if (terrain != null)
            {
                Console.WriteLine("Afficher terrain");
                
            }
            else
            {
                Console.WriteLine("Aucun terrain n'est associé à ce vignoble");
            }

            
            if (propriétaire != null)
            {
                Console.WriteLine("Afficher propriétaire");
            }
            else
            {
                Console.WriteLine("Aucun propriétaire n'est associé à ce vignoble");
            }
        }
    }
}

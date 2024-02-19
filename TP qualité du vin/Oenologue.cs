using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal class Oenologue:Client
    {
        private Vin vin;
        public override void Afficher()
        {
            Console.WriteLine("Nom: " + nom + "\nPrenom: " + prenom + "\nAge: " + age);

        }

        public void EvaluerQualitéVin()
        {
            if (vin == null)
            {
                Console.WriteLine("Aucun vin n'est associé");
               
            }

        }

    }
}

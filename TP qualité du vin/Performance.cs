using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal class Performance
    {
        private Vin vin;
        private Qualité qualité;

        public float CalculPerformance()
        {
           if (vin == null|| qualité==null) 
            {
                return 0;
            }
            else
            {
                return 1; //chercher comment retourner la prédiction de la qualité
            }
        }
    }
}

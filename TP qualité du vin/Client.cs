using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal abstract class Client
    {
        protected string nom;
        protected string prenom;
        protected int age;

        public abstract void Afficher();
    }
}

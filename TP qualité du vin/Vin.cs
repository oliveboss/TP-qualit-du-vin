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

        // Méthode pour obtenir la valeur d'un attribut par son nom
        public object GetAttributeValue(string attributeName)
        {
            switch (attributeName)
            {
                case "Alcool":
                    return Alcool;
                case "Sulfate":
                    return Sulfate;
                case "Acide_citrique":
                    return Acide_citrique;
                case "Acidite_volatile":
                    return Acidite_volatile;
                case "Qualite":
                    return Qualite;
                default:
                    throw new ArgumentException("Nom d'attribut invalide.");
            }
        }
    }
}

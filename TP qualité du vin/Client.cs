﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal abstract class Client
    {
        protected string Nom {  get; set; }
        protected string Prenom {  get; set; }
        protected int Age { get; set; }

        public abstract void Afficher();

        
    }
}

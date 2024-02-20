using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_qualité_du_vin
{
    internal  class Node
    {
        public string Attribute { get; set; }
        public Dictionary<string, Node> Children { get; set; }
        public string Class { get; set; }
        public double? SplitValue { get; set; }
    }
}

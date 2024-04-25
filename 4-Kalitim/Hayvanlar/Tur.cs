using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance.Hayvanlar
{
    public class Tur : FizikselOzellikler
    {
        public string LatinceIsim { get; set; }
        public string YerelIsim { get; set; }
        public bool EhlilestirilebilirMi { get; set; }
    }
}

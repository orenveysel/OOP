using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance.Hayvanlar
{
    public class FizikselOzellikler : Habitat
    {
        public double KanatAcikligi { get; set; }
        public double EriskinAgirlik { get; set; }
        public int YasamOmru { get; set; }
        public List<KnownColor> Renkleri { get; set; }
        public bool EtcilMi { get; set; }
    }
}

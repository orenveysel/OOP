using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance.Bilgisayar
{
    public class Bilgisayar
    {
        public CPU Cpu { get; set; }
        public List<Ram> Ramler { get; set; }
        public AnaKart AnaKart { get; set; }
        public Kasa Kasa { get; set; }
    }
}

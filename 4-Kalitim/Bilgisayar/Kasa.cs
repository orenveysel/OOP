using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance.Bilgisayar
{
    public enum KasaTipi
    {
        Mini,
        Midi,
        Tower,
        BigTower
    }

    public class Kasa : Item
    {
        public PowerSupplier PowerSupplier { get; set; }
        public KasaTipi KasaTipi { get; set; }

    }
}

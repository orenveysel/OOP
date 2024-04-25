using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance.Bilgisayar
{
    public class Ram : Item
    {
        public int Kapasite { get; set; }
        public RamTipi RamTipi { get; set; }
    }
}

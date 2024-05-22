using _14_InterfaceFutbol.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_InterfaceFutbol.Concrete
{
    public class Forvet : BaseFutbolcu, IForvet
    {
        public void GolAt()
        {
            Console.WriteLine(AdSoyad + " Gol Atti");
        }

        public void PenaltiCek()
        {
            Console.WriteLine(AdSoyad + " Penalti Kullandi");
        }
    }
}

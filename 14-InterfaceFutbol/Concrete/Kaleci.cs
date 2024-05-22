using _14_InterfaceFutbol.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_InterfaceFutbol.Concrete
{
    public class Kaleci : BaseFutbolcu, IKaleci
    {
        public void DegajYap()
        {
            Console.WriteLine(AdSoyad + " Degaj Yapti");
        }

        public void PenaltiKurtar()
        {
            Console.WriteLine(AdSoyad + " Penalti kurtardi");
        }

        public void TopuElleYakala()
        {
            Console.WriteLine(AdSoyad + " topu yakaladi");
        }
    }
}

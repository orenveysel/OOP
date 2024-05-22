using _14_InterfaceFutbol.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_InterfaceFutbol.Concrete
{
    public class Defans : BaseFutbolcu, IDefans
    {
        public void DefansYap()
        {
            Console.WriteLine(AdSoyad + " Defans Yapti");
        }

        public void TopGecerAdamGecmez()
        {
            Console.WriteLine(AdSoyad + " Savunma Yapti");
        }
    }
}

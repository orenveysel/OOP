using _14_InterfaceFutbol.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_InterfaceFutbol.Concrete
{
    public class OrtaSaha : BaseFutbolcu, IOrtaSaha
    {
        public void OyunuKur()
        {
            Console.WriteLine(AdSoyad + " Oyun Kurdu");
        }

        public void PasTrafigiYap()
        {
            Console.WriteLine(AdSoyad + " Pas Yapti");
        }

        public void PressYap()
        {
            Console.WriteLine(AdSoyad + " Pres Yapti");
        }
    }
}

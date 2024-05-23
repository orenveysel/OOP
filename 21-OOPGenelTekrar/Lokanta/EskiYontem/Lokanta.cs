using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOPGenelTekrar.Lokanta.EskiYontem
{
    public class Lokanta
    {
        public void YemekPisir(Tavuk tavuk)
        {
            tavuk.Pisir();
        }
        public void YemekPisir(Pilav pilav)
        {
            pilav.Pisir();
        }
        public void YemekPisir(Pilav pilav,Tavuk tavuk)
        {
            pilav.Pisir();
            tavuk.Pisir();
        }
    }
}

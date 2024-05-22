using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceFirin.Lokanta
{
    public class BorsaLokantasi
    {
        public void YemekPisir(Tavuk tavuk)
        {
            tavuk.Pisir();
        }
        public void YemekPisir(Tavuk tavuk,Pilav pilav)
        {
            tavuk.Pisir();
            pilav.Pisir();
        }
        public void YemekPisir(Tavuk tavuk, Pilav pilav,KuruFasulye kuruFasulye)
        {
            tavuk.Pisir();
            pilav.Pisir();
            kuruFasulye.Pisir();
        }
        public void YemekPisir(Tavuk tavuk, Pilav pilav, KuruFasulye kuruFasulye,Kofte kofte)
        {
            tavuk.Pisir();
            pilav.Pisir();
            kuruFasulye.Pisir();
            kofte.Pisir();
        }
    }
}

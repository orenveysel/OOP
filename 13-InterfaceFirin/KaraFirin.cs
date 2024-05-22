using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceFirin
{
    public class KaraFirin
    {
        //public void EkmekPisir(Usta usta)
        // {
        //     usta.HamurYogur();
        // }

        // public void EkmekPisir(Makina makina)
        // {
        //     makina.HamurYogur();b
        // }

        public void EkmekPisir(IYogurma yogurucu)
        {
            yogurucu.HamurYogur();
        }
    }
}

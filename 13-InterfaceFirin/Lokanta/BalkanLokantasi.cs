using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceFirin.Lokanta
{
    public class BalkanLokantasi
    {
        public void YemekPisir(List<IPisir> pisirilecekler)
        {
            foreach (var item in pisirilecekler)
            {
                item.Pisir();
            }
        }
    }
}

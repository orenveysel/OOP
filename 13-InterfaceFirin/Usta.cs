using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceFirin
{
    public class Usta : IYogurma
    {
        public string AdSoyad { get; set; }

        public void HamurYogur()
        {
            Console.WriteLine(AdSoyad + " Hamur Yagurdu");
        }
    }
}

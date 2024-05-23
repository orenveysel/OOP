using _21_OOPGenelTekrar.Lokanta.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOPGenelTekrar.Lokanta.Concrete
{
    public class Piyaz : IPisirilebilir
    {
        public string Name { get  ; set ; }

        public void Pisir()
        {
            Console.WriteLine(Name + " pişirildi");
        }
    }
}

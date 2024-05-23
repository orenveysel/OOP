using _21_OOPGenelTekrar.Lokanta.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOPGenelTekrar.Lokanta.Concrete
{
    public class KuruFasulye : IPisirilebilir,IIsıtılabilir,ISaklanabilir,IServisEdilebilir,ISatinAlinabilir
    {
        public string Name { get; set; }

        public void Isit()
        {
            throw new NotImplementedException();
        }

        public void Pisir()
        {
            Console.WriteLine(Name + " pişirildi");
        }

        public void SatinAl()
        {
            throw new NotImplementedException();
        }

        public void ServisEt()
        {
            throw new NotImplementedException();
        }
    }
}

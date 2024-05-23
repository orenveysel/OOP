using _21_OOPGenelTekrar.Lokanta.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOPGenelTekrar.Lokanta.Concrete
{
    public class Cacik : ISaklanabilir, IServisEdilebilir
    {
        public void CacikYap(List<Salatalik> salataliks)
        {
            Console.WriteLine("Cacik Yapildi");
        }
        public void ServisEt()
        {
            throw new NotImplementedException();
        }
    }
}

using _14_InterfaceFutbol.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_InterfaceFutbol.Concrete
{
    public class Takim
    {
        //readonly filed alanlarina sadece tanimlandiklari yerde 
        // Yada Constructer icerisinde atama yapilabilir
        private readonly List<BaseFutbolcu> _futbolcular;
        
        public Takim(List<BaseFutbolcu> futbolcular)
        {
            _futbolcular = futbolcular;
        }

        public override string ToString()
        {

            string sonuc = "";
            foreach (var item in _futbolcular)
            {
                sonuc += item.AdSoyad + "=>" + item.Mevki + "\n";
            }

            return sonuc;
        }
    }
}

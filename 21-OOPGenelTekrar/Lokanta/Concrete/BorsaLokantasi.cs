using _21_OOPGenelTekrar.Lokanta.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOPGenelTekrar.Lokanta.Concrete
{
    public class BorsaLokantasi
    {       
        public List<IPisirilebilir> _menu { get; set; }
        public void YemekPisir(List<IPisirilebilir> menu)
        {
            _menu = menu;
            foreach (var item in menu)
            {
                item.Pisir();
            }
        }
        public void YemekPisir2(ICollection<IPisirilebilir> menu)
        {
            
            foreach (var item in menu)
            {
                item.Pisir();
            }
        }
        public void YemekPisir3(IEnumerable<IPisirilebilir> menu)
        {

            foreach (var item in menu)
            {
                item.Pisir();
            }
        }
        public void ServiseYap(List<IServisEdilebilir> servisEdilebilirs)
        {

        }

        public void SatinaAl(List<ISatinAlinabilir> satinAlinabilirs)
        {

        }

        public void LokantiyiKapat(List<ISaklanabilir> lokantiyiKapat)
        {

        }
    }
}

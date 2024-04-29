using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor.Personeller
{
    public class Adres
    {

        /*
         * 
         * ReadOnly Property'ler Sadece Constructer icerisinden deger atanabilir.
         * Başka da Tanimlandigi yerde ilk deger atamasi yapilabilir.
         * 
         * Birde readonly keyword degiskenler icin kullanilabilir
         * Orad ada 
         * public readonly string postakodu;
         */
        public readonly string postakodu = "34340";
        public string Ulke { get; } = "Almanya";
        public string Sehir { get; private set; }
        public string Ilce { get; set; }
        public string CaddeSokak { get; set; }
        public string PostaKodu { get; set; }
        public int KapiNo { get; set; }
        public Adres()
        {
            Sehir = "Istanbul";
            Ulke = "Turkiye";
            postakodu = "23424";
        }

        public void Test()
        {
            //Ulke = "fsdsd";
            //Sehir = "sdfsd";
            //postakodu = "sdf";
        }

    }
}

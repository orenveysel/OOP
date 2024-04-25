using _4_Inheritance.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance.Kutuphane
{
    public enum UyeTipi
    {
        Ogrenci,
        Akademisyen,
        Arastirmaci,
        SiradanVatandas
    }

    public class Uye : Kisi
    {
        public UyeTipi UyeTipi { get; set; }
    }
}

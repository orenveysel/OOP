using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance.Kutuphane
{
    public class Kitap

    {
        public string Ad { get; set; }
        public Yazar Yazar { get; set; }
        public int SayfaSayisi { get; set; }
        public int Fiyat { get; set; }
        public KitapKategorileri Katagori { get; set; }
    }
}

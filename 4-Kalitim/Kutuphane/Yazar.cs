using _4_Inheritance.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance.Kutuphane
{
    public class Yazar : Kisi
    {
        // Dogum Tarihi 15 yasindan kucuk olmasın
        public DateTime DogumTarihi { get; set; }
        public List<Kitap> Kitaplar { get; set; }
    }
}

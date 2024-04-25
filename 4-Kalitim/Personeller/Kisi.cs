using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance.Personeller
{
    public class Kisi : Adres
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public bool Cinsiyet { get; set; }
        public string GobekAdi { get; set; }
        // public Adres Adres { get; set; }

        public string KisiBilgileriVer()
        {
            return $"Adi:{Ad}\nSoyadi:{Soyad}\nSehir:{Sehir}";
        }

        // object veri tipinden gelen ToString() metodunu ezip yerine kendi kodlarimin calistirilmasini istiyorum
        public override string ToString()
        {
            return $"Adi:{Ad}\nSoyadi:{Soyad}\nSehir:{Sehir}";
        }
    }
}

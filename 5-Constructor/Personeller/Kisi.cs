using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor.Personeller
{
    public class Kisi : Adres
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public bool Cinsiyet { get; set; }

        public Kisi(string ad, string soyad, bool cinsiyet)
        {
            if (!string.IsNullOrEmpty(ad) && string.IsNullOrEmpty(soyad))
            {
                Ad = ad;
                Soyad = soyad;
                Cinsiyet = cinsiyet;

                Sehir = "Istanbul";
                Ulke = "Turkiye";
                Ilce = "Kadikoy";
            }
            else
            {
                throw new Exception("Isim ve Soyisim alanlari bos gecilemez");
            }
            
            // Eger Adres Class'i kalitim vermeseydi Property olarak tanimlanabilirdi
            // Boyle bir durumda bu Property'yi new'lemek gerekir
            //Adres adres = new Adres { Sehir = "Istanbul", Ilce = "Kadikoy", Ulke = "Turkiye" };
        }

        public string KisiBilgileriVer()
        {
            return $"Adi:{Ad}\nSoyadi:{Soyad}\nSehir:{Sehir}";
        }
    }
}

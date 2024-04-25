using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor
{
    public class Otomobil
    {
        /*
         * Constructor => Yapici Metod bir siniftan instance alindiginda ilk calisan ozel bir metoddur
         * Bu metodun geri donus tipi yoktur
         * Sinif ile ayni isimde olmak zorundadir
         * Nesne ilk olusturuldugunda disaridan parametre almak icin ya da bazi property'lere default deger vermek icin Constructor kullanilir
         */

        // Bos yapici metod
        public Otomobil()
        {
            Renk = KnownColor.White;
        }

        // 1. Overload edilmis metod
        public Otomobil(string marka)
        {
            Marka = marka;
        }

        public Otomobil(string marka, string model)
        {
            Marka = marka;
            Model = model;
        }

        public Otomobil(string marka, string model, KnownColor renk)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
        }

        #region Ozellikler
        public string Marka { get; set; }
        public string Model { get; set; }
        public KnownColor Renk { get; set; }
        #endregion

        #region Yetenekler
        public void Start()
        {

        }
        public void Stop()
        {

        }
        public void KlimaCalistir()
        {

        } 
        #endregion
    }
}

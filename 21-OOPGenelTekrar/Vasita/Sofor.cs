using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOPGenelTekrar.Vasita
{
    public class Sofor
    {
        private readonly Otomobil otomobil;
        private readonly Minibus minibus;
        private readonly Otobus otobus;

        public Sofor(Otomobil otomobil)
        {
            this.otomobil = otomobil;
        }

        public  Sofor(Minibus minibus)
        {
            this.minibus = minibus;
        }
        public Sofor(Otobus otobus)
        {
           this.otobus = otobus;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizm.AlanHesabi
{
    public class DikDortgen
    {
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }
        public int AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }

        public int CevreHesapla()
        {
            return 2 * (KisaKenar + UzunKenar);
        }
    }
}

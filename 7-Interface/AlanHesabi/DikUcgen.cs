using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizm.AlanHesabi
{
    public class DikUcgen
    {
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }
        public int AlanHesapla()
        {
            return (KisaKenar * UzunKenar) / 2;
        }

        public int CevreHesapla()
        {
            return 2 * (KisaKenar + UzunKenar);
        }
    }
}

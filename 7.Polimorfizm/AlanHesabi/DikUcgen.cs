﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Polimorfizm.AlanHesabi
{
    public class DikUcgen:Sekil
    {
        public override double AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }

        public override double CevreHesapla()
        {
            return 2 * (KisaKenar + UzunKenar);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor.Personeller
{
    public class ITPersonel : Personel
    {
        public ITPersonel(string ad, string soyad, bool cinsiyet) : base(ad, soyad, cinsiyet)
        {
            Departman = Departman.IT;
            Maas += 10000;

            Console.WriteLine(Ulke);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceFirin.Lokanta
{
    public class KuruFasulye : IPisir
    {
        public void Pisir()
        {
            Console.WriteLine("KuruFasulye Pisti");
        }
    }
}

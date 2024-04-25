using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance.Hayvanlar.Genel
{
    public enum SolunumTipi
    {
        Solungac,
        Akciger
    }

    public class Baliklar : BaseHayvan
    {
        public SolunumTipi SolunumTipi { get; set; }

        // Yetenekleri: yuzebilir, ucabilir, beslenme

        public void Yumurtlayabilir()
        {

        }
    }
}

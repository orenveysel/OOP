using _18_InterfaceInsanKaynaklari.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_InterfaceInsanKaynaklari.Abstract
{
    public abstract class BaseBasvuru
    {
        public Kisi Kisi { get; set; }
        public string BitirdigiUniversite { get; set; }
        public bool UzaktanCalisabilir { get; set; }
        public Departman    Departman { get; set; }
    }
}

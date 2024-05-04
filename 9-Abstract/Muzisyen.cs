using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Abstract
{
    public class Muzisyen
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public Gitar CaldigiMuzikAleti { get; set; }
        public Piyano CaldigiDigerMuzikAleti { get; set; }
        public Flut CaldigiNefesli { get; set; }

        public List<MuzikAleti> CaldigiAletler { get; set; }
        public Muzisyen()
        {
            CaldigiAletler = new List<MuzikAleti>();
        }
    }
}

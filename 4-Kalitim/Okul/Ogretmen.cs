using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance.Okul
{
    public class Ogretmen : BaseKisi
    {
        public Brans Brans { get; set; }
        public CalismaSaatleri CalismaSaatleri { get; set; }
    }
}

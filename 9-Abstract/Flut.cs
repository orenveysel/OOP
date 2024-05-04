using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Abstract
{
    public class Flut : MuzikAleti
    {
        public override string Marka { get; set; }
        public override string Model { get; set; }

        public override string Cal()
        {
            return "Flut Caldi";
        }
    }
}

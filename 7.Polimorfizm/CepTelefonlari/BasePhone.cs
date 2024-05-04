using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Polimorfizm.CepTelefonlari
{
    public class BasePhone
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public virtual void CallSound()
        {
            Console.WriteLine("Telefon Caldi");
        }
    }
}

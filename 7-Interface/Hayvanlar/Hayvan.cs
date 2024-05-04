using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizm.Hayvanlar
{
    public class Hayvan
    {
        // Virtual keyword kalitim verilen yerlerde bu metodu yeniden tanimlayabiliriz demek
        // bu metod override edilebilir demektir
        public virtual void SesCikar() 
        {
            Console.WriteLine("Hirrr");
        }
        public virtual void HareketEt()
        {

        }
    }
}

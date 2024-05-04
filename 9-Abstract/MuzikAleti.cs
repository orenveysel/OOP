using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Abstract
{

    // Abstract class'lar sadece kalitim veririr. 
    // Instance Alinamaz

    public abstract class MuzikAleti
    {
        public abstract string Marka { get; set; }
        public abstract string Model { get; set; }

        //Abstract metodlarin Govdesi olmaz.
        //Kalitim verdigi class'larda mutlaka implemente edilmeleri yani
        // Metod govdesinin yazilmasi zorunludur.

        //Abstract metodlar ancak abstract class'lar icerisinde bulunabilir.
        //Abstrat olarak isaretlenmis tum yapilar mutlaka override edilmek zorundadir.
        public abstract string Cal();

        //virtaul olarak isaretlenmis metodlara govde yazilabilir
        // abstract olsun olmasin her class'ta tanimlananabilir
        public virtual void AkordYap()
        {
            Console.WriteLine("Muzik aleti Akord Edildi");
        }
    }
}

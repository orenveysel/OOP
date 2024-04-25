using _4_Inheritance.Hayvanlar;
using _4_Inheritance.Personeller;
using System.Drawing;

namespace _4_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();
            Sekreter sekreter = new Sekreter();
            sekreter.Sehir = "Istanbul";
            sekreter.Ad = "Ayse";
            sekreter.Soyad = "Kaya";
            //Console.WriteLine(sekreter.KisiBilgileriVer());
            Console.WriteLine(sekreter);

            Console.WriteLine(obj);

            Temp temp = new Temp();
            Console.WriteLine(temp.ToString());


            MuhasebePersoneli muhasebe = new MuhasebePersoneli();
            muhasebe.Sehir = "Izmir";


            //Karga karga = new Karga();
            //System.Drawing.Color siyah = new();

            //karga.Renkleri = new List<KnownColor>();
            //karga.Renkleri.Add(KnownColor.Blue);
            //karga.Renkleri.Add(KnownColor.Black);

            Console.WriteLine("Hello, World!");
        }
    }
}

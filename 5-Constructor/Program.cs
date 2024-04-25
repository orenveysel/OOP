using _5_Constructor.Personeller;

namespace _5_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Otomobil kartal = new Otomobil();
            //kartal.Marka = "Tofas";
            //kartal.Model = "Kartal";
            //kartal.Renk = System.Drawing.KnownColor.White;

            //// Bu sekildeki kullanima yapici metodu olan kullanim bicimi denir
            //Otomobil serce = new Otomobil("Tofas","Serce", System.Drawing.KnownColor.White);


            ItPersonel ali = new ItPersonel("Ali", "Yilmaz", false);
            Sekreter ayse = new Sekreter("Ayse", "Kaya", true);

            Console.WriteLine("Hello, World!");
        }
    }
}

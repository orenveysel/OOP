using _4_Inheritance.Personeller;

namespace _4_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sekreter sekreter = new Sekreter();
            sekreter.Sehir = "Istanbul";
            
            MuhasebePersoneli muhasebe = new MuhasebePersoneli();
            muhasebe.Sehir = "Izmir";
            Console.WriteLine("Hello, World!");
        }
    }
}

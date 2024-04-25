using _4_Kalitim.Personeller;

namespace _4_Kalitim
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

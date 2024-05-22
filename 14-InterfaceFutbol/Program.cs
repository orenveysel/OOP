using _14_InterfaceFutbol.Abstract;
using _14_InterfaceFutbol.Concrete;

namespace _14_InterfaceFutbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<BaseFutbolcu> futbolcular = new List<BaseFutbolcu>();

            IKaleci kaleci = new Kaleci();
            kaleci.DegajYap();
            BaseFutbolcu kaleci2 = new Kaleci();
            IFutbolcu kaleci3 = new Kaleci();
            Kaleci kaleci4 = new Kaleci() { AdSoyad = "Ali Yilmaz", Mevki = Mevki.Kaleci };
            futbolcular.Add(kaleci4);
            
            Defans takozRecep = new Defans();
            takozRecep.AdSoyad = "Takoz Recep";
            takozRecep.Mevki = Mevki.Defans;

            IDefans defans = new Defans();


            BaseFutbolcu defans2 = new Defans();
            defans2.Mevki = Mevki.Defans;

            futbolcular.Add(takozRecep);

            BaseFutbolcu sergenYalcin = new OrtaSaha { AdSoyad = "Sergen Yalcin", Mevki = Mevki.OrtaSaha };

            futbolcular.Add(sergenYalcin);

            Forvet cenkTosun = new Forvet { AdSoyad = "Cenk Tosun", Mevki = Mevki.Forvet};
            futbolcular.Add(cenkTosun);
            Takim besiktas = new Takim(futbolcular);

            Console.WriteLine(besiktas.ToString());
            Console.WriteLine("Hello, World!");
        }
    }
}

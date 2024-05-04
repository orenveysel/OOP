namespace _9_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  MuzikAleti MuzikAleti = new MuzikAleti();
            Piyano piyano = new Piyano();
            piyano.Marka = "Yamaha";
            piyano.Cal();
            Gitar gitar = new Gitar();
            gitar.Marka = "Fender";
            gitar.Model = "xyz";
            Flut flut = new Flut();
            flut.Marka = "Helvacioğlu";

            Muzisyen muzisyen = new Muzisyen();

            muzisyen.CaldigiMuzikAleti = gitar;
            muzisyen.CaldigiDigerMuzikAleti = piyano;
            muzisyen.CaldigiNefesli = flut;

            muzisyen.CaldigiAletler.Add(flut);

            Console.WriteLine("Hello, World!");
        }
    }
}

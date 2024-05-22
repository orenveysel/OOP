using _20_GenericRepository.Kutuphane.Abstract;
using _20_GenericRepository.Kutuphane.Concrete;
using _20_GenericRepository.Kutuphane.Manager;
using _20_GenericRepository.Okul.Sanal;
using _20_GenericRepository.Okul.YonetimSiniflari;

namespace _20_GenericRepository
{

    // Okul ile ilgili sinif,ogrenci,ogretmen ,Brans olacak sekilde 
    // manager siniflarina kadar ornekleyelim
    internal class Program
    {
        static void Main(string[] args)
        {
            KitapManager kitapManager = new KitapManager();
            kitapManager.SatisFiyatiDegistir();
            IManager<Kitap> manager = new KitapManager();

            IOgretmenManager ogretmenManager = new OgretmenManager();
            ogretmenManager.


            Console.WriteLine("Hello, World!");
        }
    }
}

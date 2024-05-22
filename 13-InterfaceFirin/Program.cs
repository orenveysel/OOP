using _13_InterfaceFirin.Lokanta;

namespace _13_InterfaceFirin
{
    internal class Program
    {
        //Firinda hamur olmasi lazim
        //Bu hamurun Yogurlmasi gerek

        // Sonrasinda bu hamurun pisirilmesi gerekir
        static void Main(string[] args)
        {
            #region Concrete Instance Alma 
            //Makina makina = new Makina();
            //makina.Marka = "Yamaha";
            //Usta hasanUsta = new Usta();
            //hasanUsta.AdSoyad = "Hasan Yilmaz";
            #endregion

            #region Interface uzerinden instance alma . Buna gevsek baglik deniyor
            //IYogurma hasanUsta = new Usta();
            //IYogurma makina = new Makina();
            //IMakinaCalis makina1 = new Makina();
            #endregion

            //KaraFirin karaFirin = new KaraFirin();
            //karaFirin.EkmekPisir(hasanUsta);
            //karaFirin.EkmekPisir(makina);

            // IMakinaCalis interface' i icerisinde Yogurma yetenegi olmadigindan dolayi Pisirme islemine giremez

            //karaFirin.EkmekPisir(makina1);

            #region Lokanta Ornegi

            Tavuk tavuk = new Tavuk();
            Kofte kofte = new Kofte();
            Pilav pilav = new Pilav();
            KuruFasulye kuru = new KuruFasulye();

            //BorsaLokantasi borsaLokantasi = new BorsaLokantasi();
            //borsaLokantasi.YemekPisir(tavuk, pilav, kuru, kofte);

            // balkan Lokantasi icin 

            List<IPisir> yemekler = new List<IPisir>();
            yemekler.Add(pilav);
            yemekler.Add(kuru);
            yemekler.Add(kofte);
            yemekler.Add(tavuk);
            Salata salata = new Salata();
            //yemekler.Add(salata);
            BalkanLokantasi balkanLokantasi = new();
            balkanLokantasi.YemekPisir(yemekler);
            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}

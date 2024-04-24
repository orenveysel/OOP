using _2_ClassEncapsulation.Mobilyalar;
namespace _2_ClassEncapsulation
{

    /*
     Mobilyalar icin Masa, Sandalye, yemekTakimi, yatakOdasi takimi,
     
    Bahçe takimi,ÇocukOdasi Takimi
     
     Telefonlar : Sabit Telefon, Cep Telefonu, Akilli Telefonlar 
     
     Araçlar : Otomobil, Kamyon, Otobus, Motorsiklet
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Yol Yemek Takimi instance alma
            YemekTakimi yemekTakimi = new YemekTakimi();
            yemekTakimi.Masa = new Masa();
            yemekTakimi.Sandalyeler = new List<Sandalye>();
            yemekTakimi.Sandalyeler.Add(new Sandalye() { AyakSayisi = 4, KumasTipi = KumasTipi.KESME, Malzeme = Malzeme.Ahsap, Renk =  Renk.Kirmizi});

            // 2. Yol Nesneleri onceden tek tek olusturup YemekTakimi nesnesinin property'lerine atama yapmak
            Masa yemekMasasi = new Masa()
            {
                Renk = Renk.Mavi,
                Color = new System.Drawing.Color(),
                Color2 = ConsoleColor.Black,
                KnownColor = System.Drawing.KnownColor.Blue
            };

            Sandalye sandalye1 = new Sandalye()
            {
                AyakSayisi = 4,
                KumasTipi = KumasTipi.KESME,
                Malzeme = Malzeme.Ahsap,
                Renk = Renk.Kirmizi
            };

            Sandalye sandalye2 = new Sandalye()
            {
                AyakSayisi = 4,
                KumasTipi = KumasTipi.KESME,
                Malzeme = Malzeme.Ahsap,
                Renk = Renk.Kirmizi
            };

            Sandalye sandalye3 = new Sandalye()
            {
                AyakSayisi = 4,
                KumasTipi = KumasTipi.KESME,
                Malzeme = Malzeme.Ahsap,
                Renk = Renk.Kirmizi
            };

            yemekTakimi.Sandalyeler.Add(sandalye1);
            yemekTakimi.Sandalyeler.Add(sandalye2);
            yemekTakimi.Sandalyeler.Add(sandalye3);

            Console.WriteLine($"Yemek Odasi 1 adet masa ve {yemekTakimi.Sandalyeler.Count} adet sandalyeden olusmaktadir");
            // RGB => RedGreenBlue
            Console.WriteLine("Hello, World!");
        }
    }
}
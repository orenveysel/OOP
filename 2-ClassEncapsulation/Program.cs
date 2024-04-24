using _2_ClassEncapsulation.Mobilyalar;
using _2_ClassEncapsulation.Telefonlar;
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
            #region Yemek Takimi
            //// 1. Yol Yemek Takimi instance alma
            //YemekTakimi yemekTakimi = new YemekTakimi();
            //yemekTakimi.Masa = new Masa();
            //yemekTakimi.Sandalyeler = new List<Sandalye>();
            //yemekTakimi.Sandalyeler.Add(new Sandalye() { AyakSayisi = 4, KumasTipi = KumasTipi.KESME, Malzeme = Malzeme.Ahsap, Renk =  Renk.Kirmizi});

            //// 2. Yol Nesneleri onceden tek tek olusturup YemekTakimi nesnesinin property'lerine atama yapmak
            //Masa yemekMasasi = new Masa()
            //{
            //    Renk = Renk.Mavi,
            //    Color = new System.Drawing.Color(),
            //    Color2 = ConsoleColor.Black,
            //    KnownColor = System.Drawing.KnownColor.Blue
            //};

            //Sandalye sandalye1 = new Sandalye()
            //{
            //    AyakSayisi = 4,
            //    KumasTipi = KumasTipi.KESME,
            //    Malzeme = Malzeme.Ahsap,
            //    Renk = Renk.Kirmizi
            //};

            //Sandalye sandalye2 = new Sandalye()
            //{
            //    AyakSayisi = 4,
            //    KumasTipi = KumasTipi.KESME,
            //    Malzeme = Malzeme.Ahsap,
            //    Renk = Renk.Kirmizi
            //};

            //Sandalye sandalye3 = new Sandalye()
            //{
            //    AyakSayisi = 4,
            //    KumasTipi = KumasTipi.KESME,
            //    Malzeme = Malzeme.Ahsap,
            //    Renk = Renk.Kirmizi
            //};

            //yemekTakimi.Sandalyeler.Add(sandalye1);
            //yemekTakimi.Sandalyeler.Add(sandalye2);
            //yemekTakimi.Sandalyeler.Add(sandalye3);

            //Console.WriteLine($"Yemek Odasi 1 adet masa ve {yemekTakimi.Sandalyeler.Count} adet sandalyeden olusmaktadir");

            //AkilliCepTelefonu samsung = new AkilliCepTelefonu
            //{
            //    Bluetooth = true,
            //    DahiliHafiza = 128,
            //    NFC = true,
            //    ParmakIzi = true,
            //    YuzTanima = true
            //};
            //// RGB => RedGreenBlue
            //Console.WriteLine("Hello, World!"); 
            #endregion

            Cocuk ali = new Cocuk();
            ali.Ad = "Ali";
            ali.Soyad = "Yilmaz";
            // Cocuk nesnesinin metodunu kullandigimizda bize hata firlatma ihtimali var 
            // O nedenle firlatilan hatayi try catch blogu ile yakalamak gerekir

            try
            {
                ali.HarclikAl(3);
                ali.TCNO = "123asdasfer";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(ali.BiriktirdigiPara);
            Console.WriteLine("Hello World");
        }
    }
}
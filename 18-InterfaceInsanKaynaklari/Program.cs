using _18_InterfaceInsanKaynaklari.Concrete;

namespace _18_InterfaceInsanKaynaklari
{

    // Kimya Boyama sektorundeki firma için InsanKaynaklari It Bolumune  ,Satis Bolumune ,Finans Bolumne Elemanlar Alacaktir.
    // IT => Asp.net core ,c# ,Html ,Css ,SqlServer, En az 3 yil tecrubeli olmasi , KodYazsin ,WebSitesiTasarlasin,HataliYerleriDuzeltsin,
    //Üniversitelerin mühendislik veya temel bilimler bölümlerinden mezun,
    //.NET'in güncel versiyonlarında en az 3 yıl ve üzeri profesyonel deneyimi olan,
    //Nesne yönelimli programlama(OOP) ve SOLID prensiplerine hakim,
    //T-SQL ve ORM(Entity Framework - Nhibernate - Dapper) tecrübesi olan,
    //Literatürü takip edebilecek seviyede İngilizce bilgisine sahip,
    //Ekip çalışmasına önem veren,
    //Yazılı ve sözlü iletişim becerileri gelişmiş,
    //Yeni teknolojiler öğrenmeye ve sürekli gelişime önem veren,
    //Tercihen Domain odaklı çalışma prensiplerine hakim; CQRS ve DDD tasarım kalıpları tecrübesi olan
    // Uzaktan Calisabilir


    // Satis => Testil Musteri Protfoyu olan , CenesiDusuk , Girisimci Ozellikleri olan B sinifi Ehliyet , SeyahateEngel durum olmasin

    // Finans Bolumune Donemsel Raporlama yapacak ,
    // Bilanco hazirlayacak ,
    // VergiHesaplayacak,
    // istenilen Raporlari hazirlayacak
    // Excel bilen ,
    // Logo  ile hasir nesir olan eleman alinacak.
    // Düzenli nakit akış oluşturabilecek
    // Seyata Mumkunse Etmesin. Ofiste Çalişşın


    // Butun Elemanlar Universite mezunu olacaktir. 

    // Insan kaynaklarina basvuruda bulunacak  
    // Bizlerde yukaridaki ozelliklere sahip başvurulari dikkate alacagiz. Uygun olmayanlar listelenmesin 
    // List<Basvuru> basvurular. 
    // foreach (var item in basvurular )
    // {
    //   Console.WriteLine(Departman => AdSoyad , MaasBeklentisi , Tecrubesi)
    //
    //   }
    internal class Program
    {
        static void Main(string[] args)
        {
            IK ik = new IK();


            #region Insan Kaynaklari Basvurusu
            //ITBasvuru itBasvuru1 = new ITBasvuru()
            //{
            //    isCSS = true,
            //    isCSharp = true,
            //    isDapper = true,
            //    isEntityFrameWork = true,
            //    isHtml  = true,
            //    Kisi = new Abstract.Kisi { AdSoyad="Ali Yilmaz",Gsm="532 111 22 33"}
            //};
            //ik.ITBasvurAl(itBasvuru1);
            //ik.ITBasvurAl(itBasvuru1);
            //ik.ITBasvurAl(itBasvuru1);
            //ik.ITBasvurAl(itBasvuru1);
            //ik.ITBasvurAl(itBasvuru1);

            //ITBasvuru itBasvuru2 = new ITBasvuru()
            //{
            //    isCSS = true,
            //    isCSharp = true,
            //    isDapper = true,
            //    isEntityFrameWork = true,
            //    isHtml = true,
            //    Kisi = new Abstract.Kisi { AdSoyad = "Ali Yilmaz", Gsm = "532 111 22 33" ,Email="ali@gmail.com" }
            //};
            //ik.ITBasvurAl(itBasvuru2);
            //ITBasvuru itBasvuru3 = new ITBasvuru()
            //{

            //    isCSharp = true,
            //    isDapper = true,
            //    isEntityFrameWork = true,

            //    Kisi = new Abstract.Kisi { AdSoyad = "Ayse Kaya", Gsm = "532 444 22 33" ,Email = "ayse@gmail.com"   }
            //};
            //ik.ITBasvurAl(itBasvuru3);


            //ik.BasvuruListele(Departman.It); 
            #endregion

            #region IK Genel Basvuru
            ITBasvuru itBasvuru1 = new ITBasvuru()
            {
                isCSS = true,
                isCSharp = true,
                isDapper = true,
                isEntityFrameWork = true,
                isHtml = true,
                Kisi = new Abstract.Kisi { AdSoyad = "Ali Yilmaz", Gsm = "532 111 22 33" }
            };
            ik.GenelBasvuruAl(itBasvuru1);
            FinansBasvuru finansBasvuru3 = new FinansBasvuru()
            {
               isLogo = true,
              

                Kisi = new Abstract.Kisi { AdSoyad = "Ayse Kaya", Gsm = "532 444 22 33", Email = "ayse@gmail.com" }
            };

            ik.GenelBasvuruAl(finansBasvuru3);
            //ik.BasvuruListele(Departman.It);
            //ik.BasvuruListele(Departman.Finans);
            ik.GenelVasvuruListele();

            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}

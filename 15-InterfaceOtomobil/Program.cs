using _15_InterfaceOtomobil.InsanKaynaklari.Abstract;
using _15_InterfaceOtomobil.InsanKaynaklari.Concrete;

namespace _15_InterfaceOtomobil
{
    internal class Program
    {

        // BaseOtomobil abstract class'i olsun , IOtomobil interface'ini uygulasin
        // IKonfor => Klima ,KoltukIsıtma 
        // IMultiMedya => SpotifyCal,YoutubeCal,InterneteBaglan
        // IGuvenlik => OtomatikFrenYap,SeritTakipEt , UykuKontolEt


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
        static void Main(string[] args)
        {
            /*
             *  List<Basvuru> basvurular = new();
             *  Basvuru ali = new Basvuru();
             * 
             *  basvurular.add(ali);
             *  
             *  Insankaynaklari ik = new();
             *  ik.Basvurular = basvurular;
             *  ik.UygunAdaylariListele(Departman departman);
             *  
             * 
             */
            IK insanKaynaklari = new IK();
            Kisi ali = new Kisi();
            ali.AdSoyad = "Ali Yilmaz";
            ali.GSM = "532 111 22 33";
            ali.Email = "ali@gmail.com";

            InformationTechApply apply = new InformationTechApply();
            apply.Kisi = ali;
            apply.isCSharp = true;
            apply.isSOLID = true;
            apply.isORM = true;
            apply.isSqlServer = true;
            apply.Tecrube = 5;
            BaseInformationTech veli = new InformationTechApply();
            
           veli.isCSharp = true;
            veli.isSOLID = true;
            veli.isORM = true;
            veli.isSqlServer = true;
            veli.Tecrube = 5;


            veli.Kisi = new Kisi { AdSoyad= "Veli Kaya" };
            insanKaynaklari.ITBasvuru(veli);
            insanKaynaklari.ITBasvuru(apply);
            apply.isASPNETCore = true;
            insanKaynaklari.ITBasvuru(apply);
            apply.isTeamWork = true;
            insanKaynaklari.ITBasvuru(apply);
            insanKaynaklari.ITBasvuru(apply);


            Kisi ayse = new Kisi();
           ayse.AdSoyad = "Ayse Yilmaz";
           ayse.GSM = "542 111 22 33";
           ayse.Email = "ayse@gmail.com";

            InformationTechApply apply2 = new InformationTechApply();
            apply2.Kisi = ayse;
            apply2.isCSharp = true;
            apply2.isSOLID = true;
            apply2.isORM = true;
            apply2.isSqlServer = true;
            apply2.Tecrube = 5;
            insanKaynaklari.ITBasvuru(apply2);
            insanKaynaklari.ITBasvuru(apply2); 
            insanKaynaklari.ITBasvuru(apply2);
            Console.WriteLine(insanKaynaklari.ToString());
            Console.WriteLine("Hello, World!");
        }
    }
}

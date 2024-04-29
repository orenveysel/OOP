using _5_Constructor.Personeller;
using System.Data.SqlClient;

namespace _5_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Otomobil kartal = new Otomobil();
            //kartal.Marka = "Tofas";
            //kartal.Model = "Kartal";
            //kartal.Renk= System.Drawing.KnownColor.White;

            ////Bu sekildeki Kullanima Yapici Metodu olan Kullanim bicimi diyor
            //Otomobil serce = new Otomobil("Tofas","Serce", KnownColor.White);


            ITPersonel ali = new ITPersonel("Ali", "Yilmaz", false);

            Personel mudur = new Personel("ayse", "kaya", false, Departman.Yonetim);
            //SatisPersoneli satis = new("", "", false);
            //Sekreter ayse = new Sekreter("Ayse","Kaya",true);
            //SqlConnection sqlcon  = SqlBaglanti.BaglantiVer();

            // SqlBaglanti baglanti = new SqlBaglanti();
            DateTime date = new DateTime(2000, 1, 20);

            #region Bir nesnenin instance alindigindaki durum 
            // butun Nesneler object siniftan türetilmiştir
            Temp temp = new Temp();
            Temp temp1 = new Temp();
            Temp temp2 = new Temp();

            //GetHashCode metodu nesnenin hash algoritmasina gore kodunu verir.
            // Instancec alinan nesnelerin ayni nesne olup olmadigini kontrole yarar;

            #region GetHashCode
            //Console.WriteLine(temp.GetHashCode());
            //Console.WriteLine(temp1.GetHashCode());
            //Console.WriteLine(temp2.GetHashCode());
            //Console.WriteLine("************************");
            SqlConnection connection1 = SqlBaglanti.BaglantiVer();
            SqlConnection connection2 = SqlBaglanti.BaglantiVer();

            SqlConnection connection3 = SqlBaglanti.BaglantiVer();

            //Console.WriteLine(connection1.GetHashCode());
            //Console.WriteLine(connection2.GetHashCode());
            //Console.WriteLine(connection3.GetHashCode()); 
            #endregion

            #region Equals
            //Console.WriteLine("********************");
            //Console.WriteLine( temp.Equals(temp1));
            //Console.WriteLine(temp1.Equals(temp1));
            //Console.WriteLine(temp1.Equals(temp2));
            //Console.WriteLine("********************");

            //Console.WriteLine(connection1.Equals(connection2));
            //Console.WriteLine(connection2.Equals(connection3));
            //Console.WriteLine(connection3.Equals(connection1)); 
            #endregion


            #region GetType
            //reflections konusu ile ilgilidir

            //Console.WriteLine(temp.GetType().Name);
            //Console.WriteLine(temp.GetType().FullName);
            //Console.WriteLine(temp.GetType().Namespace);

            //var sonuc = ali.GetType().GetProperties();
            //foreach (var prop in sonuc)
            //{
            //    Console.WriteLine(prop.Name + " " + prop.CanWrite);
            //    Console.WriteLine();
            //}
            //var metodlar = ali.GetType().GetMethods();
            //foreach (var method in metodlar)
            //{
            //    Console.WriteLine(method.Name);

            //}
            #endregion



            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}

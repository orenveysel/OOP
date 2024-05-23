using Bogus;

namespace _23_DelegateTekrar
{
    internal class Program
    {

        /*
         * 
         * C# programlama dilinde tanımlanan ve metot olarak adlandırılan işlevlerin bellek adresini tutmak için kullanılan yapıya delegate veya temsilci denir.

        C# delegate yapısı C ve C++ dillerinde yer alan function pointer veya fonksiyon göstericilerine benzemektedir.

        Bilgisayar üzerinde işlem yapan her şey (değişkenler, sınıflar, metotlar) bellek üzerinde tutulur.

        Bizler genellikle bellekte tutulan değişken değerleri üzerinde işlem yaparız.

        C# programlama dilinde int, float, double, char, byte gibi verilerin bellekte tutulmasını ifade eden veri türleri yer alır.
         * 
         * 
         * 
         * 
         * 
         */
        public delegate void Print(int value);

        static void Main(string[] args)
        {

            #region Multicast Delegate
            //MultiCast Delegate Ornegi.
            // Birden Fazla metod temsil edebilir
            //Print printDel = PrintNumber;
            //printDel += PrintHexadecimal;
            //printDel += PrintMoney;

            //printDel(100000);
            //Console.WriteLine("****************");
            //// - operatoru ile istedigimiz metodlari cikartabiliriz
            //printDel -= PrintMoney;
            //printDel(100000); 
            #endregion
            #region Özel Delegate Türleri

            #region Action Delegate => Bir Action'i temsil eder .
            // Herhangi bir geri donus tipi olmayan ve Herhangi bir parametre almayan delegelere Action Delagate Denir
            //1. Kullanim 
            //Action action = EkranaYaz;
            //action();
            ////2. Kullanim
            //Action action2 = ()=>Console.WriteLine("Test 2");
            //action2();
            #endregion

            #region Generic Action Delegate
            // Geriye bir deger donmeyen icerisine parametre alan metodlari tanimlar
            // 1. Kullanim
            //Action<int> action = EkranaYaz2;
            //action(12);
            ////2. Kullanimi 
            //Action<int> action2 = (ali) => Console.WriteLine(ali);
            //action2(123);

            //Action<int,int> actionUstAl = (x,y)=> Console.WriteLine(Math.Pow(x,y));
            //actionUstAl(2, 3);

            //actionUstAl += UstAl;
            //actionUstAl(3, 4);


            #endregion

            #region Func Delegate
            // Geriye T tipinden Generic olarak geri donusu bildirebildigimiz 
            //bir delege tipidir. Verilen parametrelerden en sonuncusu geri donus tipini belirler
            //1. Kullanimi
            //Func<int, long> kareAl = (value) => value * value;
            ////2. Kullanimi
            //kareAl += kareAlMetod;

            //Console.WriteLine( kareAl(5));

            //Func<int, int, int, int, int> Topla = (a, b, c, d) => (a + b + c + d);
            //Topla += ToplaMetod;
            //Topla(1, 2, 3, 4);
            #endregion

            #region Predicate Delegate
            // Bu da geriye bool donen en fazla 16 adet generic tip alabilen 
            // ozel bir sistem delegesidir

            //Predicate<int> TekCift = (a)=> a%2 == 0;
            //Console.WriteLine(TekCift(3));
            //TekCift += TekCiftMetod;

            #endregion
            #endregion

            #region Bogus ile Face Data Ornegi

            Faker faker = new Faker("tr");
            List<Person> people = new List<Person>();

            for (int i = 0; i < 1500; i++)
            {
                people.Add(new Person("tr"));
            }

            //var result1 = people.Where(p => p.Address.City == "Adana").ToList();
            //var result2 = people.Where(p => Erzincanlimi(p)).ToList();

            //result1.ForEach(p=>Console.WriteLine(p.FullName + " " + p.Gender + " " + p.DateOfBirth));
            //Console.WriteLine("**************************");
            //result2.ForEach(p => Console.WriteLine(p.FullName + " " + p.Gender + " " + p.DateOfBirth));
            Person person = new Person("tr");

            #region Bogus Sorulari

            // 1- Yaşı 20 altinda olan larin listesi
            #region Ceyda
            //var liste1 = people.Where(p => (DateTime.Now.Year - p.DateOfBirth.Year) <= 20).ToList();
            //foreach (Person p in liste1)
            //{
            //    Console.WriteLine($"{p.FullName,25}, Dogum Yili: {p.DateOfBirth.Year,4}, Yasi: {DateTime.Now.Year - p.DateOfBirth.Year}");
            //}
            #endregion
            // 2- gmail hesabi olan varmi ?
            #region Erol Aydemir
            //var result43 = people.Where(p => p.Email.Contains("gmail")).ToList();
            //result43.ForEach(p => Console.WriteLine(p.FullName + " " + p.Gender + " " + p.DateOfBirth + " " + p.Email));
            #endregion
            // 3- Istanbulda yasayan Erkek ve Kadin nufus dagilimi nedir ?
            #region  Didem
            //var liste3 = people.Where(p => p.Gender.ToString() == "Male" && p.Address.City == "İstanbul").ToList();
            //liste3.ForEach(p => Console.WriteLine(p.FullName + " " + p.Gender + " " + p.Address.City));
            //int erkekSayi = liste3.Count;
            //var liste4 = people.Where(p => p.Gender.ToString() == "Female" && p.Address.City == "İstanbul").ToList();
            //liste4.ForEach(p => Console.WriteLine(p.FullName + " " + p.Gender + " " + p.Address.City));
            //int kadinSayi = liste4.Count;

            //Console.WriteLine("İstanbulda yaşayan erkek sayisi : " + erkekSayi);
            //Console.WriteLine("İstanbulda yaşayan kadin sayisi : " + kadinSayi);
            #endregion

           
            #endregion

            #endregion
        }
        public static bool Erzincanlimi(Person person)
        {
            if (person.Address.City == "Erzincan")
                return true;
            else
                return false;
        }
        public static bool Adanalimi(Person person)
        {
            if (person.Address.City == "Adana")
                return true;
            else
                return false;
        }
        public static bool TekCiftMetod(int a)
        {
            return a % 2 == 0;
        }
        public static int ToplaMetod(int a, int b, int c, int d)
        {
            return (a + b + c + d);
        }
        public static long kareAlMetod(int value)
        {
            return value * value;
        }
        public static void UstAl(int x, int y)
        {
            Console.WriteLine("Face Metod");
        }
        public static void EkranaYaz2(int value)
        {
            Console.WriteLine(value);
        }
        public static  void EkranaYaz()
        {
            Console.WriteLine("Test 1");
        }
        public void Printtest(Int16 value)
        {
            Console.WriteLine(value);
        }
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}

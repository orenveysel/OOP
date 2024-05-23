using _21_OOPGenelTekrar.Loglama;
using _21_OOPGenelTekrar.Loglama.Abstract;
using _21_OOPGenelTekrar.Loglama.Concrete;
using _21_OOPGenelTekrar.Lokanta.Abstract;
using _21_OOPGenelTekrar.Lokanta.Concrete;
using _21_OOPGenelTekrar.Lokanta.EskiYontem;
using _21_OOPGenelTekrar.Vasita;
using _21_OOPGenelTekrar.Vasita.Abstract;
using _21_OOPGenelTekrar.Vasita.Concrete;

namespace _21_OOPGenelTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kofte kofte = new Kofte() { Name = "Sultan Ahmet Kofte" };
            Piyaz piyaz = new() { Name = "Piyaz" };
            KuruFasulye kuru = new KuruFasulye()
            {
                Name = "Çayirli Kuru Fasulye"
            };

            #region Eski sistem

            Lokanta.EskiYontem.Lokanta lokanta = new Lokanta.EskiYontem.Lokanta();

            //Tavuk tavuk = new Tavuk();
            ////Buradaki metod gobekten class'lara baglidir
            //lokanta.YemekPisir(tavuk);
            #endregion

            #region Yeni Yontem Interface ile 
            //List<IPisirilebilir> pisirilebilirs = new();
            //HashSet<IPisirilebilir> pisirilebilirs1 = new();
            //pisirilebilirs.Add(kofte);
            //pisirilebilirs.Add(piyaz);
            //pisirilebilirs.Add(kuru);
            //Interface'lerden intance alinmaz
            // Pirasa pirasa = new IPisirilebilir();

            //IPisirilebilir pirasa2 = new Pirasa(); ;


            //BorsaLokantasi borsaLokantasi = new BorsaLokantasi();
            //borsaLokantasi.YemekPisir2(pisirilebilirs1);
            // // burada ki metod interface'lerle calistigindan daha gevsek bir baglanti bicimine sahiptir
            // borsaLokantasi.YemekPisir(pisirilebilirs);
            #endregion


            #region Loglama Ornegi
            //FileLogger fileLogger = new FileLogger();
            //EmailLooger emailLogger = new EmailLooger();
            //emailLogger.Email = "ali@gmail.com";
            //DatabaseLogger dblogger  = new DatabaseLogger();

            //ILogger fileLogger1 = new FileLogger();
            //ILogger emailLogger1 = new EmailLooger();
            //emailLogger1.Logla("DEneme");
            ILogger dblogger1 = new DatabaseLogger();
            //Logger logger = new Logger(fileLogger);

            //Logger logger1 = new Logger(emailLooger);
            //logger.Logolustur("Test");
            //SmsLogger smsLogger = new SmsLogger();  

            //NewLogger logger = new(fileLogger);
            //NewLogger logger1 = new(emailLogger);
            //NewLogger logger3 = new(dblogger);
            //NewLogger logger4 = new(smsLogger);
            #endregion


            #region Kaptan Sofor Ve Vasita Ornegi
            Otomobil reno = new Otomobil();
            Minibus transporter = new Minibus();
            Otobus mercedes = new Otobus();
            Tir volvo = new Tir();

            #region Interface Kullanamadan onceki durum
            //Sofor sofor1 = new(reno);
            //Sofor sofor2 = new(transporter);
            //Sofor sofor3 = new(mercedes);
            //Sofor sofor4 = new(volvo); 
            #endregion

            #region Interface ile NewSofor Kullanimi
            ICollection<ISurebilir> araclar = new HashSet<ISurebilir>();
            araclar.Add(volvo);
            araclar.Add(mercedes);
            araclar.Add(transporter);
            araclar.Add(reno);
            NewSofor makamsofor1 = new NewSofor(reno) { EhliyetTipi= EhliyetTipi.B};
            makamsofor1.AracKullan();

            NewSofor genelSofor = new NewSofor(araclar) { EhliyetTipi = EhliyetTipi.C };

            genelSofor.AraclariKullan();
            #endregion

            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}

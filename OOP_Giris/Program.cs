namespace OOP_Giris
{
    /*
    Bilgisayar parcalari
    Anakart, Cpu, Ram, SSD, HDD, EkranKarti, NetworkKarti
    Kasa, PowerSupplier, Ekran, Klavye, Mouse
    Printer, Scanner, Hoparlor, WebCam


    */
    public class Ogrenci
    {
        public int Id; //Filled
        public string Ad; //Filled
        public string Soyad; //Filled
        private string TcNo; //Filled
        public DateTime DogumTarihi; //Filled

        //Property => Ozellik
        //Kontrollu veri alimi icin gerekli set metoduna sahiptir
        public string TcKimlik {
            get 
            {
                return TcNo.Substring(7);
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Tc kimlik alani bos olamaz!");
                    return;
                }
                foreach (Char ch in value)
                {
                    if (!Char.IsDigit(ch))
                    {
                        Console.WriteLine("Girilen ifade icerisinde sayisal olmayan degerler var");
                        return;
                    }
                }
                if (value[0].ToString() == "0")
                {
                    Console.WriteLine("Tc No 0 ile baslayamaz!");
                }
                if (value.Length == 11)
                {
                    TcNo = value;
                }
                else
                {
                    Console.WriteLine("Tc numarasi 11 Karakter olmalidir!");
                    return;
                }
            }
        } 

        public string Gsm { get; set; } //Bos Prop => kontrolsuz
        //Ogrenci Class'ina ait metodlar
        public void SetTcNo(string tcNo)
        {
            if(tcNo.Length != 11 )
            {
                Console.WriteLine("Tc numarasi 11 Karakter olmalidir!");
            }
            else if (tcNo.Length == 11)
            {
                TcNo = tcNo;
            }
        }

        public string GetTcNo()
        {
            //Tc No'nun son 4 hanesi geri donecek
            return TcNo.Substring(7);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Id = 1;
            ogrenci.Ad = "Ali";
            ogrenci.Soyad = "Yilmaz";
            ogrenci.SetTcNo("12345678901");
            ogrenci.TcKimlik = "sadasgasgas";
            Console.WriteLine(ogrenci.TcKimlik);
        }
    }
}

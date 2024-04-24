using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassEncapsulation
{
    public class Cocuk
    {
        #region Ozellikler

        // propfull code snipt ile cikan bir kod blogudur
        // bir adet private field ve bir adet de public property kodu olusturur
        // bizler de olusturulan private field alanina kontrollu veri ekleme ve kontrollu veri disariya verme islemlerini gerceklestiririz
        private string _tcno;

        public string TCNO
        {
            get { return _tcno.Substring(7); }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("TcNo Bos Olamaz");
                }
                else if (value.Length != 11)
                {
                    throw new Exception("TcNo 11 Karakter Olmalidir");
                }
                else
                {
                    foreach (var ch in value)
                    {
                        if (!Char.IsDigit(ch))
                        {
                            throw new Exception("TcNo Sayisal Olmalidir");
                        }
                    }
                    _tcno = value;
                }
            }
        }

        private string _name;
        public string Ad
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }
        public string Soyad { get; set; }
        public int Boyu { get; } // ReadOnly Property denir
        public int Kilo { get; private set; } // Class harici ReadOnly
        public bool Cinsiyet { private get; set; } // Class harici WriteOnly
        public int Yas { set { } } // WriteOnly Property denir
        public string KrediKartiBilgisiAta { set { } } // WriteOnly Property denir
        #endregion

        private int _biriktirdigiPara;
        private bool _guvenilirmi; // Buradaki private field alanlarina ancak class icerisinden deger atanip okuma yapilabilir

        // Sartli geri bildirim yaptigimiz bir Encapsulation ornegi
        // Sartli property

        #region Yetenekler
        public int BiriktirdigiPara
        {
            get
            {
                if (_guvenilirmi)
                {
                    return _biriktirdigiPara;
                }
                return 0;
            }
            set
            {
                if (value > 0)
                {
                    _biriktirdigiPara = value;
                }
            }
        }

        public void HarclikAl(int harclik)
        {
            if (harclik < 5)
            {
                throw new Exception("Baba beni mi kandiriyosun");
            }
            else if (harclik < 50)
            {
                throw new Exception("Baba sadaka mi veriyosun");
            }
            _biriktirdigiPara += harclik;
        }
        public void Harca(int miktar)
        {
            if (_biriktirdigiPara < miktar)
            {
                throw new Exception("Bu kadar param yok");
            }
            _biriktirdigiPara -= miktar;
        }

        public int KacParanVar(string kimsin)
        {
            if (kimsin == "Baban")
            {
                return _biriktirdigiPara / 10;
            }
            return _biriktirdigiPara;
        }
        #endregion
    }
}










using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_InterfaceOtomobil.InsanKaynaklari.Concrete
{
    public class Kisi
    {
        private string _gsm;
        private string _email;
        public string AdSoyad { get; set; }
        public string TcNo { get; set; }
        public string GSM
        {
            get
            {
                if (!string.IsNullOrEmpty(_gsm))
                    return _gsm;
                else
                    return "Gsm Tanimlanmamniş";
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _gsm = value;
                }
                else
                {
                    _gsm = "Gsm Tanimlanmamistir";
                }
            }
        }
        public string Email { get; set; }
        public bool Cinsiyet { get; set; }

        public override string ToString()
        {
            return $"{AdSoyad}\t{GSM}\t{Email}";
        }
    }
}

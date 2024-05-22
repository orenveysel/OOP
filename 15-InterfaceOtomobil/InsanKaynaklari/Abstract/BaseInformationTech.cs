using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _15_InterfaceOtomobil.InsanKaynaklari.Concrete;


namespace _15_InterfaceOtomobil.InsanKaynaklari.Abstract
{
    public abstract class BaseInformationTech:IInformationTech
    {
        public bool isASPNETCore { get; set; }
        public bool isCSharp { get; set; }
        public bool isHtml  { get; set; }
        public bool isCss { get; set; }
        public bool isSqlServer  { get; set; }
        public byte Tecrube { get; set; }
        public bool isSOLID { get; set; }
        public bool isOOP { get; set; }
        public bool isORM  { get; set; }
        public bool isTeamWork { get; set; }

        public Kisi Kisi { get; set; }

        public void Debug()
        {
            throw new NotImplementedException();
        }

        public void KodYaz()
        {
            throw new NotImplementedException();
        }

        public void WebSite()
        {
            throw new NotImplementedException();
        }
    }
}

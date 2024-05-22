using _18_InterfaceInsanKaynaklari.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_InterfaceInsanKaynaklari.Concrete
{
    public class FinansBasvuru : BaseBasvuru, IFinans
    {
        public bool isExcel { get; set; }
        public bool  isLogo { get; set; }

        public void BilancoHazirla()
        {
            throw new NotImplementedException();
        }

        public void MaasHesapla()
        {
            throw new NotImplementedException();
        }

        public void NakitAkisDuzenle()
        {
            throw new NotImplementedException();
        }

        public void VergiHesapla()
        {
            throw new NotImplementedException();
        }
    }
}

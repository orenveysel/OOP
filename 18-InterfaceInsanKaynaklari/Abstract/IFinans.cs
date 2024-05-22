using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_InterfaceInsanKaynaklari.Abstract
{
    public interface IFinans
    {
        public void BilancoHazirla();
        public void VergiHesapla();
        public void MaasHesapla();
        public void NakitAkisDuzenle();
    }
}

using _18_InterfaceInsanKaynaklari.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_InterfaceInsanKaynaklari.Concrete
{
    public class SatisPersonelBasvuru : BaseBasvuru, ISatisBasvuru
    {
        public bool isEhliyet { get; set; }
        public bool SeyahateEngelDurum { get; set; }
        public void MusteriZiyaretEt()
        {
            throw new NotImplementedException();
        }

        public void SatisRaporuHazirla()
        {
            throw new NotImplementedException();
        }
    }
}

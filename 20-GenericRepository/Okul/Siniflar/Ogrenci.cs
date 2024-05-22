using _20_GenericRepository.Okul.Sanal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_GenericRepository.Okul.Siniflar
{
    public class Ogrenci:Kisi<Guid>
    {

        public  int SinifId { get; set; }
        public Sinif Sinif { get; set; }

        public bool  BorcuVarmi { get; set; }
    }
}

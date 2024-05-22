using _20_GenericRepository.Okul.Sanal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20_GenericRepository.Okul.Siniflar
{
    public class Sinif:BaseEntity<int>
    {
        public string SinifAdi { get; set; }
        public string Sube { get; set; }
        public byte Kapasite { get; set; }

        public ICollection<Ogrenci> Ogrenciler { get; set; } = new HashSet<Ogrenci>();
    }
}

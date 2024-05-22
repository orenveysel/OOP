using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_GenericRepository.Okul.Sanal
{
    public abstract class Kisi<T>:BaseEntity<T>,IEntity
    {
        public string FullName { get; set; }
        public bool Cinsiyet { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
    }
}

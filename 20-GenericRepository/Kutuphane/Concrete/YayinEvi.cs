using _20_GenericRepository.Kutuphane.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_GenericRepository.Kutuphane.Concrete
{
    public class YayinEvi :BaseEntity<int>
    {
        public string YayinEviAdi { get; set; }
    }
}

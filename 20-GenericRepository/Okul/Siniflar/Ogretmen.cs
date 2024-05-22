using _20_GenericRepository.Okul.Sanal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_GenericRepository.Okul.Siniflar
{
    public class Ogretmen:Kisi<Guid>
    {
        public Brans Brans { get; set; }
    }
}

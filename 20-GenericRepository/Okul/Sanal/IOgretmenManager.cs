using _20_GenericRepository.Okul.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_GenericRepository.Okul.Sanal
{
    public interface IOgretmenManager:IManager<Ogretmen,Guid>
    {
        public void DerseGir();
        public void YoklamaAl();

    }
}

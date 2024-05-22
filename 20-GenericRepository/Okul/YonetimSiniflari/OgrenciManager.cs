using _20_GenericRepository.Okul.Sanal;
using _20_GenericRepository.Okul.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_GenericRepository.Okul.YonetimSiniflari
{
    public class OgrenciManager : ManagerBase<Ogrenci,Guid>
    {
        public override void Delete(Ogrenci item)
        {
            if (item != null && item.BorcuVarmi==false)
            {
                base.Delete(item);
            }
            else
            {
                throw new Exception("Gonderilen parametre null olamaz. Belki borcuda vardir");
            }
        }
    }
}

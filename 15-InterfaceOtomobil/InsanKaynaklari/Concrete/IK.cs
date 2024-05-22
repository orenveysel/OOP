using _15_InterfaceOtomobil.InsanKaynaklari.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_InterfaceOtomobil.InsanKaynaklari.Concrete
{
    public class IK
    {
        private List<BaseInformationTech> _ITApplay;
        public IK()
        {
            _ITApplay = new List<BaseInformationTech>();
        }
        public bool ITBasvuru(InformationTechApply apply)
		{

			if (apply.isORM == true && apply.isCSharp == true && apply.Tecrube >= 3)
			{

                foreach (var item in _ITApplay)
                {
                    if (item.Equals(apply))
                    {
                        Console.WriteLine($"{apply.Kisi.AdSoyad} Daha Onceden         Basvurmustur");
                        return false;
                    }
                }
                if (!_ITApplay.Contains(apply))
                {
                    _ITApplay.Add(apply);
                    return true;
                }
            }
			return false;
		}

    

        public bool ITBasvuru(BaseInformationTech apply)
        {
            _ITApplay.Add(apply);
            return true;
        }
        public bool ITBasvuru(IInformationTech apply)
        {
            //_ITApplay.Add(apply);
            return true;
        }    
        
        public override string ToString()
        {
            string str = "";
            foreach (var basvuru in _ITApplay)
            {
                str += $"{basvuru.Kisi.ToString()}\t Tecrube :{basvuru.Tecrube}\n";
            }

            return str;
        }
    }
}

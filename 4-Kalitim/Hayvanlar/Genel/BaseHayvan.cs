using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance.Hayvanlar.Genel
{
    public class BaseHayvan
    {
        #region Ozellikler
        public string Adi { get; set; }
        public string Turu { get; set; }
        #endregion

        #region Yetenekler
        public void Beslenebilir()
        {

        }

        #endregion
    }
}

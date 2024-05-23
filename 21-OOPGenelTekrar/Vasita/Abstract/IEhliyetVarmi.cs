using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOPGenelTekrar.Vasita.Abstract
{
    public enum EhliyetTipi
    {
        A=1,
        B,
        C,
        D,
        E
    }

    public interface IEhliyetVarmi
    {
        public EhliyetTipi EhliyetTipi { get; set; }
        public bool EhliyetVarmi { get; set; }
    }
}

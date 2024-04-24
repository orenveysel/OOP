using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassEncapsulation.Telefonlar
{
    public enum IsletimSistemi
    {
        Android, // Google
        IOS, // Apple
        HarmonyOS // Huawei
    }

    /*
     * 
    */
    public class AkilliCepTelefonu
    {
        #region Ozellikler
        public bool Bluetooth { get; set; }
        public bool YuzTanima { get; set; }
        public bool NFC { get; set; }
        public bool ParmakIzi { get; set; }
        public int DahiliHafiza { get; set; }
        #endregion


        #region Yetenekler
        public bool OnKameradanFotografCek()
        {
            return true;
        }
        public bool SelfieCek()
        {
            return true;
        }
        public bool NfcAc()
        {
            return true;
        }
        public bool TelefonAc()
        {
            return true;
        }
        public bool TelefonKapat()
        {
            return true;
        } 
        #endregion

    }
}

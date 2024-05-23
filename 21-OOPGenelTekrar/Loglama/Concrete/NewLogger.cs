using _21_OOPGenelTekrar.Loglama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOPGenelTekrar.Loglama.Concrete
{
    public class NewLogger
    {
        //Nesnenin ismi degil ,yapabildikleri benim icin onemli.
        // Bana Logla metodunu iceren ve icerisine string bir deger alan metodu varsa 
        // Geri onemli degil benim icin.
        readonly ILogger _logger;
        public NewLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void logla(string message)
        {
            _logger.Logla(message);
        }
    }
}

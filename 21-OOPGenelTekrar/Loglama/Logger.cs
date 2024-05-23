using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOPGenelTekrar.Loglama
{
    public class Logger
    {

        //ReadOnly filed yada Property'ler sadece constructer icerisinde yada tanimlandiklari yerde ilk deger atamasi yapilabilir. Başka yerde deger atamasi yapilamaz
         readonly FileLogger _logger;
        readonly EmailLooger _loogerEmail;
        readonly DatabaseLogger _databaseLogger;
        public Logger(FileLogger logger)
        {
            _logger = logger;
        }
        public Logger(DatabaseLogger logger)
        {
            _databaseLogger = logger;
        }
        public Logger(EmailLooger looger)
        {
            _loogerEmail = looger;
        }
        public void Logolustur(string message)
        {
            _logger.Logla(message);
        }
    }
}

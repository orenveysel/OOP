using _21_OOPGenelTekrar.Loglama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOPGenelTekrar.Loglama
{
    public class FileLogger:ILogger
    {
        public void Logla(string message) 
        {
            Console.WriteLine(DateTime.Now + " => "+  message +" loglandi");
        }
    }
}

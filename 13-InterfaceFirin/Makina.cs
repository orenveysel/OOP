using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceFirin
{
    public class Makina:IYogurma,IMakinaCalis
    {
        public string Marka { get; set; }

        public bool IsRunning => false;

        public bool IsPaused => false;

        public void HamurYogur()
        {
            Console.WriteLine(Marka+ " Hamur Yogurdu");
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_InterfaceFirin
{
    public interface IMakinaCalis
    {
        public void Start();
        public void Stop();
        public bool IsRunning { get; }
        public bool IsPaused { get; }
        public void Pause();
    }
}

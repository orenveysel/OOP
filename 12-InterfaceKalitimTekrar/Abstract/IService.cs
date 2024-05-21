using _12_InterfaceKalitimTekrar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceKalitimTekrar.Abstract
{
    public interface IService
    {
        public int Add(string sql);
        public int Add(Product product);
        public int Delete(string sql);
        public int Delete(Product product);
        public int Update(string sql);
        public int Update(Product product);
    }
}

using _12_InterfaceKalitimTekrar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InterfaceKalitimTekrar.Abstract
{
    public interface IProductService :IService
    {
        public Product GetProduct(int id);
        public List<Product> GetProductsAll();
    }
}

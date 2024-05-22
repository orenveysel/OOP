using _19_NorthwindModels.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_NorthwindModels.Models.Concrete
{
    public class Customer : BaseEntity<string>
    {
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}

using _19_NorthwindModels.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_NorthwindModels.Models.Concrete
{
    public class Order :BaseEntity<int>
    {
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int ShipVia { get; set; }
        public DateTime OrderDate { get; set; }

    }
}

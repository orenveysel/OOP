using _19_NorthwindModels.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_NorthwindModels.Models.Concrete
{
    public class Employee :BaseEntity<int>
    {
        public string FirstNAme { get; set; }
        public string LastName { get; set; }
        public DateTime BirtDate { get; set; }
    }
}

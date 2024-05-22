using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_GenericRepository.Kutuphane.Abstract
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;

    }
}

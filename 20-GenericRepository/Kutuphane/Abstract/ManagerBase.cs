using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_GenericRepository.Kutuphane.Abstract
{

    /*
     * 
     * Burada T : Entity ,TId ise kullanilacak olan entity'nin primary key'i dir
     * 
     * 
     * 
     */
    public abstract class ManagerBase<T,Tid> : IManager<T>  where T : BaseEntity<Tid>
    {
        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public int Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

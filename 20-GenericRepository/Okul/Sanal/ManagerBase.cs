using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_GenericRepository.Okul.Sanal
{
    public abstract class ManagerBase<T, TId> : IManager<T, TId> where T : BaseEntity<TId>
    {
        public virtual void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public virtual ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual T GetById(TId id)
        {
            throw new NotImplementedException();
        }

        public virtual void Insert<TEntity>(TEntity item) where TEntity : IEntity
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}

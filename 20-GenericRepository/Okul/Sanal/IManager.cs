using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_GenericRepository.Okul.Sanal
{
    public interface IManager<T,TId> where T : BaseEntity<TId>    
    {

        //Metod icerisinde generic yapi kullanma
       public void Insert<TEntity>(TEntity item) where TEntity : IEntity;

        public   void Update(T item);
        
        public void Delete(T item);

        public T GetById(TId id);

        public ICollection<T> GetAll();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommWebApp.Repository.Generic
{
    public interface IGenericRepository<T>
    {
        List<T> GetAll();
        T Get(object id);
        bool Add(T entity);
        bool AddRange(List<T> entities);
        T Update(object id, T entity);
        bool Remove(object id);
        bool Remove(T entity);
        bool RemoveRange(List<T> entities);
        bool Save();
    }
}

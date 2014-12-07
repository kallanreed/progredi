using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progredi.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        // TODO: should key have strong type via type param

        T Get(object key);
        IQueryable<T> GetAll();

        T Add(T entity);
        T Update(T entity);
        T Remove(T entity);

        void SaveChanges();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progredi.Data.EF
{
    using Interfaces;

    public class Repository<T, TKey> : IRepository<T> where T: class
    {
        private IContext<T> context;

        // hidden default
        private Repository() { }

        public Repository(IContext<T> context)
        {
            this.context = context;
        }

        public T Get(object key)
        {
            return this.context.DbSet.Find(key);
        }

        public IQueryable<T> GetAll()
        {
            return this.context.DbSet;
        }

        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public T Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progredi.Data.EF
{
    using Interfaces;

    public class Repository<T> : IRepository<T> where T: class
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
            return this.context.DbSet.Add(entity);
        }

        public T Update(T entity)
        {
            var updated = this.context.DbSet.Attach(entity);
            this.context.DbContext.Entry(entity).State = EntityState.Modified;
            return updated;
        }

        public T Remove(T entity)
        {
            return this.context.DbSet.Remove(entity);
        }

        public void SaveChanges()
        {
            this.context.DbContext.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progredi.Data.EF
{
    public class Context<T> : IContext<T> where T : class
    {
        public Context()
        {
            // get connection string here
            this.DbContext = new DbContext("name=Progredi");
            this.DbSet = this.DbContext.Set<T>();
        }

        // TODO: Automapping and what about Fluent API handlers?

        public new DbContext DbContext { get; private set; }

        public IDbSet<T> DbSet { get; private set; }

        public void Dispose()
        {
            this.DbContext.Dispose();
        }
    }
}

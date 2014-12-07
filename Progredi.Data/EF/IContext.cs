using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Progredi.Data.EF
{
    public interface IContext<T> : IDisposable where T : class
    {
        IDbSet<T> DbSet { get; }
    }
}

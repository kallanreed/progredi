using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Data.SqlServerCe;
using System.Data.Entity.SqlServerCompact;

namespace Progredi.Data
{
    public class SqlCeConfiguration : DbConfiguration
    {
        public SqlCeConfiguration()
        {
            // http://msdn.microsoft.com/en-us/data/jj680699
        }
    }
}

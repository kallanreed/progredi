using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Progredi;
using Progredi.Data;
using Progredi.Data.EF;
using Progredi.Service;

namespace ProgrediTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IContext<Teacher> ctx = new Context<Teacher>())
            {
                var repo = new Repository<Teacher>(ctx);

                repo.Add(new Teacher() { FirstName = "Bilbo", LastName = "Baggins" });
                repo.SaveChanges();
            }
        }
    }
}

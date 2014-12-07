using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progredi
{
    public class Class
    {
        public Teacher Teacher { get; set; }

        public IEnumerable<Student> Students { get; set; }
    }
}

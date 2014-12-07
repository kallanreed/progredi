using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progredi
{
    public class Tag
    {
        public Tag ParentTag { get; set; }

        public bool AllowTagging { get; set; }
    }
}

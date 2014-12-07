using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progredi.Service
{
    using Progredi;

    public interface ITagService
    {
        void RemoveTag(Tag toRemove);
    }
}

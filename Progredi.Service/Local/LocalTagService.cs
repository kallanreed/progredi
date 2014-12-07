using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progredi.Service.Local
{
    using Progredi;
    using Data.Interfaces;

    public class LocalTagService : ITagService
    {
        private IRepository<Tag> repository;

        private LocalTagService() { }

        public LocalTagService(IRepository<Tag> repository)
        {
            this.repository = repository;
        }

        public void RemoveTag(Tag toRemove)
        {
            this.repository.Remove(toRemove);
        }
    }
}

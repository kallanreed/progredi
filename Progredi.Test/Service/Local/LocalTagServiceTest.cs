using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Progredi;
using Progredi.Data.Interfaces.Fakes;
using Progredi.Service.Local;

namespace Progredi.Test.Service.Local
{
    [TestClass]
    public class LocalTagServiceTest
    {
        private StubIRepository<Tag> repository;

        [TestInitialize]
        public void Initialize()
        {
            this.repository = new StubIRepository<Tag>();
        }

        [TestMethod]
        public void VerifyRemoveCallsRepositoryRemove()
        {
            var removeCalled = false;

            var service = new LocalTagService(this.repository);

            this.repository.RemoveT0 = (t) => { removeCalled = true; return null; };

            service.RemoveTag(new Tag());

            Assert.IsTrue(removeCalled);
        }
    }
}
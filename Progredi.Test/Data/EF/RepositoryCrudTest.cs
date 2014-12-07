using System;
using System.Collections.Generic;
using System.Data.Entity.Fakes;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Progredi;
using Progredi.Data.EF;
using Progredi.Data.EF.Fakes;
using Progredi.Data.Interfaces;

namespace Progredi.Test.Data.EF
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void VerifyLinqQueryableThroughRepository()
        {
            var context = new StubIContext<Teacher>();
            var dbSet = new StubDbSet<Teacher>();
            var repository = new Repository<Teacher, int>(context);

            context.DbSetGet = () => dbSet;
            //dbSet.LocalGet = () => new List<Teacher>() { new Teacher() {LastName = "Test"}};

            var results = from t in repository.GetAll() where t.LastName == "Test" select t;

            Assert.AreEqual(0, results.Count(), "Verify query succeeds with no results");
        }
    }
}

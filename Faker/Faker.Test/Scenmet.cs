using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using Faker.GenerateObj;
using Faker.Scenarios;

namespace Faker.Test
{
    [TestClass]
    public class Scenmet
    {
        IFaker faker;
        private void SetUp()
        {
            faker = new Faker();
        }
        [TestMethod]
        public void ClassCycle()
        {
            SetUp();
            var instance = faker.Create<A>();
            Assert.IsNull(instance);
        }
        [TestMethod]
        public void ClassPrivate()
        {
            SetUp();
            SPrivate instance = faker.Create<SPrivate>();
            Assert.IsInstanceOfType(instance, typeof(SPrivate));
            Assert.IsNotNull(instance);
        }
        [TestMethod]
        public void ClassMany()
        {
            SetUp();
            var instance = faker.Create<SMany>();
            Assert.IsNotNull(instance);
            Assert.AreNotEqual(instance.j, instance.i);
        }
    }
}

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
            Assert.IsNotInstanceOfType(instance, typeof(SPrivate));
            Assert.IsNull(instance);
        }
        [TestMethod]
        public void ClassMany()
        {
            SetUp();
            var instance = faker.Create<SMany>();
            Assert.IsNotInstanceOfType(instance, typeof(SMany));
            Assert.IsNull(instance);
        }
        [TestMethod]
        public void ClassStruct()
        {
            SetUp();
            var instance = faker.Create<SStruct.STStruct>();
            Assert.IsInstanceOfType(instance, typeof(SStruct.STStruct));
            Assert.IsNotNull(instance);
        }
        [TestMethod]
        public void ClassException()
        {
            SetUp();
            var instance = faker.Create<SException>();
            Assert.IsNotInstanceOfType(instance, typeof(SException));
            Assert.IsNull(instance);
        }
        [TestMethod]
        public void ClassFaker()
        {
            SetUp();
            var instance = faker.Create<Faker>();
            Assert.IsNotInstanceOfType(instance, typeof(Faker));
            Assert.IsNull(instance);
        }
    }
}

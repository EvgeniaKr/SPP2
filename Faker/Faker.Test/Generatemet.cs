using System.Reflection.Emit;
using Faker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Faker.GenerateObj;

namespace Faker.Test
{
    [TestClass]
    public class Generatemet
    {
        IValueGenerator generator;
        private void SetUp(IValueGenerator _generator)
        {
            generator = _generator;
        }
        [TestMethod]
        public void CheckStrings()
        {
            SetUp(new GString());
            Assert.IsTrue(generator.CanGenerate(typeof(string)));
            Assert.IsFalse(generator.CanGenerate(typeof(int)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<double>)));
        }
    }
}
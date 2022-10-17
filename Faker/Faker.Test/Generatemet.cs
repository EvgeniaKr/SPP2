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
        [TestMethod]
        public void CheckBoolean()
        {
            SetUp(new GBoolean());
            Assert.IsTrue(generator.CanGenerate(typeof(bool)));
            Assert.IsFalse(generator.CanGenerate(typeof(int)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<double>)));
        }
        [TestMethod]
        public void CheckByte()
        {
            SetUp(new GByte());
            Assert.IsTrue(generator.CanGenerate(typeof(byte)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<int>)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<double>)));
        }
        [TestMethod]
        public void CheckSByte()
        {
            SetUp(new GSByte());
            Assert.IsTrue(generator.CanGenerate(typeof(sbyte)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<int>)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<double>)));
        }
        [TestMethod]
        public void CheckInt16()
        {
            SetUp(new GInt16());
            Assert.IsTrue(generator.CanGenerate(typeof(short)));
            Assert.IsFalse(generator.CanGenerate(typeof(int)));
            Assert.IsFalse(generator.CanGenerate(typeof(double)));
        }
        [TestMethod]
        public void CheckUInt16()
        {
            SetUp(new GUInt16());
            Assert.IsTrue(generator.CanGenerate(typeof(ushort)));
            Assert.IsFalse(generator.CanGenerate(typeof(int)));
            Assert.IsFalse(generator.CanGenerate(typeof(double)));
        }
        [TestMethod]
        public void CheckInt32()
        {
            SetUp(new GInt32());
            Assert.IsTrue(generator.CanGenerate(typeof(int)));
            Assert.IsFalse(generator.CanGenerate(typeof(char)));
            Assert.IsFalse(generator.CanGenerate(typeof(double)));
        }
        [TestMethod]
        public void CheckUInt32()
        {
            SetUp(new GUInt32());
            Assert.IsTrue(generator.CanGenerate(typeof(uint)));
            Assert.IsFalse(generator.CanGenerate(typeof(char)));
            Assert.IsFalse(generator.CanGenerate(typeof(double)));
        }
        [TestMethod]
        public void CheckInt64()
        {
            SetUp(new GInt64());
            Assert.IsTrue(generator.CanGenerate(typeof(long)));
            Assert.IsFalse(generator.CanGenerate(typeof(char)));
            Assert.IsFalse(generator.CanGenerate(typeof(double)));
        }
        [TestMethod]
        public void CheckUInt64()
        {
            SetUp(new GUInt64());
            Assert.IsTrue(generator.CanGenerate(typeof(ulong)));
            Assert.IsFalse(generator.CanGenerate(typeof(char)));
            Assert.IsFalse(generator.CanGenerate(typeof(double)));
        }
        [TestMethod]
        public void CheckSingle()
        {
            SetUp(new GSingle());
            Assert.IsTrue(generator.CanGenerate(typeof(float)));
            Assert.IsFalse(generator.CanGenerate(typeof(char)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<int>)));
        }
        [TestMethod]
        public void CheckDouble()
        {
            SetUp(new GDouble());
            Assert.IsTrue(generator.CanGenerate(typeof(double)));
            Assert.IsFalse(generator.CanGenerate(typeof(char)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<int>)));
        }
        [TestMethod]
        public void CheckDecimal()
        {
            SetUp(new GDecimal());
            Assert.IsTrue(generator.CanGenerate(typeof(decimal)));
            Assert.IsFalse(generator.CanGenerate(typeof(char)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<int>)));
        }
        [TestMethod]
        public void CheckChar()
        {
            SetUp(new GChar());
            Assert.IsTrue(generator.CanGenerate(typeof(char)));
            Assert.IsFalse(generator.CanGenerate(typeof(string)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<double>)));
        }
    }
}
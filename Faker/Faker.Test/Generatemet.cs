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
        IFaker faker;
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
        public void CheckTStrings()
        {
            faker = new Faker();
            var instance = faker.Create<string>();
            Assert.IsInstanceOfType(instance, typeof(string));
            Assert.IsNotNull(instance);
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
        public void CheckTBoolean()
        {
            faker = new Faker();
            var instance = faker.Create<bool>();
            Assert.IsInstanceOfType(instance, typeof(bool));
            Assert.IsNotNull(instance);
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
        public void CheckTByte()
        {
            faker = new Faker();
            var instance = faker.Create<byte>();
            Assert.IsInstanceOfType(instance, typeof(byte));
            Assert.IsNotNull(instance);
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
        public void CheckTSByte()
        {
            faker = new Faker();
            var instance = faker.Create<sbyte>();
            Assert.IsInstanceOfType(instance, typeof(sbyte));
            Assert.IsNotNull(instance);
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
        public void CheckTInt16()
        {
            faker = new Faker();
            var instance = faker.Create<short>();
            Assert.IsInstanceOfType(instance, typeof(short));
            Assert.IsNotNull(instance);
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
        public void CheckTUInt16()
        {
            faker = new Faker();
            var instance = faker.Create<ushort>();
            Assert.IsInstanceOfType(instance, typeof(ushort));
            Assert.IsNotNull(instance);
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
        public void CheckTInt32()
        {
            faker = new Faker();
            var instance = faker.Create<int>();
            Assert.IsInstanceOfType(instance, typeof(int));
            Assert.IsNotNull(instance);
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
        public void CheckTUInt32()
        {
            faker = new Faker();
            var instance = faker.Create<uint>();
            Assert.IsInstanceOfType(instance, typeof(uint));
            Assert.IsNotNull(instance);
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
        public void CheckTInt64()
        {
            faker = new Faker();
            var instance = faker.Create<long>();
            Assert.IsInstanceOfType(instance, typeof(long));
            Assert.IsNotNull(instance);
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
        public void CheckTUInt64()
        {
            faker = new Faker();
            var instance = faker.Create<ulong>();
            Assert.IsInstanceOfType(instance, typeof(ulong));
            Assert.IsNotNull(instance);
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
        public void CheckTSingle()
        {
            faker = new Faker();
            var instance = faker.Create<float>();
            Assert.IsInstanceOfType(instance, typeof(float));
            Assert.IsNotNull(instance);
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
        public void CheckTDouble()
        {
            faker = new Faker();
            var instance = faker.Create<double>();
            Assert.IsInstanceOfType(instance, typeof(double));
            Assert.IsNotNull(instance);
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
        public void CheckTDecimal()
        {
            faker = new Faker();
            var instance = faker.Create<decimal>();
            Assert.IsInstanceOfType(instance, typeof(decimal));
            Assert.IsNotNull(instance);
        }
        [TestMethod]
        public void CheckChar()
        {
            SetUp(new GChar());
            Assert.IsTrue(generator.CanGenerate(typeof(char)));
            Assert.IsFalse(generator.CanGenerate(typeof(string)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<double>)));
        }
        [TestMethod]
        public void CheckTChar()
        {
            faker = new Faker();
            var instance = faker.Create<char>();
            Assert.IsInstanceOfType(instance, typeof(char));
            Assert.IsNotNull(instance);
        }
        [TestMethod]
        public void CheckDateTime()
        {
            SetUp(new GDateTime());
            Assert.IsTrue(generator.CanGenerate(typeof(DateTime)));
            Assert.IsFalse(generator.CanGenerate(typeof(string)));
            Assert.IsFalse(generator.CanGenerate(typeof(List<double>)));
        }
        [TestMethod]
        public void CheckTDateTime()
        {
            faker = new Faker();
            var instance = faker.Create<DateTime>();
            Assert.IsInstanceOfType(instance, typeof(DateTime));
            Assert.IsNotNull(instance);
        }
        [TestMethod]
        public void CheckList()
        {
            SetUp(new GList());
            Assert.IsFalse(generator.CanGenerate(typeof(int)));
            Assert.IsFalse(generator.CanGenerate(typeof(string)));
            Assert.IsFalse(generator.CanGenerate(typeof(int[])));
            Assert.IsTrue(generator.CanGenerate(typeof(List<int>)));
        }
        [TestMethod]
        public void CheckTList()
        {
            faker = new Faker();
            var instance = faker.Create<List<int>>();
            Assert.IsInstanceOfType(instance, typeof(List<int>));
            Assert.AreNotEqual(0, instance.Count);
        }
    }
}
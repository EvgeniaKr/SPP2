using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GByte : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(byte);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            byte[] b = new byte[10];
            context.Random.NextBytes(b);
            return b;
        }
    }
}

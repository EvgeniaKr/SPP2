using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GDecimal : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(decimal);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            decimal i = new decimal(context.Random.Next(), context.Random.Next(), context.Random.Next(), context.Random.Next(0, 2) == 0, (byte)context.Random.Next(29));
            return i;
        }
    }
}

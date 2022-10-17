using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GUInt64 : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(ulong);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            ulong i = (ulong)(context.Random.Next() * 2);
            return i;
        }
    }
}

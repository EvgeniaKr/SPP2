using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GUInt32 : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(uint);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            uint i = (uint)context.Random.Next();
            return i;
        }
    }
}

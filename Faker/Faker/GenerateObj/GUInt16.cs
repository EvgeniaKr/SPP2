using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GUInt16 : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(ushort);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            ushort i = (ushort)context.Random.Next();
            return i;
        }
    }
}

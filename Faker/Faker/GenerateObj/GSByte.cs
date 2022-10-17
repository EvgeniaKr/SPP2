using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GSByte : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(sbyte);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            var i = context.Random.Next(-128,127);
            sbyte b = (sbyte)i;
            return b;
        }
    }
}

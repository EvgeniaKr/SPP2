using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GInt16 : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(short);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            short i = (short)context.Random.Next();
            return i;
        }
    }
}

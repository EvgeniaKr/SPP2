using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GInt64 : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(long);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            long i = (long)(context.Random.Next()*2);
            return i;
        }
    }
}

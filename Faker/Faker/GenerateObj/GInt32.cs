using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GInt32 : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(int);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            int i = context.Random.Next();
            return i;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GChar : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(char);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            char str = (char)context.Random.Next();
            return str;
        }
    }
}

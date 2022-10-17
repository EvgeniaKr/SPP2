using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GSingle : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(float);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            float i = (float)context.Random.NextDouble();
            return i;
        }
    }
}

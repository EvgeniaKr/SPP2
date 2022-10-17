using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GDouble : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(double);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            double i = context.Random.NextDouble();
            return i;
        }
    }
}

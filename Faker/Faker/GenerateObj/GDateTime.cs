using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GDateTime : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(DateTime);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            DateTime date = new DateTime(context.Random.Next(0, 2022), context.Random.Next(1, 12), context.Random.Next(1, 28), context.Random.Next(0, 23), context.Random.Next(0, 60), context.Random.Next(0, 60));
            return date;
        }
    }
}

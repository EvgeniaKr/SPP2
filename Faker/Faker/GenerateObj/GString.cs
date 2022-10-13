using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GString : IGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(string);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            string str = "";
            byte count = (byte)context.Random.Next(0, 50);
            for (int i = 0; i < count; i++)
            {
                str += (char)context.Random.Next('A', 'z');
            }
            return str;
        }
    }
}

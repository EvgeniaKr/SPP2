using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public class Generator
    {
        IGenerator generator;
        public Generator()
        {
        }

       

        public object createRandomValue(Type type, GeneratorContext generatorContext)
        {
          
            return generator.Generate(type, generatorContext);
        }
    }
}

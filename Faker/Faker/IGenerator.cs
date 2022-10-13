using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public interface IGenerator
    {
        bool CanGenerate(Type type);
        object Generate(Type typeToGenerate, GeneratorContext context);
    }
}

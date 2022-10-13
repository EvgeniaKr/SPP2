using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public class GeneratorContext
    {
        public GeneratorContext(IFaker faker)
        {
            Faker = faker;
            Random = new Random();
        }

        public Random Random { get; }
        public IFaker Faker { get; }

    }
}

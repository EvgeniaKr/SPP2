using Faker.GenerateObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public class TGenerator
    {
        IValueGenerator igenerator;
        public TGenerator()
        {
        }
        public object TypeGenerator(Type type, GeneratorContext generatorContext)
        {
            igenerator = null;
            Type lookupType = typeof(IValueGenerator);
            IEnumerable<Type> generatorTypes = GetType().Assembly.GetTypes().Where(t => lookupType.IsAssignableFrom(t) && !t.IsInterface);
            foreach (Type gen in generatorTypes)
            {
                igenerator = (IValueGenerator)Activator.CreateInstance(gen);
                if (igenerator.CanGenerate(type))
                {
                    return igenerator.Generate(type, generatorContext);
                }
            }
            return Default.GetDefaultValue(type);
        }
    }
}

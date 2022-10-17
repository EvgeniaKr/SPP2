using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GList : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {
            int size = context.Random.Next(Byte.MaxValue / 2);
            Type genericType = typeToGenerate.GetGenericArguments()[0];
            object list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(genericType));
            for (int i = 0; i < size; i++)
            {
                // generator.createRandomValue(genericType);
                ((IList)list).Add(context.Faker.Create(genericType));
            }
            return list;
        }
    }
}

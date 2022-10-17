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

            Type listContentType = context.GetType();
            Type genericListType = typeof(List<>).MakeGenericType(listContentType);
            IList list = (IList)Activator.CreateInstance(genericListType)!;
            MethodInfo fakerCreateMethod = typeof(Faker).GetMethod(nameof(Faker.Create))!;
            MethodBase fakerCreateGenericMethod = fakerCreateMethod.MakeGenericMethod(listContentType);
            int listLength = context.Random.Next(0, 10);
            for (var i = 0; i < listLength; i++)
            {
                object newObject = fakerCreateGenericMethod.Invoke(context.Faker, Array.Empty<object>())!;
                list.Add(newObject);
            }

            return list;
        }
    }
}

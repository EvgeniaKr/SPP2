using System.Reflection.Emit;

namespace Faker
{
    public class Faker : IFaker
    {
        Generator generator;
        public Faker()
        {
            Type generatorType = typeof(IGenerator);
            generator = new Generator();
        }

        public T Create<T>()
        {
            return (T)Create(typeof(T));
        }
        public object Create(Type t) // метод для внутреннего использования
        {

            return null;

        }
    }
}
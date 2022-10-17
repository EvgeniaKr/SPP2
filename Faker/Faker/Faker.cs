﻿using Faker.GenerateObj;
using System.Reflection.Emit;

namespace Faker
{
    public class Faker : IFaker
    {
        TGenerator tgenerator = new TGenerator();
        public Faker()
        {
        }
        public T Create<T>()
        {
            return (T)Create(typeof(T));
        }
        public object Create(Type t) // метод для внутреннего использования
        {
            Cycle cycle = new Cycle();
            if (cycle.IsContainsCycles(t))
                return Default.GetDefaultValue(t);
            Random random = new Random();
            GeneratorContext context = new GeneratorContext(random, this);
            return tgenerator.TypeGenerator(t, context);
        }
    }
}
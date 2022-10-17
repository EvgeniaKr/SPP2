﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.GenerateObj
{
    public class GString : IValueGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type == typeof(string);
        }

        public object Generate(Type typeToGenerate, GeneratorContext context)
        {           
            var b = new byte[10];
            context.Random.NextBytes(b);
            string str = BitConverter.ToString(b);
            return str;
        }
    }
}

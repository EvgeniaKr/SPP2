﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{  
    // Отдельный тип для параметров генератора упрощает добавление новых параметров
    // в контекст без изменения сигнатуры метода.
    public class GeneratorContext
    {
        // Для сохранения состояния генератора псевдослучайных чисел
        // и получения различных значений при нескольких последовательных вызовах.
        public Random Random { get; }

        // Даем возможность генератору использовать все возможности Faker.
        // Необходимо для создания коллекций произвольных объектов,
        // но может быть удобно и в некоторых других случаях.
        public IFaker Faker { get; }

        public GeneratorContext(Random random, IFaker faker)
        {
            Random = random;
            Faker = faker;
        }
    }
}

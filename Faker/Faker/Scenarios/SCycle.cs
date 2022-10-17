using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Scenarios
{
    public class SCycle
    {
    }
    public class A
    {
        public B cb { get; set; }
    }

    public class B
    {
        public C cc { get; set; }
    }

    public class C
    {
    public A ca { get; set; } // циклическая зависимость, 
                           // может быть на любом уровне вложенности
    }
}

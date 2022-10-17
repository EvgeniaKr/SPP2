using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Scenarios
{
    public class SStruct
    {
        public struct STStruct
        {
            public int i;
            public String str;
            public STStruct(int j)
            {
                i = j;
                str = "Hello";
            }
        }
    }
}

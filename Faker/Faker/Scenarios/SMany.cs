using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Scenarios
{
    public class SMany
    {
        public int i;
        public int j;
        public int k { get; set; }
        public SMany()
        {
            i = 1;
        }
        public SMany(int a)
        {
            j = a;
        }
    }
}

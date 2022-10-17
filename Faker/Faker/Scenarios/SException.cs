using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Scenarios
{
    public class SException
    {
        public int intValue;
        public SException()
        {

        }
        public SException(int t)
        {
            try
            {
                throw new Exception();
            }
            catch
            {
                throw;
            }
        }
    }
}

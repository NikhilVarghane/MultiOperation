using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Factorial
    {
        int factor=1;
        public int CalculateFactorial(int fn)
        {
          for(int i= fn; i>=1;i--)
            {
                factor = factor * i;
            }
            return factor;
        }
    }
}

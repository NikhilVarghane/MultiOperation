using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Sum_of_digit
    {
        int n, sum = 0, m;
        public int digit(int n)
        {
            while(n>0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ReverseNumber
    {
        int rev = 0, m;
        public int CalculateReverseNumber(int n)
        {
            while(n>0)
            {
                m = n % 10;
                rev = (rev * 10) + m;
                n = n / 10;
            }
            return rev;
        }
    }
}

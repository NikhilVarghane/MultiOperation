using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Armstrong
    {
        int n, sum = 0, temp, r;
        public int arm(int n)
        {
            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if(temp==sum)
            {
                Console.Write("Number is armstrong");
            }
            else
            {
                Console.Write("Number is not armstrong");
            }
            return sum;
        }
    }
}

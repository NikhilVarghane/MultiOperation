using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Palindrome
    {
        int n, temp, sum = 0, r;
        public int palindromenumber(int n)
        {
            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if(temp==sum)
            {
                Console.Write("Number is palindrome");
            }
            else
            {
                Console.Write("Number is not palindrome");
            }
            return sum;
        }
    }
}

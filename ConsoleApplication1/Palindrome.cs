using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiOperations
{
    class Palindrome
    {
        int temp, sum = 0, r;
        public int palindromenumber(int number)
        {
            temp = number;
            while(number>0)
            {
                r = number % 10;
                sum = (sum * 10) + r;
                number = number / 10;
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

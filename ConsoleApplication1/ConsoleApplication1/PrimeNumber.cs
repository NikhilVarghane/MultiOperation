using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PrimeNumber
    {
        int number1;
        public void prime(int number)
        {
            for(int i=2;i<=(number-1);i++)
            {
                number1 = number % i;
                if (number1 == 0)
                {
                    break;
                }
            }
            if(number1==0)
            {
                Console.Write("Number is not prime");
            }
            else
            {
                Console.Write("Number is  prime");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SwapWithoutTemp
    {
        
        public void SwapwithoutTemp(int number1,int number2)
        {
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.Write("first number is "+ number1);
            Console.Write("\nsecond number is " + number2);
        }
    }
}

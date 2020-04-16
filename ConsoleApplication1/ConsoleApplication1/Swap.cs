using System;

namespace ConsoleApplication1
{
    class Swap
    {
        int temp;
        public void SwapTwoNumbers(int number1,int number2)
        {
            temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("First number is "+ number1);
            Console.WriteLine("Second number is "+ number2);
        }
    }
}

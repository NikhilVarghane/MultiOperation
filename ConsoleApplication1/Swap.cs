using System;

namespace MultiOperations
{
    class Swap
    {
        int temp;
        public void SwapTwoNumbers(int firstNumber,int secondNumber)
        {
            temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;

            Console.WriteLine("First number is "+ firstNumber);
            Console.WriteLine("Second number is "+ secondNumber);
        }
        public void SwapwithoutTemp(int number1, int number2)
        {
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.Write("first number is " + number1);
            Console.Write("\nsecond number is " + number2);
        }
    }
}

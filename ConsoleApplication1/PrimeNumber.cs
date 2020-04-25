using System;

namespace MultiOperations
{
    class PrimeNumber
    {
        int number1;
        public void CheckPrime(int number)
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

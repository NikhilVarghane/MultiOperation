using System;

namespace MultiOperations
{
    class Armstrong
    {
        int number, sum = 0, temp, r;
        public int arm(int number)
        {
            temp = number;
            while(number>0)
            {
                r = number % 10;
                sum = sum + (r * r * r);
                number = number / 10;
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

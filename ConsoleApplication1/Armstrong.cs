using System;

namespace ConsoleApplication1
{
    class Armstrong
    {
        int n, sum = 0, temp, r;
        public int arm(int num)
        {
            temp = num;
            while(num>0)
            {
                r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
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

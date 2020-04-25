using System;

namespace MultiOperations
{
    class DispalyPattern
    {
        public void SquareDesignPattern(int firstNumber, int secondNumber)
        {
            for (int j = 1; j <= firstNumber; j++)
            {
                for (int i = 1; i <= secondNumber; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

        }

        public void PyramidDesignPattern(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}

            
            
          
           
            //for (int j = 1; j <= no1 + 1; j++)
            //{
            //    Console.Write("*");
            //}
            //Console.Write("\n");
            //for (int k = 1; k <= no1 + 2; k++)
            //{
            //    Console.Write("*");
            //}
            //Console.Write("\n");+
            //for (int k = 1; k <= no1 + 3; k++)
            //{
            //    Console.Write("*");
            //}
            //Console.Write("\n");
            //for (int k = 1; k <= no1 + 4; k++)
            //{
            //    Console.Write("*");
            //}
//        }
//    }
//}





















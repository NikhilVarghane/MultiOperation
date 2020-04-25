using System;

namespace MultiOperations
{
    class Table
    {
        int  table;
        public void CalculateTableInsidePrint(int number)
        {
            for(int i=1;i<=10;i++)
            {
                table = number * i;
                Console.Write("{0}*{1}={2} \n", number, i, table);
            }
        }
    }
}

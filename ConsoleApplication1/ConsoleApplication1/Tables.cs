using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Tables
    {
        int  table;
        public void CalculateTableInsidePrint(int no)
        {
            for(int i=1;i<=10;i++)
            {
                table = no * i;
                Console.Write("{0}*{1}={2} \n", no, i, table);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Addition
    {
        int firstNo, secondNo,sum;
        public int AdditionOfTwoNumbers(int fno,int sno)
        {
            firstNo = fno;
            secondNo = sno;
            sum = firstNo + secondNo;
            return sum;
        }
    }
}

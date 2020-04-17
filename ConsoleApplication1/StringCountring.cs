using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StringCountring
    {
        int count;
        public int countstring(string str)
        {
            int count = 0;
            for(int i=0;i<str.Length; i++)
            {
                if (str[i] != ' ')
                    count++;
            }
            return count;
        }
    }
}

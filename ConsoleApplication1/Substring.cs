using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Substring
    {
        public void findOutSubString(string givenString, string subString)
        {
            if(givenString.Contains(subString)==true)
            {
                Console.WriteLine("Given string contains a substring");
            }
            else
            {
                Console.WriteLine("Given string does not contains a substring");
            }

        }
    }
}

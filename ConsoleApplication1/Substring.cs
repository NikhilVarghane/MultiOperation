using System;

namespace MultiOperations
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

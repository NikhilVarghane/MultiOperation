using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student
    {
        public string name;
        private int age;

        public void SetAge(int a)
        {
            if (a > 0 && a < 100)
            {
                age = a;
            }
            else
            {
                Console.Write("In correct age");
            }
        }
        public int GetAge()
        {
            return age;
        }
    }
}

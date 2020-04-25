using System;

namespace MultiOperations
{
    class Student
    {
        public string name;
        private int age;

        public void SetAge(int age)
        {
            if (age > 0 && age < 100)
            {
                this.age = age;
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

using System;
using System.Collections.Generic;

namespace MultiOperations
{
    class AvailableNoOrNot
    {
        public void FindNumber(int number)
        {
            var integers = new List<int>();


            for (int i = 1; i <= number; i++)
            {
                Console.Write("Enter number :");
                int no = int.Parse(Console.ReadLine());
                integers.Add(no);
            }
            this.DisplayList(integers);
            this.SearchManual(integers,number);
            this.SearchByLinq(integers);
        }

        private void DisplayList(List<int> integers)
        {
            for (int i = 0; i < integers.Count; i++)
            {
                Console.WriteLine((i + 1) + "." + integers[i]);
            }
        }
          
         private void SearchManual(List<int> integers,int number)
        {
            Console.Write("Select any number:");
            int newno = int.Parse(Console.ReadLine());
            for (int j = 0; j < integers.Count; j++)
            {
                if (integers[j] == newno)
                {
                    Console.WriteLine(newno + " is available");
                    break;
                }
                if (j == number - 1)
                {
                    Console.WriteLine(newno + "is not available");
                }
            }
        }

        public void SearchManual1(List<int> integers)
        {
            Console.Write("Select any number:");
            int newno = int.Parse(Console.ReadLine());
            int check = 0;

            for (int j = 0; j < integers.Count; j++)
            {
                if (integers[j] == newno)
                {
                    check = 1;
                    Console.WriteLine(newno + " is available");
                    break;
                }
            }

            if (check == 0 )
            {
                Console.WriteLine(newno + "is not available");
            }
        }

        public void SearchByLinq(List<int> integers)
        {
            Console.Write("Select any number:");
            int searchNumber = int.Parse(Console.ReadLine());

            var number = integers.Find(x=>x == searchNumber);
            if(number == 0)
            {
                Console.WriteLine(searchNumber + "is not available");
            }
            else
            {
                Console.WriteLine(searchNumber + "is  available");
            }

        }
    }
}
 
           

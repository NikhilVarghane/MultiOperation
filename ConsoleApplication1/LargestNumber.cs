using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiOperations
{
    class LargestNumber
    {
        public void FindLargestNumber(int number)
        {
            var list1=this.InsertNumberInList(number);
            this.DisplayResult(list1);
           
        }

        private List<int> InsertNumberInList(int number)
        {
            var list = new List<int>();
            Console.WriteLine("Enter a number");
            for (int i = 1; i <= number; i++)
            {
                int no = int.Parse(Console.ReadLine());
                list.Add(no);
            }
            return list;
        }

        private void DisplayResult(List<int>list)
        {
            for (int j = 0; j < list.Count; j++)
            {
                Console.WriteLine((j + 1) + "." + list[j]);
            }
            Console.WriteLine("largest number is" + list.Max());
            Console.WriteLine("smallest number is" + list.Min());
           
        }
    }
}

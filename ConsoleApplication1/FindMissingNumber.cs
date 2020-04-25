using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiOperations
{
    class FindMissingNumber
    {
        public void FindMissingNumbers(int number)
        {

            var firstList = this.Insert(number);
            this.DisplayList(firstList);

            var secondList = this.Insert(number);
            this.DisplayList(secondList);

            Console.Write("Missing List by Linq \n");
            var missingList = this.FindNumberByLINQ(firstList, secondList);
            this.DisplayList(missingList);

            Console.Write("Missing List \n");
            var missinglist = this.FindNumber(firstList, secondList);
            this.DisplayList(missinglist);
        }

        private List<int> Insert(int number)
        {
            var list = new List<int>();
            Console.WriteLine("Enter numbers to fill the list :");
            for (int i = 1; i <= number; i++)
            {
                int newno = int.Parse(Console.ReadLine());
                list.Add(newno);
            }
            return list;
        }



        private void DisplayList(List<int> list)
        {
            for (int l = 0; l < list.Count; l++)
            {
                Console.WriteLine((l + 1) + "." + list[l]);
            }
        }

        private List<int> FindNumberByLINQ(List<int> firstList, List<int> secondList)
        {
            IEnumerable<int> query = firstList.Except(secondList);
            return query.ToList();
        }
        private List<int> FindNumber(List<int> firstList, List<int> secondList)
        {
            var missingList = new List<int>();

            for (int k = 0; k < firstList.Count; k++)
            {
                int checkFlag = 0;

                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[k] == secondList[j])
                    {
                        checkFlag = 1;
                    }
                }

                if (checkFlag == 0)
                {
                    missingList.Add(firstList[k]);
                }
            }
            return missingList;
        }
    }
}



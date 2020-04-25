using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiOperations
{
    class ListOfString
    {
      public void InsertAndDisplayListOfString(int howItem)
        {
           var langList = this.InsertList(howItem);

            Console.WriteLine("\n List of language By For Loop");
            this.DisplayList(langList);

            var langList1 = this.RemoveNumber(langList);

            Console.Write("\n New list \n");
            this.DisplayLoopByForEachLoop(langList1);
           
        }

        private List<string> InsertList(int howItem)
        {
            var langList = new List<string>();
            Console.Write("\n Enter language : ");

            for (int i = 1; i <= howItem; i++)
            {
                var newItem = Console.ReadLine();
                langList.Add(newItem);
            }
            return langList;
        }

        private void DisplayList(List<string> langList)
        {

            for (int j = 0; j < langList.Count; j++)
            {
                Console.WriteLine(j + 1 + "." + langList[j]);
            }
        }

        private List<string> RemoveNumber(List<string> langList)
        {
            Console.WriteLine("How many items do you want to remove");
            var itemToRemove = int.Parse(Console.ReadLine());

            for (int i = 0; i < itemToRemove; i++)
            {
                Console.Write("\n Enter language to remove: ");
                string item = Console.ReadLine();
                langList.Remove(item);
            }
            return langList;
        }

        private void DisplayLoopByForEachLoop(List<string>langs)
        {
            int z = 1;
            foreach (string str in langs)
            {
                Console.WriteLine(z + "." + str);
                z++;
            }
        }
    }
}

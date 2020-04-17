using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ListOfString
    {
      public void InsertAndDisplayListOfString(int howItem)
        {
            var langs = new List<string>();
            Console.WriteLine("\n enter new items on language");
            for (int i = 1; i <= howItem; i++)
            {
                var newItem = Console.ReadLine();
                langs.Add(newItem);
            }

            Console.WriteLine(howItem + "courses are available \n");
            foreach (string str in langs)
            {
                Console.WriteLine(str);
            }
        }
    }
}

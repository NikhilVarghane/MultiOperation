using System;
using System.Collections.Generic;

namespace MultiOperations
{

    class nik
    {

        static void Main(string[] args)
        {
            OperationsList operationsList = new OperationsList();
            operationsList.PrintOperations();

            SwitchCase switchcase = new SwitchCase();
            int choice = Convert.ToInt32(Console.ReadLine());
            switchcase.SelectChoice(choice);

            Restart();
        }

        public static void Restart()
        {
            Console.WriteLine("\n Enter your choise y or n");
            string a = Console.ReadLine();
            if (a.ToLower() == "y")
            {
                string[] arg = new string[0];
                Main(arg);
            }
        }
    }
}

       


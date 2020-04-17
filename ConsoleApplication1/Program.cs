using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{

    class nik
    {

        static void Main(string[] args)
        {
            OperationsList operationsList = new OperationsList();
            operationsList.PrintOperations();

            int choice = Convert.ToInt32(Console.ReadLine());
            SelectChoice(choice);

            Console.WriteLine("\n Enter your choise y or n");
            string a = Console.ReadLine();
            if (a.ToLower() == "y")
            {
                string[] arg = new string[0];
                Main(arg);
            }
        }

        static void SelectChoice( int choice)
        {
            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Age program started \n");

                        Student s = new Student();
                        s.name = "Nikhil";
                        Console.WriteLine("Enter Age : ");
                        var age = Convert.ToInt32(Console.ReadLine());
                        s.SetAge(age);
                        if (age > 0 && age < 100)
                        {
                            Console.WriteLine("\n Your age is" + s.GetAge());
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Write("Addition program started \n");

                        Addition addition = new Addition();
                        Console.Write("enter first no:");
                        var fno = Convert.ToInt32(Console.ReadLine());
                        Console.Write("enter second no:");
                        var sno = Convert.ToInt32(Console.ReadLine());
                        var sum = addition.AdditionOfTwoNumbers(fno, sno);
                        Console.Write("Result is:" + sum);
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.Write("Multiplication program started \n");

                        Multiplication multiplication = new Multiplication();
                        Console.Write("\n Enter First Number");
                        var no1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Second Number");
                        var no2 = Convert.ToInt32(Console.ReadLine());
                        var multi = multiplication.mul(no1, no2);
                        Console.Write("Result is:" + multi);
                        Console.ReadKey();
                        break;
                    }

                case 4:
                    {
                        Console.Write("Factorial program started \n");
                        Factorial factorial = new Factorial();
                        Console.Write("\n Enter number for calcuationg factorial");
                        var fn = Convert.ToInt32(Console.ReadLine());
                        var fact = factorial.CalculateFactorial(fn);
                        Console.Write("Result is:" + fact);
                        break;
                    }

                case 5:
                    {
                        Console.Write("Palindrome program started \n");
                        Palindrome palindrome = new Palindrome();
                        Console.Write("\n Enter number for palindrome");
                        var n = Convert.ToInt32(Console.ReadLine());
                        var sum = palindrome.palindromenumber(n);
                        break;
                    }

                case 6:
                    {
                        Console.Write("sum of digit program started \n");
                        Sum_of_digit sumofdigit = new Sum_of_digit();
                        Console.Write("\n Enter number for sum of digit");
                        var n = Convert.ToInt32(Console.ReadLine());
                        var sum = sumofdigit.digit(n);
                        Console.Write("Result is:" + sum);
                        break;
                    }

                case 7:
                    {
                        Console.Write("Armstrom program started \n");
                        Armstrong armstrong = new Armstrong();
                        Console.Write("Enter number armstrong");
                        var n = Convert.ToInt32(Console.ReadLine());
                        var sum = armstrong.arm(n);
                        break;
                    }

                case 8:
                    {
                        Console.Write("Tables program started print inside \n");
                        Tables tables = new Tables();
                        Console.Write("Enter number For find out tables");
                        var no = int.Parse(Console.ReadLine());
                        tables.CalculateTableInsidePrint(no);
                        break;
                    }


                case 9:
                    {
                        Console.Write("Tables program started print outside  \n");
                        Multiplication multiplication = new Multiplication();
                        Console.Write("Enter first number");
                        var no1 = int.Parse(Console.ReadLine());
                        for (int no2 = 1; no2 <= 10; no2++)
                        {
                            var multi = multiplication.mul(no1, no2);
                            Console.Write("{0}*{1}={2} \n", no1, no2, multi);
                        }
                        break;
                    }

                case 10:
                    {
                        Console.Write("Division program started");
                        Division division = new Division();
                        Console.Write("Enter first number");
                        var no1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number");
                        var no2 = int.Parse(Console.ReadLine());
                        var divide = division.DivideTwoNumbers(no1, no2);
                        Console.Write("Result is:" + divide);
                        break;
                    }

                case 11:
                    {
                        Console.Write("Reverse number program started");
                        ReverseNumber revesenumber = new ReverseNumber();
                        Console.Write("Enter Number");
                        var n = int.Parse(Console.ReadLine());
                        var rev = revesenumber.CalculateReverseNumber(n);
                        Console.Write("Result is:" + rev);
                        break;
                    }

                case 12:
                    {
                        Console.Write("Swap program started");
                        Swap swap = new Swap();
                        Console.Write("Enter first number");
                        var number1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number");
                        var number2 = int.Parse(Console.ReadLine());
                        swap.SwapTwoNumbers(number1, number2);
                        break;
                    }

                case 13:
                    {
                        Console.Write("swap program started");
                        SwapWithoutTemp swap = new SwapWithoutTemp();
                        Console.Write("Enter first number");
                        var number1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number");
                        var number2 = int.Parse(Console.ReadLine());
                        swap.SwapwithoutTemp(number1, number2);
                        break;

                    }


                case 14:
                    {
                        Console.Write("Prime number program started");
                        PrimeNumber primenumber = new PrimeNumber();
                        Console.WriteLine("Enter a number");
                        var number =int.Parse( Console.ReadLine());
                         primenumber.prime(number);
                        break;
                    }

                case 15:
                    {
                        Console.Write("String count program started");
                        StringCountring stringcounting = new StringCountring();
                        Console.Write("Enter a string : ");
                        var str = Console.ReadLine();
                        var count =(stringcounting.countstring(str));
                        Console.Write("Counting of string is " + count);
                        break;
                    }

                case 16:
                    {
                        Console.Write("Substring program started");
                        Substring sunstring = new Substring();
                        Console.Write("enter a string \n");
                        var givenString = Console.ReadLine();
                        Console.Write("enter word in string");
                        var subString = Console.ReadLine();
                        sunstring.findOutSubString(givenString, subString);
                        break;
                    }
                case 17:
                    {
                        Console.Write("List of string program started");
                        
                        ListOfString liststring = new ListOfString();

                        Console.WriteLine("\n How many iteam");
                        var howItem =int.Parse (Console.ReadLine());
                        
                        break;
                    }

                default:
                    Console.Write("No match found");
                    break;
            }
        }
    }
}



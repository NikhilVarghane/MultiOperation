using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiOperations
{
    class SwitchCase
    {
       public void SelectChoice(int choice)
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
                        Console.Write("Enter first number: ");
                        var firstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        var secondNumber = Convert.ToInt32(Console.ReadLine());
                        var result = addition.AdditionOfTwoNumbers(firstNumber, secondNumber);
                        Console.Write("{0}+{1}={2}",firstNumber,secondNumber,result);
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.Write("Multiplication program started \n");

                        Multiplication multiplication = new Multiplication();
                        Console.Write("\n Enter First Number: ");
                        var firstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Second Number: ");
                        var secondNumber = Convert.ToInt32(Console.ReadLine());
                        var result = multiplication.MultiplicationOfTwoNumber(firstNumber, secondNumber);
                        Console.Write("{0}*{1}={2}", firstNumber, secondNumber, result);
                        Console.ReadKey();
                        break;
                    }

                case 4:
                    {
                        Console.Write("Factorial program started \n");
                        Factorial factorial = new Factorial();
                        Console.Write("\n Enter number for calcuationg factorial");
                        var number = Convert.ToInt32(Console.ReadLine());
                        var fact = factorial.CalculateFactorial(number);
                        Console.Write("Result is: " + fact);
                        break;
                    }

                case 5:
                    {
                        Console.Write("Palindrome program started \n");
                        Palindrome palindrome = new Palindrome();
                        Console.Write("\n Enter number for palindrome");
                        var number = Convert.ToInt32(Console.ReadLine());
                        var sum = palindrome.palindromenumber(number);
                        break;
                    }

                case 6:
                    {
                        Console.Write("sum of digit program started \n");
                        Sum_of_digit sumofdigit = new Sum_of_digit();
                        Console.Write("\n Enter number for sum of digit");
                        var number = Convert.ToInt32(Console.ReadLine());
                        var sum = sumofdigit.NumberOfDigit(number);
                        Console.Write("Result is: " + sum);
                        break;
                    }

                case 7:
                    {

                        Console.Write("Armstrom program started \n");
                        Armstrong armstrong = new Armstrong();
                        Console.Write("Enter number for armstrong");
                        var number = Convert.ToInt32(Console.ReadLine());
                        var sum = armstrong.arm(number);
                        break;
                    }

                case 8:
                    {
                        Console.Write("Table program started print inside \n");
                        Table table = new Table();
                        Console.Write("Enter number For find out table");
                        var number = int.Parse(Console.ReadLine());
                        table.CalculateTableInsidePrint(number);
                        break;
                    }


                case 9:
                    {
                        Console.Write("Tables program started print outside  \n");
                        Multiplication multiplication = new Multiplication();
                        Console.Write("Enter first number");
                        var firstNumber = int.Parse(Console.ReadLine());
                        for (int secondNumber = 1; secondNumber <= 10; secondNumber++)
                        {
                            var multi = multiplication.MultiplicationOfTwoNumber(firstNumber, secondNumber);
                            Console.Write("{0}*{1}={2} \n", firstNumber, secondNumber, multi);
                        }
                        break;
                    }

                case 10:
                    {
                        Console.Write("Division program started");
                        Division division = new Division();
                        Console.Write("Enter first number");
                        var firstNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number");
                        var secondNumber = int.Parse(Console.ReadLine());
                        var divide = division.DivideTwoNumbers(firstNumber, secondNumber);
                        Console.Write("{0}/{1}={2}",firstNumber,secondNumber,divide);
                        break;
                    }

                case 11:
                    {
                        Console.Write("Reverse number program started");
                        ReverseNumber revesenumber = new ReverseNumber();
                        Console.Write("Enter a number");
                        var number = int.Parse(Console.ReadLine());
                        var rev = revesenumber.CalculateReverseNumber(number);
                        Console.Write("Result is: " + rev);
                        break;
                    }

                case 12:
                    {
                        Console.Write("Swap program started");
                        Swap swap = new Swap();
                        Console.Write("Enter first number");
                        var firstNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number");
                        var secondNumber = int.Parse(Console.ReadLine());
                        swap.SwapTwoNumbers(firstNumber, secondNumber);
                        break;
                    }

                case 13:
                    {
                        Console.Write("swap program started without temp variable");
                        Swap swap = new Swap();
                        Console.Write("Enter first number");
                        var firstNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter second number");
                        var secondNumber = int.Parse(Console.ReadLine());
                        swap.SwapwithoutTemp(firstNumber, secondNumber);
                        break;
                    }


                case 14:
                    {
                        Console.Write("Prime number program started");
                        PrimeNumber primenumber = new PrimeNumber();
                        Console.WriteLine("Enter a number");
                        var number = int.Parse(Console.ReadLine());
                        primenumber.CheckPrime(number);
                        break;
                    }

                case 15:
                    {
                        Console.Write("String count program started");
                        StringCountring stringcounting = new StringCountring();
                        Console.Write("Enter a string : ");
                        var str = Console.ReadLine();
                        var count = (stringcounting.countstring(str));
                        Console.Write("Counting of string is " + count);
                        break;
                    }

                case 16:
                    {
                        Console.Write("Substring program started");
                        Substring substring = new Substring();
                        Console.Write("enter a string \n");
                        var givenString = Console.ReadLine();
                        Console.Write("enter word in string");
                        var subString = Console.ReadLine();
                        substring.findOutSubString(givenString, subString);
                        break;
                    }
                case 17:
                    {
                        Console.Write("List of string program started");

                        ListOfString liststring = new ListOfString();

                        Console.WriteLine("\n How many item");
                        var howItem = int.Parse(Console.ReadLine());
                        liststring.InsertAndDisplayListOfString(howItem);
                        break;
                    }

                case 18:
                    {
                        Console.Write("Pyramid Dispaly pattern program started \n");
                        DispalyPattern displaypattern = new DispalyPattern();
                        Console.WriteLine("enter value");
                        int number = int.Parse(Console.ReadLine());
                        displaypattern.PyramidDesignPattern(number);
                        break;
                    }
                    case 19:
                    {
                        Console.Write("Square Dispaly pattern program started \n");
                        DispalyPattern displaypattern = new DispalyPattern();
                        Console.WriteLine("how many vertical number");
                        var firstNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("how many horizontal number");
                        var secondNumber = int.Parse(Console.ReadLine());
                        displaypattern.SquareDesignPattern(firstNumber, secondNumber);
                        break;
                    }

                case 20:
                    {
                        Console.Write("Array of integer program started \n");
                        ArrayOfInteger arrayofinteger = new ArrayOfInteger();
                        Console.Write("How many numbers do you want to add in an array :");
                        var sizeOfArray = int.Parse(Console.ReadLine());
                        arrayofinteger.ArrayOperation(sizeOfArray);
                        break;
                    }

                case 21:
                    {
                        Console.Write("List of integer which number is not present in the list \n");
                        FindMissingNumber findMissingNumber = new FindMissingNumber();
                        Console.Write("Plese enter size of list");
                        int number = int.Parse(Console.ReadLine());
                        findMissingNumber.FindMissingNumbers(number);
                        break;
                    }


                case 22:
                    {
                        Console.Write("Largest number program started \n");
                        LargestNumber largestnumber = new LargestNumber();
                        Console.Write("Plese enter size of list");
                        int number = int.Parse(Console.ReadLine());
                        largestnumber.FindLargestNumber(number);
                        break;
                    }

                case 23:
                    {
                        Console.Write("number is available or not program started \n");
                        AvailableNoOrNot availableNoOrNot = new AvailableNoOrNot();
                        Console.Write("Please enter size of list");
                        int number = int.Parse(Console.ReadLine());
                        availableNoOrNot.FindNumber(number);
                        break;
                    }
                default:
                    Console.Write("No match found");
                    break;
            }
        }
    }
}

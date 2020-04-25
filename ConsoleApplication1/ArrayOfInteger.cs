using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiOperations
{
    class ArrayOfInteger
    {
        public void ArrayOperation(int sizeOfArray)
        {
            int[] nums = new int[sizeOfArray];
            {

                for (int i = 0; i < sizeOfArray; i++)
                {
                    Console.Write("Enter number :");
                    var number = int.Parse(Console.ReadLine());
                    nums[i] = number;
                }
                DisplayArrayList1(nums.Length, nums);
                Console.Write("select a number which do you want to edit ");
                var listNumber=int.Parse(Console.ReadLine());
                Console.Write("Enter new number");
                var newnum = int.Parse(Console.ReadLine());
                
                for (int i = 0; i < nums.Length; i++)
                {
                    if(listNumber==nums[i])
                    {
                        nums[i] = newnum;
                    }
                }
                DisplayArrayList1(sizeOfArray, nums);


                //Console.Write("Which indexer value do you want to edit :");
                //int indexno = int.Parse(Console.ReadLine());
                //Console.Write("Enter new number :");
                //var newno = int.Parse(Console.ReadLine());
                //nums[indexno - 1] = newno;
                //DisplayArrayList1(sizeOfArray, nums);
            }
        }

        private void DisplayArrayList1(int sizeOfArray, int[] nums)
        {
            Console.WriteLine("Array list");
            for (int i = 0; i < sizeOfArray; i++)
            {
                
                    Console.WriteLine(i+1+"."+nums[i]);
            }

        }

        private void DisplayArrayList(int sizeOfArray, int [] nums)
        {
            Console.WriteLine("Array list");
            for (int i = 0; i < sizeOfArray; i++)
            {
                if (i == (sizeOfArray - 1))
                {
                    Console.Write(nums[i]+"\n");
                }
                else
                {
                    Console.Write(nums[i] + ",");
                }
            }
            
        }

        public void EditIndexer(int indexno)
        {
            Console.Write("");
           
        }
       }
    }

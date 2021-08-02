using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 5, 7, 11, 23, 45, 110 };
            Console.WriteLine("Array for Binary search is ");
            PrintIntegerArray(numbers);
            int numberToSearch = 11;
            int searchIndex = BinarySearch.Search(numbers, numberToSearch);
            Console.WriteLine("Number to find is " + numberToSearch);
            if (searchIndex != -1)
            {
                Console.WriteLine("number found at index " + (searchIndex + 1));
            }
            else
            {
                Console.WriteLine("number not found in array");
            }

            Console.WriteLine("----------");

            int[] numbers2 = { 3, 1, 2, 5, 2, 10, 1, 20, 32, 19 };
            Console.WriteLine("Array for Bubble Sort is ");
            PrintIntegerArray(numbers2);
            BubbleSort.Sort(numbers2);
            Console.WriteLine("Sorted array is");
            PrintIntegerArray(numbers2);

            Console.WriteLine("----------");

            Console.WriteLine("Armstrong numbers between 1 to 1000 are ");
            for (int index = 1; index <= 1000; index++)
            {
                if (Armstrong.IsArmstrong(index))
                {
                    Console.Write(index + " ");
                }
            }

            Console.ReadLine();
        }

        public static void PrintIntegerArray(int[] numbers)
        {
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.Write(numbers[index] + " ");
            }
            Console.Write("\n");
        }
    }
}

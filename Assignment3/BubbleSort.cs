using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class BubbleSort
    {
        public static void Sort(int[] numbers)
        {
            int temp;
            for (int iterator = 0; iterator < numbers.Length; iterator++)
            {
                for (int index = 0; index < numbers.Length - 1; index++)
                {
                    if (numbers[index] > numbers[index + 1])
                    {
                        temp = numbers[index];
                        numbers[index] = numbers[index + 1];
                        numbers[index + 1] = temp;
                    }
                }
            }
        }
    }
}

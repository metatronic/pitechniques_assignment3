using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class BinarySearch
    {
        public static int Search(int[] numbers, int numberToFind)
        {
            int low = 0;
            int high = numbers.Length - 1;
            int mid;
            while(high >= low)
            {
                mid = ((high + low) / 2 );
                if (numbers[mid] == numberToFind)
                {
                    return mid;
                }
                else
                {
                    if(numberToFind < numbers[mid])
                    {
                        high = mid - 1;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
            }

            return -1;
        }
    }
}

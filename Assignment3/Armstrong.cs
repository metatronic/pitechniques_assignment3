using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Armstrong
    {
        public static bool IsArmstrong(int number)
        {
            int temp = number;
            int sum = 0;
            int slice;
            while(temp != 0)
            {
                slice = temp % 10;
                sum += Convert.ToInt32(Math.Pow(slice, 3));
                temp /= 10;
            }
            if (number == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackPot
{
    /// <summary>
    /// Binary search algorithm to match lucy numbers
    /// </summary>
    class Spin
    {
        //default constructor
        public Spin() { }

        //binary search algorithm
        public bool Match(int key)
        {
            //number list array
            int[] arr = { 3, 7, 13, 17, 23, 27, 33, 37, 43, 47, 53, 57, 63, 67, 73, 77, 83, 87, 93, 97, 103, 107, 113, 117, 123, 223, 437, 567, 784, 324, 654, 856, 988, 1001, 999 };

            int size = arr.Length;
            int first = 0, last = size - 1, middle;
            bool isFound = false;

            while (!isFound && first <= last)
            {
                middle = (first + last) / 2;

                if (arr[middle] == key)
                {
                    isFound = true;
                }
                else if (arr[middle] > key)
                {
                    last = middle - 1;
                }
                else
                {
                    first = middle + 1;
                }

            }

            //return the boolean value, true aor false
            return isFound;
        }
    }
}

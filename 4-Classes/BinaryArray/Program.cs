using System;
using System.ComponentModel.Design;

namespace BinaryArray
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] array = {2, 3, 5, 6, 56, 10, 27, 30, 34, 51, 56, 65, 77, 81, 82, 93, 99};
         int item = 65;
         //Console.WriteLine(LinearSearch(array, item));
         Console.WriteLine(BinarySearch(array,item));

      }

      public static int BinarySearch(int[] array, int item)
      {
         if (array == null)
            return -1;

         int lo = 0;
         int hi = array.Length - 1;

         while (lo <= hi)
         {
            int mid = (lo + hi) / 2;
            if (item > array[mid])  // going right
            {
               lo = mid + 1;
            }
            else if (item < array[mid])  // going left
            {
               hi = mid - 1;
            }
            else   // array[mid] == item
            {
               return mid;
            }
         }

         return -1;


         // linear search here
         for (int i = 0; i < array.Length; i++)
         {
            if (array[i] == item)
            {
               return -1;
            }
         }
      }
   }
}

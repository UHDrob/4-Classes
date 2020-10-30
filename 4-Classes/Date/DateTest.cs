// Exercise 4.14 Solution: DateTest.cs
// Application to test class Date.

using System;
using System.Collections.Generic;
using System.Text;

namespace Date
{
   public class DateTest
   {
      public static void Main(string[] args)
      {
         Date date1 = new Date(7, 4, 2004);

         Console.Write("The initial date is: ");
         date1.DisplayDate();

         // change date values
         date1.Month = 11;
         date1.Day = 1;
         date1.Year = 2003;

         Console.Write("\nDate with new values is: ");
         date1.DisplayDate();

         Console.WriteLine(); // output a new line
      } // end Main
   } // end class DateTest
}

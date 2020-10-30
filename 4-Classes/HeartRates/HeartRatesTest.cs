// Exercise 4.15 Solution: HeartRatesTest.cs
// Tests class HeartRates.

using System;
using System.Collections.Generic;
using System.Text;

namespace HeartRates
{
   public class HeartRatesTest
   {
      public static void Main(string[] args)
      {
         // create a HeartRates object for a person born in 1975;
         // rates calculated based on current year 2010.
         HeartRates bob = new HeartRates("Bob", "Blue", 1975, 2010);

         Console.WriteLine("First name: {0}", bob.FirstName);
         Console.WriteLine("Last name: {0}", bob.LastName);
         Console.WriteLine("Age: {0}", bob.Age);
         Console.WriteLine("Maximum heart rate: {0}", bob.MaximumHeartRate);
         Console.WriteLine("Target heart rate range:");
         Console.WriteLine("   Minimum: {0}", bob.MinimumTargetHeartRate);
         Console.WriteLine("   Maximum: {0}", bob.MaximumTargetHeartRate);
      } // end Main
   } // end class HeartRatesTest
}

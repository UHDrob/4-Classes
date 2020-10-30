// Exercise 4.15 Solution: HeartRates.cs
// Maintains information about a person's maximum and target heart rates.
// This class assumes that the birth and current years are correct values.

using System;
using System.Collections.Generic;
using System.Text;

namespace HeartRates
{
   public class HeartRates
   {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public int BirthYear { get; set; }
      public int CurrentYear { get; set; }

      // constructor
      public HeartRates(string firstName, string lastName,
         int birthYear, int currentYear)
      {
         FirstName = firstName;
         LastName = lastName;
         BirthYear = birthYear;
         CurrentYear = currentYear;
      } // end constructor   

      // returns the person's age in years
      public int Age
      {
         get
         {
            return CurrentYear - BirthYear;
         } // end get
      } // end property Age

      // returns the maximum heart rate
      public int MaximumHeartRate
      {
         get
         {
            return 220 - Age;
         } // end get
      } // end property MaximumHeartRate

      // returns the minimum target heart rate (50% of maximum heart rate)
      public double MinimumTargetHeartRate
      {
         get
         {
            return .5 * MaximumHeartRate;
         } // end get
      } // end property MinimumTargetHeartRate

      // returns the maximum target heart rate (85% of maximum heart rate)
      public double MaximumTargetHeartRate
      {
         get
         {
            return .85 * MaximumHeartRate;
         } // end get
      } // end property MinimumTargetHeartRate
   } // end class HeartRates
}

// Exercise 4.16 Solution: HealthProfile.cs
// Maintains information about a person's maximum and target hear rates.
// This class assumes values passed to the set accessors are correct.

using System;
using System.Collections.Generic;
using System.Text;

namespace HealthProfile
{
   public class HealthProfile
   {
      public string FirstName { set; get; }
      public string LastName { set; get; }
      public string Gender { set; get; }
      public int BirthYear { set; get; }
      public int CurrentYear { set; get; }
      public double Height { set; get; }
      public double Weight { set; get; }

      // constructor
      public HealthProfile(string firstName, string lastName, string gender,
         double height, double weight, int birthYear, int currentYear)
      {
         FirstName = firstName;
         LastName = lastName;
         Gender = gender;
         Height = height;
         Weight = weight;
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
      } // end property MaximumTargetHeartRate

      // returns the person's body mass index
      public double BMI
      {
         get
         {
            return (Weight * 703) / (Height * Height);
         } // end get
      } // end property BMI

      // displays the person's health profile
      public void DisplayHealthProfile()
      {
         Console.WriteLine("\nHEALTH PROFILE FOR: {0} {1}\n",
            FirstName, LastName);
         Console.WriteLine("Gender: {0}", Gender);
         Console.WriteLine("Age: {0}", Age);
         Console.WriteLine("Height (in inches): {0}", Height);
         Console.WriteLine("Weight (in pounds): {0}", Weight);
         Console.WriteLine("Maximum heart rate: {0}", MaximumHeartRate);
         Console.WriteLine("Target heart rate range:");
         Console.WriteLine("   Minimum: {0}", MinimumTargetHeartRate);
         Console.WriteLine("   Maximum: {0}", MaximumTargetHeartRate);
         Console.WriteLine("BMI: {0}\n", BMI);
         Console.WriteLine("BMI VALUES");
         Console.WriteLine("Underweight: less than 18.5");
         Console.WriteLine("Normal:      between 18.5 and 24.9");
         Console.WriteLine("Overweight:  between 25 and 29.9");
         Console.WriteLine("Obese:       30 or greater");
      } // end method DisplayHealthProfile
   } // end class HealthProfile
}

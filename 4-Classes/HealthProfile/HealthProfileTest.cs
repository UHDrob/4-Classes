// Exercise 4.16 Solution: HealthProfileTest.cs
// Tests class HealthProfile.

using System;
using System.Collections.Generic;
using System.Text;

namespace HealthProfile
{
   public class HealthProfileTest
   {
      public static void Main(string[] args)
      {
         Console.Write("Enter first name: ");
         string firstName = Console.ReadLine();
         Console.Write("Enter last name: ");
         string lastName = Console.ReadLine();
         Console.Write("Enter gender: ");
         string gender = Console.ReadLine();
         Console.Write("Enter height in inches: ");
         double height = Convert.ToDouble(Console.ReadLine());
         Console.Write("Enter weight in pounds: ");
         double weight = Convert.ToDouble(Console.ReadLine());
         Console.Write("Enter year of birth: ");
         int birthYear = Convert.ToInt32(Console.ReadLine());
         Console.Write("Enter current year: ");
         int currentYear = Convert.ToInt32(Console.ReadLine());

         // create a HealthProfile object for a person based on the user input
         HealthProfile person =
            new HealthProfile(firstName, lastName, gender, height,
               weight, birthYear, currentYear);

         // display user's health profile
         person.DisplayHealthProfile();
      } // end Main
   } // end class HealthProfileTest
}

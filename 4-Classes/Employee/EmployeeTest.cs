// Exercise 4.13 Solution: EmployeeTest.cs
// Application to test class Employee.
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
   public class EmployeeTest
   {
      public static void Main(string[] args)
      {
         Employee employee1 = new Employee("Bob", "Jones", 2875.00M);
         Employee employee2 = new Employee("Susan", "Baker", 3150.75M);

         // display employees
         Console.WriteLine("Employee 1: {0} {1}; Yearly Salary: {2:C}",
            employee1.FirstName, employee1.LastName,
            12 * employee1.MonthlySalary);
         Console.WriteLine("Employee 2: {0} {1}; Yearly Salary: {2:C}",
            employee2.FirstName, employee2.LastName,
            12 * employee2.MonthlySalary);

         // increase employee salaries by 10%
         Console.WriteLine("\nIncreasing employee salaries by 10%");
         employee1.MonthlySalary = employee1.MonthlySalary * 1.10M;
         employee2.MonthlySalary = employee2.MonthlySalary * 1.10M;

         // display employees with new yearly salary
         Console.WriteLine("Employee 1: {0} {1}; Yearly Salary: {2:C}",
            employee1.FirstName, employee1.LastName,
            12 * employee1.MonthlySalary);
         Console.WriteLine("Employee 2: {0} {1}; Yearly Salary: {2:C}",
            employee2.FirstName, employee2.LastName,
            12 * employee2.MonthlySalary);
      } // end Main
   } // end class EmployeeTest
}

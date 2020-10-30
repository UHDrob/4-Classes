// Exercise 4.13 Solution: Employee.cs
// Employee class.

using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
   public class Employee
   {
      // auto-implemented property FirstName implicitly creates an
      // instance variable for the employee's first name
      public string FirstName { get; set; }

      // auto-implemented property LastName implicitly creates an
      // instance variable for the employee's last name
      public string LastName { get; set; }

      private decimal monthlySalary;

      // constructor to initialize first name, last name and monthly salary
      public Employee(string first, string last, decimal salary)
      {
         FirstName = first;
         LastName = last;
         MonthlySalary = salary;
      } // end three-parameter Employee constructor

      // property to get and set the salary
      public decimal MonthlySalary
      {
         get
         {
            return monthlySalary;
         } // end get
         set
         {
            if (value >= 0) // determine whether salary is nonnegative
               monthlySalary = value;
         } // end set
      } // end property MonthlySalary
   } // end class Employee
}

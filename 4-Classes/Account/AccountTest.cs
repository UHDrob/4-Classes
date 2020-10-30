// Exercise 4.11 Solution: AccountTest.cs
// Create and manipulate Account objects with a Debit method.

using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
   public class AccountTest
   {
      // Main method begins execution of C# application
      public static void Main(string[] args)
      {
         Account account1 = new Account(50.00M); // create Account object
         Account account2 = new Account(-7.53M); // create Account object

         // display initial balance of each object
         Console.WriteLine("account1 balance: {0:C}",
            account1.Balance);
         Console.WriteLine("account2 balance: {0:C}\n",
            account2.Balance);

         decimal withdrawalAmount; // withdrawal amount entered by user

         Console.Write("Enter withdrawal amount for account1: ");
         // obtain user input
         withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
         Console.WriteLine("\nsubtracting {0:C} from account1 balance",
            withdrawalAmount);
         // subtract amount from account1
         account1.Debit(withdrawalAmount);

         // display balances
         Console.WriteLine("account1 balance: {0:C}",
            account1.Balance);
         Console.WriteLine("account2 balance: {0:C}\n",
            account2.Balance);

         Console.Write("Enter withdrawal amount for account2: ");
         // obtain user input
         withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
         Console.WriteLine("\nsubtracting {0:C} from account2 balance",
            withdrawalAmount);
         // subtract amount from account2
         account2.Debit(withdrawalAmount);

         // display balances
         Console.WriteLine("account1 balance: {0:C}",
            account1.Balance);
         Console.WriteLine("account2 balance: {0:C}",
            account2.Balance);
      } // end Main
   } // end class AccountTest
}

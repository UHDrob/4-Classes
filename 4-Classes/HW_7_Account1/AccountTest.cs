// Exercise 4.9 Solution: AccountTest.cs
// Create and manipulate Account objects with a Debit method.

using System;
using System.Collections.Generic;
using System.Text;

namespace HW_7_Account1
{
   public class AccountTest
   {
      /// <summary>
      /// Please refer to Account1.pdf for requirements.
      /// </summary>
      public static void Main()
      {
         // Get account info
         Console.WriteLine("Enter the name and the balance for account1");
         string name1 = Console.ReadLine();
         var balance1 = Convert.ToDecimal(Console.ReadLine());

         Console.WriteLine("Enter the name and the balance for account2");
         string name2 = Console.ReadLine();
         var balance2 = Convert.ToDecimal(Console.ReadLine());

         Account account1 = new Account(name1, balance1);
         Account account2 = new Account(name2, balance2);

         // Display accounts
         Console.WriteLine($"\n{account1.Name}'s balance: ${account1.Balance}");
         Console.WriteLine($"{account2.Name}'s balance: ${account2.Balance}");

         // Prompt for deposit Account 1
         Console.Write("\nEnter deposit amount for account1: ");
         var deposit = Convert.ToDecimal(Console.ReadLine());
         Console.WriteLine($"adding (${deposit}) to account1 balance");
         account1.Deposit(deposit);

         // Display balances
         Console.WriteLine($"\n{account1.Name}'s balance: ${account1.Balance}");
         Console.WriteLine($"{account2.Name}'s balance: ${account2.Balance}\n");

         // Prompt for deposit Account 2
         Console.Write("Enter deposit amount for account2: ");
         deposit = Convert.ToDecimal(Console.ReadLine());
         Console.WriteLine($"adding (${deposit}) to account2 balance");
         account2.Deposit(deposit);

         // Display balances
         Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
         Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}\n");

         // Prompt for withdrawal Account 1
         Console.Write("Enter withdrawal amount for account1: ");
         var withdrawal = Convert.ToDecimal(Console.ReadLine());
         Console.WriteLine($"subtracting (${withdrawal}) to account1 balance");
         account1.Withdraw(withdrawal);

         // Display balances
         Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
         Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}\n");

         // Prompt for withdrawal Account 2
         Console.Write("Enter withdrawal amount for account2: ");
         withdrawal = Convert.ToDecimal(Console.ReadLine());
         Console.WriteLine($"subtracting (${withdrawal}) to account2 balance");
         account2.Withdraw(withdrawal);

         // Display balances
         Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
         Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}\n");

      }


   }
}

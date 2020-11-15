// UHCL
// Exercise 4.9 Solution: Account.cs
// Account class with a Debit method 
// that withdraws money from the account.

using System;
using System.Collections.Generic;
using System.Text;

namespace HW_7_Account1
{
   public class Account
   {
      private decimal _balance;

      public string Name { get; private set; } // non public set


      public Account(string accountName, decimal balance)  // constructor
      {
         Name = accountName;
         _balance = balance;
      }

      public decimal Balance
      {
         get => _balance;
         private set
         {
            if (value > 0.0m)
            {
               _balance = value;
            }
         }
      }


      // Deposit method (money into an Account)
      public void Deposit(decimal amount)
      {
         if (amount > 0)
         {
            Balance += amount; // increase the balance
         }

      }

      // Withdrawal method
      public void Withdraw(decimal amount)
      {
         if (amount <= Balance)
         {
            Balance -= amount; // decrease the balance
         }
         else
         {
            Console.WriteLine("Withdrawal amount exceeded account balance.");
         }

      }
   }
}

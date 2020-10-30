// Exercise 4.11 Solution: Account.cs
// Account class with a Debit method 
// that withdraws money from the account.

using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
   public class Account
   {
      private decimal balance; // instance variable that stores the balance

      // constructor  
      public Account(decimal initialBalance)
      {
         Balance = initialBalance; // set balance using property
      } // end Account constructor

      // credits (adds) an amount to the account
      public void Credit(decimal amount)
      {
         Balance = Balance + amount; // add amount to balance 
      } // end method Credit

      // debits (subtracts) an amount from the account
      public void Debit(decimal amount)
      {
         if (amount > Balance)
            Console.WriteLine("Debit amount exceeded account balance.");

         Balance = Balance - amount; // subtract amount from balance 
      } // end method Debit

      // property to get the balance
      public decimal Balance
      {
         get
         {
            return balance;
         } // end get
         set
         {
            // validate that value is greater than or equal to 0; 
            // if it is not, balance is left unchanged
            if (value >= 0)
               balance = value;
         } // end set
      } // end property Balance
   } // end class Account
}

// Fig. 4.9: AccountTest.cs
// Using the Account constructor to set an Account's name when an Account object is created.

using System;
using System.Collections.Generic;
using System.Text;

namespace Account3
{
   class AccountTest
   {
      static void Main()
      {
         // create two Account objects
         var account1 = new Account("Jane Green");
         var account2 = new Account("John Blue");

         // display initial value of name for each Account
         Console.WriteLine($"account1 name is: {account1.Name}");
         Console.WriteLine($"account2 name is: {account2.Name}");
         
      }


   }
}
